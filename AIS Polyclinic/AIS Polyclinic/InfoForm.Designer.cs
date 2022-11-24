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
            this.dataInfo = new System.Windows.Forms.DataGridView();
            this.pPhoto = new System.Windows.Forms.PictureBox();
            this.bUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataInfo
            // 
            this.dataInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInfo.Location = new System.Drawing.Point(12, 12);
            this.dataInfo.Name = "dataInfo";
            this.dataInfo.RowHeadersWidth = 51;
            this.dataInfo.RowTemplate.Height = 24;
            this.dataInfo.Size = new System.Drawing.Size(873, 96);
            this.dataInfo.TabIndex = 0;
            this.dataInfo.DoubleClick += new System.EventHandler(this.dataInfo_DoubleClick);
            // 
            // pPhoto
            // 
            this.pPhoto.Location = new System.Drawing.Point(12, 114);
            this.pPhoto.Name = "pPhoto";
            this.pPhoto.Size = new System.Drawing.Size(300, 300);
            this.pPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPhoto.TabIndex = 1;
            this.pPhoto.TabStop = false;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(705, 367);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(160, 44);
            this.bUpdate.TabIndex = 2;
            this.bUpdate.Text = "Изменить данные";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 465);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.pPhoto);
            this.Controls.Add(this.dataInfo);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.Activated += new System.EventHandler(this.InfoForm_Activated);
            this.Shown += new System.EventHandler(this.InfoForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataInfo;
        private System.Windows.Forms.PictureBox pPhoto;
        private System.Windows.Forms.Button bUpdate;
    }
}