namespace AIS_Polyclinic
{
    partial class InfoForm
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
            this.pPhoto = new System.Windows.Forms.PictureBox();
            this.bUpdate = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pPhoto
            // 
            this.pPhoto.Location = new System.Drawing.Point(12, 12);
            this.pPhoto.Name = "pPhoto";
            this.pPhoto.Size = new System.Drawing.Size(300, 300);
            this.pPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPhoto.TabIndex = 1;
            this.pPhoto.TabStop = false;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(489, 318);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(160, 44);
            this.bUpdate.TabIndex = 2;
            this.bUpdate.Text = "Изменить данные";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(348, 15);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(301, 297);
            this.richTextBoxInfo.TabIndex = 3;
            this.richTextBoxInfo.Text = "";
            this.richTextBoxInfo.ZoomFactor = 1.3F;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 381);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.pPhoto);
            this.Name = "InfoForm";
            this.Text = "Информация о человеке";
            this.Activated += new System.EventHandler(this.InfoForm_Activated);
            this.Shown += new System.EventHandler(this.InfoForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pPhoto;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
    }
}