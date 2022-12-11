namespace AIS_Polyclinic
{
    partial class FormDiseaseView
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
            this.cNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bDeleteDisease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cNames
            // 
            this.cNames.FormattingEnabled = true;
            this.cNames.Location = new System.Drawing.Point(123, 31);
            this.cNames.Name = "cNames";
            this.cNames.Size = new System.Drawing.Size(182, 24);
            this.cNames.TabIndex = 0;
            this.cNames.SelectionChangeCommitted += new System.EventHandler(this.cNames_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название:";
            // 
            // richDescription
            // 
            this.richDescription.Location = new System.Drawing.Point(414, 80);
            this.richDescription.Name = "richDescription";
            this.richDescription.ReadOnly = true;
            this.richDescription.Size = new System.Drawing.Size(339, 323);
            this.richDescription.TabIndex = 2;
            this.richDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание:";
            // 
            // tCategory
            // 
            this.tCategory.Location = new System.Drawing.Point(123, 77);
            this.tCategory.Name = "tCategory";
            this.tCategory.ReadOnly = true;
            this.tCategory.Size = new System.Drawing.Size(182, 22);
            this.tCategory.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Категория:";
            // 
            // bDeleteDisease
            // 
            this.bDeleteDisease.Location = new System.Drawing.Point(26, 376);
            this.bDeleteDisease.Name = "bDeleteDisease";
            this.bDeleteDisease.Size = new System.Drawing.Size(110, 49);
            this.bDeleteDisease.TabIndex = 6;
            this.bDeleteDisease.Text = "Удалить диагноз";
            this.bDeleteDisease.UseVisualStyleBackColor = true;
            this.bDeleteDisease.Click += new System.EventHandler(this.bDeleteDisease_Click);
            // 
            // FormDiseaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 455);
            this.Controls.Add(this.bDeleteDisease);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cNames);
            this.Name = "FormDiseaseView";
            this.Text = "FormDiseaseView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bDeleteDisease;
    }
}