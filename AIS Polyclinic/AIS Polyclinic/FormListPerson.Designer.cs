namespace AIS_Polyclinic
{
    partial class FormListPerson
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
            this.dataPerson = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPerson
            // 
            this.dataPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerson.Location = new System.Drawing.Point(12, 47);
            this.dataPerson.Name = "dataPerson";
            this.dataPerson.RowHeadersWidth = 51;
            this.dataPerson.RowTemplate.Height = 24;
            this.dataPerson.Size = new System.Drawing.Size(776, 357);
            this.dataPerson.TabIndex = 0;
            this.dataPerson.DoubleClick += new System.EventHandler(this.dataPerson_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Найти";
            // 
            // tFind
            // 
            this.tFind.Location = new System.Drawing.Point(79, 18);
            this.tFind.Name = "tFind";
            this.tFind.Size = new System.Drawing.Size(100, 22);
            this.tFind.TabIndex = 2;
            this.tFind.TextChanged += new System.EventHandler(this.tFind_TextChanged);
            this.tFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tFind_KeyPress);
            // 
            // FormListPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataPerson);
            this.Name = "FormListPerson";
            this.Text = "FormListPerson";
            this.Activated += new System.EventHandler(this.FormListPerson_Activated);
            this.Shown += new System.EventHandler(this.FormListPerson_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tFind;
    }
}