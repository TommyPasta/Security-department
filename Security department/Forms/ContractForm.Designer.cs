namespace Security_department.Forms
{
    partial class ContractForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewContracts = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtAdditionalConditions = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxObjects = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.lblId = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblAdditionalConditions = new System.Windows.Forms.Label();
            this.lblPaymentAmount = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewContracts
            // 
            this.dataGridViewContracts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContracts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewContracts.Size = new System.Drawing.Size(550, 500);

            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(580, 15);
            this.lblId.Text = "ID:";

            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(700, 12);
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(150, 20);

            // 
            // lblClient
            // 
            this.lblClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(580, 45);
            this.lblClient.Text = "Клиент:";

            // 
            // comboBoxClients
            // 
            this.comboBoxClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClients.Location = new System.Drawing.Point(700, 42);
            this.comboBoxClients.Size = new System.Drawing.Size(200, 21);

            // 
            // lblObject
            // 
            this.lblObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(580, 75);
            this.lblObject.Text = "Объект:";

            // 
            // comboBoxObjects
            // 
            this.comboBoxObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxObjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObjects.Location = new System.Drawing.Point(700, 72);
            this.comboBoxObjects.Size = new System.Drawing.Size(200, 21);

            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(580, 105);
            this.lblStartDate.Text = "Дата начала:";

            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.Location = new System.Drawing.Point(700, 102);
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);

            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(580, 135);
            this.lblEndDate.Text = "Дата окончания:";

            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Location = new System.Drawing.Point(700, 132);
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);

            // 
            // lblPenalty
            // 
            this.lblPenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Location = new System.Drawing.Point(580, 165);
            this.lblPenalty.Text = "Штраф (руб):";

            // 
            // txtPenalty
            // 
            this.txtPenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPenalty.Location = new System.Drawing.Point(700, 162);
            this.txtPenalty.Size = new System.Drawing.Size(100, 20);

            // 
            // lblInterestRate
            // 
            this.lblInterestRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(580, 195);
            this.lblInterestRate.Text = "Ставка (%):";

            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInterestRate.Location = new System.Drawing.Point(700, 192);
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);

            // 
            // lblAdditionalConditions
            // 
            this.lblAdditionalConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdditionalConditions.AutoSize = true;
            this.lblAdditionalConditions.Location = new System.Drawing.Point(580, 225);
            this.lblAdditionalConditions.Text = "Доп. условия:";

            // 
            // txtAdditionalConditions
            // 
            this.txtAdditionalConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdditionalConditions.Location = new System.Drawing.Point(700, 222);
            this.txtAdditionalConditions.Multiline = true;
            this.txtAdditionalConditions.Size = new System.Drawing.Size(200, 80);

            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(580, 315);
            this.lblPaymentAmount.Text = "Сумма оплаты:";

            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentAmount.Location = new System.Drawing.Point(700, 312);
            this.txtPaymentAmount.Size = new System.Drawing.Size(100, 20);

            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(583, 470);
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(680, 470);
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(777, 470);
            this.btnRemove.Size = new System.Drawing.Size(90, 35);
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(583, 510);
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 560);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление договорами";

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dataGridViewContracts,
                this.lblId, this.txtId,
                this.lblClient, this.comboBoxClients,
                this.lblObject, this.comboBoxObjects,
                this.lblStartDate, this.dtpStartDate,
                this.lblEndDate, this.dtpEndDate,
                this.lblPenalty, this.txtPenalty,
                this.lblInterestRate, this.txtInterestRate,
                this.lblAdditionalConditions, this.txtAdditionalConditions,
                this.lblPaymentAmount, this.txtPaymentAmount,
                this.btnAdd, this.btnUpdate, this.btnRemove, this.btnClear
            });

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewContracts;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtAdditionalConditions;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxObjects;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblAdditionalConditions;
        private System.Windows.Forms.Label lblPaymentAmount;
    }
}