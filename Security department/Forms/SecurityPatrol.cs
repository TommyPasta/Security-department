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
        private List<ContractDTO> _contracts;  // Храним список контрактов локально

        public SecurityPatrolForm()
        {
            InitializeComponent();
            SetupDataGridView();

            // Настройка комбобокса
            comboBoxContracts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxContracts.DisplayMember = "DisplayText";  // Что показываем
            comboBoxContracts.ValueMember = "Id";             // Что используем как значение

            // Подписываемся на события
            this.Load += SecurityPatrolForm_Load;
        }

        public void SetPresenter(ISecurityPatrolPresenter securityPatrolPresenter, IContractService contractService)
        {
            _securityPatrolPresenter = securityPatrolPresenter;
            _contractService = contractService;
            LoadContracts();  // Загружаем контракты после получения сервиса
            RefreshPatrolsList();
        }

        private void SetupDataGridView()
        {
            dataGridViewPatrols.Columns.Clear();

            dataGridViewPatrols.Columns.Add("PatrolId", "ID патруля");
            dataGridViewPatrols.Columns.Add("ContractId", "ID контракта");
            dataGridViewPatrols.Columns.Add("CrewNumber", "Номер экипажа");
            dataGridViewPatrols.Columns.Add("CommanderName", "Командир");
            dataGridViewPatrols.Columns.Add("CallReason", "Причина вызова");
            dataGridViewPatrols.Columns.Add("DepartureDateTime", "Дата и время выезда");
            dataGridViewPatrols.Columns.Add("StolenItemsCount", "Украдено вещей");
            dataGridViewPatrols.Columns.Add("HasArrest", "Задержание");

            dataGridViewPatrols.AllowUserToAddRows = false;
            dataGridViewPatrols.AllowUserToDeleteRows = false;
            dataGridViewPatrols.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatrols.MultiSelect = false;
            dataGridViewPatrols.ReadOnly = true;
            dataGridViewPatrols.RowHeadersVisible = false;
        }

        private void LoadContracts()
        {
            try
            {
                var contracts = _contractService.GetAllContracts();
                _contracts = contracts;

                comboBoxContracts.Items.Clear();

                if (contracts.Count == 0)
                {
                    comboBoxContracts.Text = "Нет доступных контрактов";
                    comboBoxContracts.Enabled = false;
                    return;
                }

                comboBoxContracts.Enabled = true;

                // Создаём список для отображения с понятным текстом
                var displayList = new List<dynamic>();
                foreach (var contract in contracts)
                {
                    displayList.Add(new
                    {
                        Id = contract.Id,
                        DisplayText = $"Договор №{contract.Id} - Клиент №{contract.ClientId} - {contract.Object?.Address ?? "Адрес не указан"}"
                    });
                }

                comboBoxContracts.DataSource = displayList;
                comboBoxContracts.DisplayMember = "DisplayText";
                comboBoxContracts.ValueMember = "Id";

                // Сбрасываем выбор
                if (comboBoxContracts.Items.Count > 0)
                    comboBoxContracts.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки контрактов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Свойство Contract — получаем выбранный контракт
        public Contract Contract
        {
            get
            {
                if (comboBoxContracts.SelectedValue != null && comboBoxContracts.SelectedValue is int contractId)
                {
                    var contractDto = _contracts.Find(c => c.Id == contractId);
                    if (contractDto != null)
                    {
                        return ContractMapper.ToEntity(contractDto);
                    }
                }
                return null;
            }
        }

        // Остальные свойства интерфейса
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

        public decimal StolenItemValue
        {
            get
            {
                decimal.TryParse(txtStolenItemValue.Text, out decimal value);
                return value;
            }
        }

        public string DocumentNumber => txtDocumentNumber.Text;

        public string IssuingAuthority => txtIssuingAuthority.Text;

        public DateTime DateOfIssue => dtpDateOfIssue.Value;

        // Кнопка "Выполнить патруль"
        private void btnExecutePatrol_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка выбора контракта
                if (comboBoxContracts.SelectedIndex < 0 || comboBoxContracts.SelectedValue == null)
                {
                    ShowError("Выберите контракт (договор) из списка.");
                    return;
                }

                // Проверка заполнения полей
                if (string.IsNullOrWhiteSpace(CrewNumber))
                {
                    ShowError("Введите номер экипажа.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(CommanderName))
                {
                    ShowError("Введите имя командира.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(CallReason))
                {
                    ShowError("Введите причину вызова.");
                    return;
                }

                var patrolDto = new SecurityPatrolDTO
                {
                    CrewNumber = CrewNumber,
                    CommanderName = CommanderName,
                    CallReason = CallReason,
                    DepartureDateTime = DepartureDateTime,
                    ContractId = (int)comboBoxContracts.SelectedValue
                };

                _securityPatrolPresenter.ExecutePatrol(patrolDto);
                ShowMessage("Патрулирование выполнено успешно.");
                ClearFields();
                RefreshPatrolsList();
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при выполнении патруля: {ex.Message}");
            }
        }

        // Кнопка "Добавить украденную вещь"
        private void btnAddStolenItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(StolenItemName))
                {
                    ShowError("Введите название украденной вещи.");
                    return;
                }

                if (StolenItemValue <= 0)
                {
                    ShowError("Введите оценочную стоимость вещи (больше 0).");
                    return;
                }

                var stolenItemDto = new StolenItemDTO
                {
                    ItemName = StolenItemName,
                    EstimatedValue = StolenItemValue
                };

                _securityPatrolPresenter.AddStolenItem(stolenItemDto);
                ShowMessage($"Украденная вещь \"{StolenItemName}\" добавлена.");

                // Очищаем поля ввода вещи
                txtStolenItemName.Clear();
                txtStolenItemValue.Clear();
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при добавлении вещи: {ex.Message}");
            }
        }

        // Кнопка "Добавить сведения о задержании"
        private void btnAddArrestDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(DocumentNumber))
                {
                    ShowError("Введите номер документа о задержании.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(IssuingAuthority))
                {
                    ShowError("Введите орган, выдавший документ.");
                    return;
                }

                var arrestDetailsDto = new ArrestDetailsDTO
                {
                    DocumentNumber = DocumentNumber,
                    IssuingAuthority = IssuingAuthority,
                    DateOfIssue = DateOfIssue
                };

                _securityPatrolPresenter.AddArrestDetails(arrestDetailsDto);
                ShowMessage("Сведения о задержании добавлены.");

                // Очищаем поля задержания
                txtDocumentNumber.Clear();
                txtIssuingAuthority.Clear();
                dtpDateOfIssue.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при добавлении сведений о задержании: {ex.Message}");
            }
        }

        // Загрузка списка патрулей в таблицу
        public void LoadPatrols(List<SecurityPatrolDTO> patrols)
        {
            dataGridViewPatrols.Rows.Clear();
            foreach (var patrol in patrols)
            {
                dataGridViewPatrols.Rows.Add(
                    patrol.PatrolId,
                    patrol.ContractId,
                    patrol.CrewNumber,
                    patrol.CommanderName,
                    patrol.CallReason,
                    patrol.DepartureDateTime.ToString("dd.MM.yyyy HH:mm"),
                    patrol.StolenItems?.Count ?? 0,
                    patrol.ArrestDetails != null ? "Да" : "Нет"
                );
            }
        }

        private void RefreshPatrolsList()
        {
            try
            {
                var patrols = _securityPatrolPresenter.GetAllPatrols();
                LoadPatrols(patrols);
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка загрузки списка патрулей: {ex.Message}");
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SecurityPatrolForm_Load(object sender, EventArgs e)
        {
            // Начальные значения дат
            dtpDepartureDateTime.Value = DateTime.Now;
            dtpDateOfIssue.Value = DateTime.Now;

            // Если презентер ещё не установлен, загружать данные не будем
            // Данные загрузятся после SetPresenter
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Пустой обработчик для совместимости
        }

    }
}