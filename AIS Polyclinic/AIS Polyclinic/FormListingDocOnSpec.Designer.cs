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
            this.SuspendLayout();
            // 
            // cSpecialty
            // 
            this.cSpecialty.FormattingEnabled = true;
            this.cSpecialty.Location = new System.Drawing.Point(108, 21);
            this.cSpecialty.Name = "cSpecialty";
            this.cSpecialty.Size = new System.Drawing.Size(199, 24);
            this.cSpecialty.TabIndex = 1;
            this.cSpecialty.SelectedIndexChanged += new System.EventHandler(this.cSpecialty_SelectedIndexChanged);
            this.cSpecialty.SelectionChangeCommitted += new System.EventHandler(this.cSpecialty_SelectionChangeCommitted);
            this.cSpecialty.SelectedValueChanged += new System.EventHandler(this.cSpecialty_SelectedValueChanged);
            this.cSpecialty.TextChanged += new System.EventHandler(this.cSpecialty_TextChanged);
            // 
            // FormListingDocOnSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(398, 73);
            this.Controls.Add(this.cSpecialty);
            this.Name = "FormListingDocOnSpec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о специалистах";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cSpecialty;
    }
}