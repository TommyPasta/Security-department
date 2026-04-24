namespace Security_department.Forms
{
    partial class SecurityPatrolForm
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
            this.dataGridViewPatrols = new System.Windows.Forms.DataGridView();
            this.txtCrewNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommanderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCallReason = new System.Windows.Forms.TextBox();
            this.dtpDepartureDateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStolenItemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStolenItemValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIssuingAuthority = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.btnExecutePatrol = new System.Windows.Forms.Button();
            this.btnAddStolenItem = new System.Windows.Forms.Button();
            this.btnAddArrestDetails = new System.Windows.Forms.Button();
            this.comboBoxContracts = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatrols)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatrols
            // 
            this.dataGridViewPatrols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatrols.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPatrols.Name = "dataGridViewPatrols";
            this.dataGridViewPatrols.Size = new System.Drawing.Size(424, 524);
            this.dataGridViewPatrols.TabIndex = 0;
            // 
            // txtCrewNumber
            // 
            this.txtCrewNumber.Location = new System.Drawing.Point(611, 45);
            this.txtCrewNumber.Name = "txtCrewNumber";
            this.txtCrewNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCrewNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер экипажа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя командира";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCommanderName
            // 
            this.txtCommanderName.Location = new System.Drawing.Point(611, 72);
            this.txtCommanderName.Name = "txtCommanderName";
            this.txtCommanderName.Size = new System.Drawing.Size(100, 20);
            this.txtCommanderName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Причина вызова";
            // 
            // txtCallReason
            // 
            this.txtCallReason.Location = new System.Drawing.Point(611, 99);
            this.txtCallReason.Name = "txtCallReason";
            this.txtCallReason.Size = new System.Drawing.Size(100, 20);
            this.txtCallReason.TabIndex = 5;
            // 
            // dtpDepartureDateTime
            // 
            this.dtpDepartureDateTime.Location = new System.Drawing.Point(611, 126);
            this.dtpDepartureDateTime.Name = "dtpDepartureDateTime";
            this.dtpDepartureDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDepartureDateTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата и время выезда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Украденная вещь";
            // 
            // txtStolenItemName
            // 
            this.txtStolenItemName.Location = new System.Drawing.Point(611, 216);
            this.txtStolenItemName.Name = "txtStolenItemName";
            this.txtStolenItemName.Size = new System.Drawing.Size(100, 20);
            this.txtStolenItemName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Оценочная стоимость";
            // 
            // txtStolenItemValue
            // 
            this.txtStolenItemValue.Location = new System.Drawing.Point(611, 243);
            this.txtStolenItemValue.Name = "txtStolenItemValue";
            this.txtStolenItemValue.Size = new System.Drawing.Size(100, 20);
            this.txtStolenItemValue.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер документа";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(611, 315);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentNumber.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Орган выдавший документ";
            // 
            // txtIssuingAuthority
            // 
            this.txtIssuingAuthority.Location = new System.Drawing.Point(611, 342);
            this.txtIssuingAuthority.Name = "txtIssuingAuthority";
            this.txtIssuingAuthority.Size = new System.Drawing.Size(100, 20);
            this.txtIssuingAuthority.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Дата выдачи";
            // 
            // dtpDateOfIssue
            // 
            this.dtpDateOfIssue.Location = new System.Drawing.Point(611, 369);
            this.dtpDateOfIssue.Name = "dtpDateOfIssue";
            this.dtpDateOfIssue.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfIssue.TabIndex = 19;
            // 
            // btnExecutePatrol
            // 
            this.btnExecutePatrol.Location = new System.Drawing.Point(490, 420);
            this.btnExecutePatrol.Name = "btnExecutePatrol";
            this.btnExecutePatrol.Size = new System.Drawing.Size(100, 40);
            this.btnExecutePatrol.TabIndex = 20;
            this.btnExecutePatrol.Text = "Выполнить патруль";
            this.btnExecutePatrol.UseVisualStyleBackColor = true;
            this.btnExecutePatrol.Click += new System.EventHandler(this.btnExecutePatrol_Click);
            // 
            // btnAddStolenItem
            // 
            this.btnAddStolenItem.Location = new System.Drawing.Point(611, 420);
            this.btnAddStolenItem.Name = "btnAddStolenItem";
            this.btnAddStolenItem.Size = new System.Drawing.Size(100, 40);
            this.btnAddStolenItem.TabIndex = 21;
            this.btnAddStolenItem.Text = "Добавить вещь";
            this.btnAddStolenItem.UseVisualStyleBackColor = true;
            this.btnAddStolenItem.Click += new System.EventHandler(this.btnAddStolenItem_Click);
            // 
            // btnAddArrestDetails
            // 
            this.btnAddArrestDetails.Location = new System.Drawing.Point(730, 420);
            this.btnAddArrestDetails.Name = "btnAddArrestDetails";
            this.btnAddArrestDetails.Size = new System.Drawing.Size(100, 40);
            this.btnAddArrestDetails.TabIndex = 22;
            this.btnAddArrestDetails.Text = "Добавить задержание";
            this.btnAddArrestDetails.UseVisualStyleBackColor = true;
            this.btnAddArrestDetails.Click += new System.EventHandler(this.btnAddArrestDetails_Click);
            // 
            // comboBoxContracts
            // 
            this.comboBoxContracts.FormattingEnabled = true;
            this.comboBoxContracts.Location = new System.Drawing.Point(611, 175);
            this.comboBoxContracts.Name = "comboBoxContracts";
            this.comboBoxContracts.Size = new System.Drawing.Size(100, 21);
            this.comboBoxContracts.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Контракт";
            // 
            // SecurityPatrolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 548);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxContracts);
            this.Controls.Add(this.btnAddArrestDetails);
            this.Controls.Add(this.btnAddStolenItem);
            this.Controls.Add(this.btnExecutePatrol);
            this.Controls.Add(this.dtpDateOfIssue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIssuingAuthority);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStolenItemValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStolenItemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDepartureDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCallReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCommanderName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCrewNumber);
            this.Controls.Add(this.dataGridViewPatrols);
            this.Name = "SecurityPatrolForm";
            this.Text = "Патрули";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatrols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatrols;
        private System.Windows.Forms.TextBox txtCrewNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommanderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCallReason;
        private System.Windows.Forms.DateTimePicker dtpDepartureDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStolenItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStolenItemValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIssuingAuthority;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDateOfIssue;
        private System.Windows.Forms.Button btnExecutePatrol;
        private System.Windows.Forms.Button btnAddStolenItem;
        private System.Windows.Forms.Button btnAddArrestDetails;
        private System.Windows.Forms.ComboBox comboBoxContracts;
        private System.Windows.Forms.Label label10;
    }
}