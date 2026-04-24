using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Security_department.DTOs;
using Security_department.Mappers;
using Security_department.Presenters.Interface;
using Security_department.Services.Interface;
using Security_department.Views;

namespace Security_department.Forms
{
    public partial class SecurityPatrolForm : Form, ISecurityPatrolView
    {
        private ISecurityPatrolPresenter _securityPatrolPresenter;
        private IContractService _contractService;

        public SecurityPatrolForm()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        public void SetPresenter(ISecurityPatrolPresenter securityPatrolPresenter, IContractService contractService)
        {
            _securityPatrolPresenter = securityPatrolPresenter;
            _contractService = contractService;
            LoadContracts();
        }

        private void SetupDataGridView()
        {
            dataGridViewPatrols.Columns.Add("PatrolId", "ID");
            dataGridViewPatrols.Columns.Add("CrewNumber", "Экипаж");
            dataGridViewPatrols.Columns.Add("CommanderName", "Командир");
            dataGridViewPatrols.Columns.Add("CallReason", "Причина");
            dataGridViewPatrols.Columns.Add("DepartureDateTime", "Дата выезда");
            dataGridViewPatrols.Columns.Add("ContractId", "Контракт ID");
        }

        private void LoadContracts()
        {
            var contracts = _contractService.GetAllContracts();
            comboBoxContracts.DataSource = contracts;
            comboBoxContracts.DisplayMember = "Id";
            comboBoxContracts.ValueMember = "Id";
        }

        public Contract Contract
        {
            get
            {
                if (comboBoxContracts.SelectedValue != null)
                {
                    var contractDto = _contractService.GetContractById((int)comboBoxContracts.SelectedValue);
                    return ContractMapper.ToEntity(contractDto);
                }
                return null;
            }
        }

        public string CrewNumber
        {
            get => txtCrewNumber.Text;
            set => txtCrewNumber.Text = value;
        }

        public string CommanderName
        {
            get => txtCommanderName.Text;
            set => txtCommanderName.Text = value;
        }

        public string CallReason
        {
            get => txtCallReason.Text;
            set => txtCallReason.Text = value;
        }

        public DateTime DepartureDateTime
        {
            get => dtpDepartureDateTime.Value;
            set => dtpDepartureDateTime.Value = value;
        }

        public string StolenItemName => txtStolenItemName.Text;

        public decimal StolenItemValue => decimal.TryParse(txtStolenItemValue.Text, out var value) ? value : 0;

        public string DocumentNumber => txtDocumentNumber.Text;

        public string IssuingAuthority => txtIssuingAuthority.Text;

        public DateTime DateOfIssue => dtpDateOfIssue.Value;

        private void btnExecutePatrol_Click(object sender, EventArgs e)
        {
            try
            {
                var patrolDto = new SecurityPatrolDTO
                {
                    CrewNumber = CrewNumber,
                    CommanderName = CommanderName,
                    CallReason = CallReason,
                    DepartureDateTime = DepartureDateTime,
                    ContractId = Contract.Id
                };

                _securityPatrolPresenter.ExecutePatrol(patrolDto);
                ShowMessage("Патрулирование выполнено.");
                ClearFields();
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка: {ex.Message}");
            }
        }

        private void btnAddStolenItem_Click(object sender, EventArgs e)
        {
            try
            {
                var stolenItemDto = new StolenItemDTO
                {
                    ItemName = StolenItemName,
                    EstimatedValue = StolenItemValue
                };

                _securityPatrolPresenter.AddStolenItem(stolenItemDto);
                ShowMessage("Украденная вещь добавлена.");
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка: {ex.Message}");
            }
        }

        private void btnAddArrestDetails_Click(object sender, EventArgs e)
        {
            try
            {
                var arrestDetailsDto = new ArrestDetailsDTO
                {
                    DocumentNumber = DocumentNumber,
                    IssuingAuthority = IssuingAuthority,
                    DateOfIssue = DateOfIssue
                };

                _securityPatrolPresenter.AddArrestDetails(arrestDetailsDto);
                ShowMessage("Сведения о задержании добавлены.");
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка: {ex.Message}");
            }
        }

        public void LoadPatrols(List<SecurityPatrolDTO> patrols)
        {
            dataGridViewPatrols.Rows.Clear();
            foreach (var patrol in patrols)
            {
                dataGridViewPatrols.Rows.Add(
                    patrol.PatrolId,
                    patrol.CrewNumber,
                    patrol.CommanderName,
                    patrol.CallReason,
                    patrol.DepartureDateTime,
                    patrol.ContractId
                );
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ClearFields()
        {
            txtCrewNumber.Clear();
            txtCommanderName.Clear();
            txtCallReason.Clear();
            txtStolenItemName.Clear();
            txtStolenItemValue.Clear();
            txtDocumentNumber.Clear();
            txtIssuingAuthority.Clear();
            dtpDateOfIssue.Value = DateTime.Now;
            dtpDepartureDateTime.Value = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}