namespace StageCeviDriesMaxwell2012
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnData = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.rtxtData = new System.Windows.Forms.RichTextBox();
            this.rtxtConn = new System.Windows.Forms.RichTextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(570, 24);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(82, 24);
            this.btnData.TabIndex = 0;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(570, 71);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(81, 23);
            this.btnConn.TabIndex = 1;
            this.btnConn.Text = "Connectie";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(32, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 188);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(326, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 188);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(32, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 94);
            this.panel3.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(570, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 25);
            this.button4.TabIndex = 8;
            this.button4.Text = "Volgende";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // rtxtData
            // 
            this.rtxtData.Location = new System.Drawing.Point(31, 25);
            this.rtxtData.Name = "rtxtData";
            this.rtxtData.Size = new System.Drawing.Size(503, 22);
            this.rtxtData.TabIndex = 9;
            this.rtxtData.Text = "";
            // 
            // rtxtConn
            // 
            this.rtxtConn.Location = new System.Drawing.Point(31, 71);
            this.rtxtConn.Name = "rtxtConn";
            this.rtxtConn.Size = new System.Drawing.Size(503, 22);
            this.rtxtConn.TabIndex = 10;
            this.rtxtConn.Text = "";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(31, 111);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(92, 26);
            this.btnParse.TabIndex = 11;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(12, 122);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(627, 400);
            this.webBrowser.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 482);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.rtxtConn);
            this.Controls.Add(this.rtxtData);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.btnData);
            this.Name = "Form1";
            this.Text = "Layout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox rtxtData;
        private System.Windows.Forms.RichTextBox rtxtConn;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
			
			 
			
    }
}

