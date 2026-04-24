using Security_department.DTOs;
using Security_department.Presenters.Interface;
using Security_department.Services.Interface;
using Security_department.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Security_department.Forms
{
    public partial class ContractForm : Form, IContractView
    {
        private IContractPresenter _contractPresenter;
        private IObjectService _objectService;
        private IClientService _clientService;

        public ContractForm()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        public void SetPresenter(IContractPresenter contractPresenter, IObjectService objectService, IClientService clientService)
        {
            _contractPresenter = contractPresenter;
            _objectService = objectService;
            _clientService = clientService;
            LoadComboBoxes();
        }

        private void SetupDataGridView()
        {
            dataGridViewContracts.Columns.Add("Id", "ID");
            dataGridViewContracts.Columns.Add("ClientId", "Клиент ID");
            dataGridViewContracts.Columns.Add("ObjectId", "Объект ID");
            dataGridViewContracts.Columns.Add("StartDate", "Дата начала");
            dataGridViewContracts.Columns.Add("EndDate", "Дата окончания");
            dataGridViewContracts.Columns.Add("Penalty", "Штраф");
            dataGridViewContracts.Columns.Add("InterestRate", "Процент");
            dataGridViewContracts.Columns.Add("AdditionalConditions", "Доп. условия");
            dataGridViewContracts.Columns.Add("PaymentAmount", "Сумма платежа");
        }

        private void LoadComboBoxes()
        {
            // Загрузка клиентов
            var clients = _clientService.GetAllClients();
            comboBoxClients.DataSource = clients;
            comboBoxClients.DisplayMember = "FirstName";
            comboBoxClients.ValueMember = "Id";

            // Загрузка объектов
            var objects = _objectService.GetAllObjects();
            comboBoxObjects.DataSource = objects;
            comboBoxObjects.DisplayMember = "Address";
            comboBoxObjects.ValueMember = "Id";
        }

        public int Id
        {
            get => int.TryParse(txtId.Text, out var id) ? id : 0;
            set => txtId.Text = value.ToString();
        }

        public int ClientId => comboBoxClients.SelectedValue != null ? (int)comboBoxClients.SelectedValue : 0;

        public int ObjectId => comboBoxObjects.SelectedValue != null ? (int)comboBoxObjects.SelectedValue : 0;

        public DateTime StartDate => dtpStartDate.Value;

        public DateTime EndDate => dtpEndDate.Value;

        public int Penalty
        {
            get => int.TryParse(txtPenalty.Text, out var penalty) ? penalty : 0;
            set => txtPenalty.Text = value.ToString();
        }

        public float InterestRate
        {
            get => float.TryParse(txtInterestRate.Text, out var rate) ? rate : 0;
            set => txtInterestRate.Text = value.ToString();
        }

        public string AdditionalConditions => txtAdditionalConditions.Text;

        public float PaymentAmount
        {
            get => float.TryParse(txtPaymentAmount.Text, out var amount) ? amount : 0;
            set => txtPaymentAmount.Text = value.ToString();
        }

        public void LoadContracts(List<ContractDTO> contracts)
        {
            dataGridViewContracts.Rows.Clear();
            foreach (var contract in contracts)
            {
                dataGridViewContracts.Rows.Add(
                    contract.Id,
                    contract.ClientId,
                    contract.Object?.Id,
                    contract.StartDate.ToShortDateString(),
                    contract.EndDate.ToShortDateString(),
                    contract.Penalty,
                    contract.InterestRate,
                    contract.AdditionalConditions,
                    contract.PaymentAmount
                );
            }
        }

        public void ClearFields()
        {
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

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            try
            {
                var objectDto = _objectService.GetObjectById(ObjectId);
                if (objectDto == null)
                {
                    ShowMessage("Объект не найден.");
                    return;
                }

                var contractDto = new ContractDTO
                {
                    Id = Id,
                    ClientId = ClientId,
                    Object = objectDto,
                    StartDate = StartDate,
                    EndDate = EndDate,
                    Penalty = Penalty,
                    InterestRate = InterestRate,
                    AdditionalConditions = AdditionalConditions,
                    PaymentAmount = PaymentAmount
                };

                _contractPresenter.AddContract(contractDto);
                ClearFields();
                ShowMessage("Контракт успешно добавлен.");
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка: {ex.Message}");
            }
        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            try
            {
                var objectDto = _objectService.GetObjectById(ObjectId);
                if (objectDto == null)
                {
                    ShowMessage("Объект не найден.");
                    return;
                }

                var contractDto = new ContractDTO
                {
                    Id = Id,
                    ClientId = ClientId,
                    Object = objectDto,
                    StartDate = StartDate,
                    EndDate = EndDate,
                    Penalty = Penalty,
                    InterestRate = InterestRate,
                    AdditionalConditions = AdditionalConditions,
                    PaymentAmount = PaymentAmount
                };

                _contractPresenter.UpdateContract(contractDto);
                ClearFields();
                ShowMessage("Контракт успешно обновлен.");
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка: {ex.Message}");
            }
        }

        private void btnRemoveContract_Click(object sender, EventArgs e)
        {
            try
            {
                _contractPresenter.RemoveContract(Id);
                ClearFields();
                ShowMessage("Контракт успешно удален.");
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка: {ex.Message}");
            }
        }
    }
}