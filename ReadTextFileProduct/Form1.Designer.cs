namespace ReadTextFileProduct
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
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.productName = new System.Windows.Forms.TextBox();
            this.exportFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(245, 30);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(173, 53);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Chọn file để chuyển đổi";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(126, 102);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(410, 20);
            this.productName.TabIndex = 1;
            // 
            // exportFile
            // 
            this.exportFile.Location = new System.Drawing.Point(555, 102);
            this.exportFile.Name = "exportFile";
            this.exportFile.Size = new System.Drawing.Size(75, 23);
            this.exportFile.TabIndex = 2;
            this.exportFile.Text = "Xuất file";
            this.exportFile.UseVisualStyleBackColor = true;
            this.exportFile.Click += new System.EventHandler(this.exportFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportFile);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.btnChooseFile);
            this.Name = "Form1";
            this.Text = "Export Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Button exportFile;
        private System.Windows.Forms.Label label1;
    }
}

