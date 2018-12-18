namespace WcfWindowsClient
{
    partial class MainForm
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
            this.bntGetData = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();
            // 
            // bntGetData
            // 
            this.bntGetData.Location = new System.Drawing.Point(12, 12);
            this.bntGetData.Name = "bntGetData";
            this.bntGetData.Size = new System.Drawing.Size(75, 23);
            this.bntGetData.TabIndex = 0;
            this.bntGetData.Text = "GetData()";
            this.bntGetData.UseVisualStyleBackColor = true;
            this.bntGetData.Click += new System.EventHandler(this.bntGetData_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 41);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(260, 208);
            this.txtResult.TabIndex = 1;
            // 
            // numValue
            // 
            this.numValue.Location = new System.Drawing.Point(93, 15);
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(61, 20);
            this.numValue.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numValue);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.bntGetData);
            this.Name = "MainForm";
            this.Text = "WCF client";
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntGetData;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.NumericUpDown numValue;
    }
}

