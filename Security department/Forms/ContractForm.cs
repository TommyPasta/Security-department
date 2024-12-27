using Security_department.DTOs;
using Security_department.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Security_department.Forms
{
    public partial class ContractForm : Form, IContractView
    {
        public ContractForm()
        {
            InitializeComponent();
        }

        // Свойства для получения данных из формы
        public int Id => int.TryParse(txtId.Text, out var id) ? id : 0; // Идентификатор контракта
        public int ClientId => (int)comboBoxClients.SelectedValue; // Идентификатор клиента
        public int ObjectId => (int)comboBoxObjects.SelectedValue; // Идентификатор объекта
        public DateTime StartDate => dtpStartDate.Value; // Дата начала контракта
        public DateTime EndDate => dtpEndDate.Value; // Дата окончания контракта
        public int Penalty => int.TryParse(txtPenalty.Text, out var penalty) ? penalty : 0; // Штраф
        public float InterestRate
        {
            get => float.TryParse(txtInterestRate.Text, out var rate) ? rate : 0; // Процентная ставка
            set => txtInterestRate.Text = value.ToString(); // Сеттер для процентной ставки
        }
        public string AdditionalConditions => txtAdditionalConditions.Text; // Дополнительные условия
        public float PaymentAmount => float.TryParse(txtPaymentAmount.Text, out var amount) ? amount : 0; // Сумма платежа

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            // Логика для добавления контракта
        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            // Логика для обновления контракта
        }

        private void btnRemoveContract_Click(object sender, EventArgs e)
        {
            // Логика для удаления контракта
        }

        public void LoadContracts(List<ContractDTO> contracts)
        {
            // Метод для загрузки контрактов в таблицу
            dataGridViewContracts.Rows.Clear();
            foreach (var contract in contracts)
            {
                dataGridViewContracts.Rows.Add(contract.Id, contract.ClientId, contract.Object.Id, contract.StartDate, contract.EndDate, contract.Penalty, contract.InterestRate, contract.AdditionalConditions, contract.PaymentAmount);
            }
        }

        public void ClearFields()
        {
            // Метод для очистки полей ввода
            txtId.Clear();
            comboBoxClients.SelectedIndex = -1;
            comboBoxObjects.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            txtPenalty.Clear();
            txtInterestRate.Clear();
            txtAdditionalConditions.Clear();
            txtPaymentAmount.Clear();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}