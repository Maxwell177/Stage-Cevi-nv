using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace StageCeviDriesMaxwell2012
{
    public partial class Form1 : Form
    {
        private readonly DataSet ds;
        private System.Globalization.NumberFormatInfo numberFormatInfo = null;
        private string rapport;
        private string connectieBestand = "";

        public Form1()
        {
            InitializeComponent();
            btnParse.Enabled = false;
            System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.InstalledUICulture;
            numberFormatInfo = (System.Globalization.NumberFormatInfo)ci.NumberFormat.Clone();
            numberFormatInfo.NumberGroupSeparator = "";
            numberFormatInfo.NumberDecimalSeparator = ".";

            ds = new DataSet();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            webBrowser.Url = null;

            rtxtData.Text = "";
            
            openFileDialog1.Title = "Selecteer het bestand met de gegevens";
            openFileDialog1.Filter = "Xml|*.xml";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // nagaan of de pagina een 'default.aspx' is.
                string ext = Path.GetExtension(openFileDialog1.FileName.ToUpper());
                if (ext == ".XML")
                {
                    try
                    {
                        string datasetAsString = "";
                        StreamReader reader = new StreamReader(openFileDialog1.FileName);
                        datasetAsString = reader.ReadToEnd();
                        reader.Close();

                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(datasetAsString);

                        // XML op basis van ruwe dataset aanvullen met extra informatie
                        foreach (XmlNode xmlNodeFeatureData in xmlDoc.ChildNodes)
                        {
                            // Mapdata wegschrijven
                            foreach (XmlNode xmlNodeFeature in xmlNodeFeatureData.ChildNodes)
                            {
                                if (xmlNodeFeature.Name == "Mapdata")
                                {
                                    double orginalScale = 0;

                                    foreach (XmlNode childXmlNode in xmlNodeFeature.ChildNodes)
                                    {
                                        if (childXmlNode.Name == "OriginalScale")
                                        {
                                            // Originele schaal van de kaart in FlexViewer
                                            //orginalScale = Convert.ToDouble(childXmlNode.InnerText.Replace(".", ","), _numberFormatInfo);
                                            orginalScale = Convert.ToDouble(childXmlNode.InnerText, numberFormatInfo);

                                            childXmlNode.InnerText = Convert.ToInt32(orginalScale).ToString();
                                        }

                                        if (childXmlNode.Name == "ImageScale")
                                        {
                                            // Schaal van de kaart in Rapport
                                            int imageScale = Convert.ToInt32(orginalScale);
                                            childXmlNode.InnerText = imageScale.ToString();
                                        }
                                    }
                                }
                            }
                        }

                        // XML op basis van ruwe dataset converteren naar een .Net DataSet
                        TextReader textReader = new StringReader(xmlDoc.InnerXml);

                        ds.ReadXml(textReader);
                        rtxtData.Text = openFileDialog1.FileName;
                        btnParse.Enabled = ((rtxtData.Text != "") && (rtxtConn.Text != ""));
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Exception bij inlezen dataset: " + exc.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Kies een xmlbestand (.XML)");
                }
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            webBrowser.Url = null;

            rtxtConn.Text = "";

            openFileDialog1.Title = "Selecteer het connectiebestand";
            openFileDialog1.Filter = "Xml|*.xml";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // nagaan of de pagina een 'default.aspx' is.
                string ext = Path.GetExtension(openFileDialog1.FileName.ToUpper());
                if (ext == ".XML")
                {
                    try
                    {
                        StreamReader reader = new StreamReader(openFileDialog1.FileName);
                        connectieBestand = reader.ReadToEnd();
                        reader.Close();

                                              
                        rtxtConn.Text = openFileDialog1.FileName;
                        btnParse.Enabled = ((rtxtConn.Text != "") && (rtxtData.Text != ""));
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show("Exception bij inlezen dataset: " + exc.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Kies een xmlbestand (.XML)");
                }
             }

        }

   
    }
}
