namespace AIS_Polyclinic
{
    partial class FormListingDocOnSpec
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
            this.cSpecialty = new System.Windows.Forms.ComboBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cSpecialty
            // 
            this.cSpecialty.FormattingEnabled = true;
            this.cSpecialty.Location = new System.Drawing.Point(108, 21);
            this.cSpecialty.Name = "cSpecialty";
            this.cSpecialty.Size = new System.Drawing.Size(199, 24);
            this.cSpecialty.TabIndex = 1;
            this.cSpecialty.SelectionChangeCommitted += new System.EventHandler(this.cSpecialty_SelectionChangeCommitted);
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(152, 68);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(110, 73);
            this.bCreate.TabIndex = 2;
            this.bCreate.Text = "Создать документ";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // FormListingDocOnSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 165);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.cSpecialty);
            this.Name = "FormListingDocOnSpec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о специалистах";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cSpecialty;
        private System.Windows.Forms.Button bCreate;
    }
}