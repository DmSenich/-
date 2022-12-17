namespace AIS_Polyclinic
{
    partial class CreateVisitingForm
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
            this.bOK = new System.Windows.Forms.Button();
            this.dataDoctor = new System.Windows.Forms.DataGridView();
            this.dataPatient = new System.Windows.Forms.DataGridView();
            this.dateTimeVisit = new System.Windows.Forms.DateTimePicker();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tFindPat = new System.Windows.Forms.TextBox();
            this.tFindDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cSpecs = new System.Windows.Forms.ComboBox();
            this.checkSpecs = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(681, 299);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(95, 40);
            this.bOK.TabIndex = 0;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // dataDoctor
            // 
            this.dataDoctor.AllowUserToAddRows = false;
            this.dataDoctor.AllowUserToDeleteRows = false;
            this.dataDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoctor.Location = new System.Drawing.Point(196, 70);
            this.dataDoctor.Name = "dataDoctor";
            this.dataDoctor.ReadOnly = true;
            this.dataDoctor.RowHeadersWidth = 51;
            this.dataDoctor.RowTemplate.Height = 24;
            this.dataDoctor.Size = new System.Drawing.Size(490, 95);
            this.dataDoctor.TabIndex = 1;
            this.dataDoctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDoctor_CellClick);
            this.dataDoctor.DoubleClick += new System.EventHandler(this.dataDoctor_DoubleClick);
            // 
            // dataPatient
            // 
            this.dataPatient.AllowUserToAddRows = false;
            this.dataPatient.AllowUserToDeleteRows = false;
            this.dataPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPatient.Location = new System.Drawing.Point(196, 185);
            this.dataPatient.Name = "dataPatient";
            this.dataPatient.ReadOnly = true;
            this.dataPatient.RowHeadersWidth = 51;
            this.dataPatient.RowTemplate.Height = 24;
            this.dataPatient.Size = new System.Drawing.Size(490, 98);
            this.dataPatient.TabIndex = 2;
            this.dataPatient.DoubleClick += new System.EventHandler(this.dataPatient_DoubleClick);
            // 
            // dateTimeVisit
            // 
            this.dateTimeVisit.Location = new System.Drawing.Point(196, 18);
            this.dateTimeVisit.Name = "dateTimeVisit";
            this.dateTimeVisit.Size = new System.Drawing.Size(200, 22);
            this.dateTimeVisit.TabIndex = 3;
            this.dateTimeVisit.ValueChanged += new System.EventHandler(this.dateTimeVisit_ValueChanged);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(565, 299);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(95, 40);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "На данный день у этого врача назначено визитов: 0";
            // 
            // tFindPat
            // 
            this.tFindPat.Location = new System.Drawing.Point(11, 214);
            this.tFindPat.Name = "tFindPat";
            this.tFindPat.Size = new System.Drawing.Size(164, 22);
            this.tFindPat.TabIndex = 14;
            this.tFindPat.TextChanged += new System.EventHandler(this.tFindPat_TextChanged);
            this.tFindPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tFindPat_KeyPress);
            // 
            // tFindDoc
            // 
            this.tFindDoc.Location = new System.Drawing.Point(15, 98);
            this.tFindDoc.Name = "tFindDoc";
            this.tFindDoc.Size = new System.Drawing.Size(164, 22);
            this.tFindDoc.TabIndex = 13;
            this.tFindDoc.TextChanged += new System.EventHandler(this.tFindDoc_TextChanged);
            this.tFindDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tFindDoc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Найти/выбрать пациента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Найти/выбрать доктора:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Найти по дате:";
            // 
            // cSpecs
            // 
            this.cSpecs.FormattingEnabled = true;
            this.cSpecs.Location = new System.Drawing.Point(474, 18);
            this.cSpecs.Name = "cSpecs";
            this.cSpecs.Size = new System.Drawing.Size(201, 24);
            this.cSpecs.TabIndex = 16;
            this.cSpecs.SelectionChangeCommitted += new System.EventHandler(this.cSpecs_SelectionChangeCommitted);
            // 
            // checkSpecs
            // 
            this.checkSpecs.AutoSize = true;
            this.checkSpecs.Location = new System.Drawing.Point(681, 22);
            this.checkSpecs.Name = "checkSpecs";
            this.checkSpecs.Size = new System.Drawing.Size(18, 17);
            this.checkSpecs.TabIndex = 17;
            this.checkSpecs.UseVisualStyleBackColor = true;
            this.checkSpecs.CheckedChanged += new System.EventHandler(this.checkSpecs_CheckedChanged);
            // 
            // CreateVisitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 358);
            this.Controls.Add(this.checkSpecs);
            this.Controls.Add(this.cSpecs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tFindPat);
            this.Controls.Add(this.tFindDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dateTimeVisit);
            this.Controls.Add(this.dataPatient);
            this.Controls.Add(this.dataDoctor);
            this.Controls.Add(this.bOK);
            this.Name = "CreateVisitingForm";
            this.Text = "Назначение визита";
            this.Activated += new System.EventHandler(this.CreateVisitingForm_Activated);
            this.Shown += new System.EventHandler(this.CreateVisitingForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.DataGridView dataDoctor;
        private System.Windows.Forms.DataGridView dataPatient;
        private System.Windows.Forms.DateTimePicker dateTimeVisit;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tFindPat;
        private System.Windows.Forms.TextBox tFindDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cSpecs;
        private System.Windows.Forms.CheckBox checkSpecs;
    }
}