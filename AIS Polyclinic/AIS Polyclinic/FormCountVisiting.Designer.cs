namespace AIS_Polyclinic
{
    partial class FormCountVisiting
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
            this.tFindDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDoctor = new System.Windows.Forms.DataGridView();
            this.bCreateDocument = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // tFindDoc
            // 
            this.tFindDoc.Location = new System.Drawing.Point(25, 51);
            this.tFindDoc.Name = "tFindDoc";
            this.tFindDoc.Size = new System.Drawing.Size(164, 22);
            this.tFindDoc.TabIndex = 16;
            this.tFindDoc.TextChanged += new System.EventHandler(this.tFindDoc_TextChanged);
            this.tFindDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tFindDoc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Найти/выбрать доктора:";
            // 
            // dataDoctor
            // 
            this.dataDoctor.AllowUserToAddRows = false;
            this.dataDoctor.AllowUserToDeleteRows = false;
            this.dataDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoctor.Location = new System.Drawing.Point(206, 23);
            this.dataDoctor.Name = "dataDoctor";
            this.dataDoctor.ReadOnly = true;
            this.dataDoctor.RowHeadersWidth = 51;
            this.dataDoctor.RowTemplate.Height = 24;
            this.dataDoctor.Size = new System.Drawing.Size(292, 387);
            this.dataDoctor.TabIndex = 14;
            // 
            // bCreateDocument
            // 
            this.bCreateDocument.Location = new System.Drawing.Point(25, 315);
            this.bCreateDocument.Name = "bCreateDocument";
            this.bCreateDocument.Size = new System.Drawing.Size(133, 95);
            this.bCreateDocument.TabIndex = 17;
            this.bCreateDocument.Text = "Создать документ по конкретному врачу";
            this.bCreateDocument.UseVisualStyleBackColor = true;
            this.bCreateDocument.Click += new System.EventHandler(this.bCreateDocument_Click);
            // 
            // FormCountVisiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.bCreateDocument);
            this.Controls.Add(this.tFindDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataDoctor);
            this.Name = "FormCountVisiting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о визитах";
            this.Load += new System.EventHandler(this.FormCountVisiting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tFindDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataDoctor;
        private System.Windows.Forms.Button bCreateDocument;
    }
}