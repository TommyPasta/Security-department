using Security_department.DTOs;
using Security_department.Presenters.Interface;
using Security_department.Services.Interface;
using Security_department.Views;
using System;
using System.Collections.Generic;
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
            SetupDataGridView();  // Настройка столбцов ДО загрузки данных

            // Подписываемся на событие клика по таблице
            dataGridViewContracts.CellClick += dataGridViewContracts_CellClick;
        }

        public void SetPresenter(IContractPresenter contractPresenter, IObjectService objectService, IClientService clientService)
        {
            _contractPresenter = contractPresenter;
            _objectService = objectService;
            _clientService = clientService;

            // Загружаем данные только после получения презентера
            LoadComboBoxes();
            RefreshContractsList();
        }

        private void SetupDataGridView()
        {
            // Очищаем существующие колонки (на всякий случай)
            dataGridViewContracts.Columns.Clear();

            // Создаём колонки
            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.HeaderText = "ID";
            idColumn.Width = 40;
            idColumn.DataPropertyName = "Id";
            dataGridViewContracts.Columns.Add(idColumn);

            DataGridViewColumn clientIdColumn = new DataGridViewTextBoxColumn();
            clientIdColumn.Name = "ClientId";
            clientIdColumn.HeaderText = "Клиент ID";
            clientIdColumn.Width = 70;
            dataGridViewContracts.Columns.Add(clientIdColumn);

            DataGridViewColumn objectIdColumn = new DataGridViewTextBoxColumn();
            objectIdColumn.Name = "ObjectId";
            objectIdColumn.HeaderText = "Объект ID";
            objectIdColumn.Width = 70;
            dataGridViewContracts.Columns.Add(objectIdColumn);

            DataGridViewColumn addressColumn = new DataGridViewTextBoxColumn();
            addressColumn.Name = "ObjectAddress";
            addressColumn.HeaderText = "Адрес объекта";
            addressColumn.Width = 180;
            dataGridViewContracts.Columns.Add(addressColumn);

            DataGridViewColumn startDateColumn = new DataGridViewTextBoxColumn();
            startDateColumn.Name = "StartDate";
            startDateColumn.HeaderText = "Дата начала";
            startDateColumn.Width = 100;
            dataGridViewContracts.Columns.Add(startDateColumn);

            DataGridViewColumn endDateColumn = new DataGridViewTextBoxColumn();
            endDateColumn.Name = "EndDate";
            endDateColumn.HeaderText = "Дата окончания";
            endDateColumn.Width = 100;
            dataGridViewContracts.Columns.Add(endDateColumn);

            DataGridViewColumn penaltyColumn = new DataGridViewTextBoxColumn();
            penaltyColumn.Name = "Penalty";
            penaltyColumn.HeaderText = "Штраф";
            penaltyColumn.Width = 80;
            dataGridViewContracts.Columns.Add(penaltyColumn);

            DataGridViewColumn interestRateColumn = new DataGridViewTextBoxColumn();
            interestRateColumn.Name = "InterestRate";
            interestRateColumn.HeaderText = "Ставка %";
            interestRateColumn.Width = 80;
            dataGridViewContracts.Columns.Add(interestRateColumn);

            DataGridViewColumn conditionsColumn = new DataGridViewTextBoxColumn();
            conditionsColumn.Name = "AdditionalConditions";
            conditionsColumn.HeaderText = "Доп. условия";
            conditionsColumn.Width = 150;
            dataGridViewContracts.Columns.Add(conditionsColumn);

            DataGridViewColumn paymentColumn = new DataGridViewTextBoxColumn();
            paymentColumn.Name = "PaymentAmount";
            paymentColumn.HeaderText = "Сумма оплаты";
            paymentColumn.Width = 100;
            dataGridViewContracts.Columns.Add(paymentColumn);

            // Настройка внешнего вида таблицы
            dataGridViewContracts.AllowUserToAddRows = false;
            dataGridViewContracts.AllowUserToDeleteRows = false;
            dataGridViewContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewContracts.MultiSelect = false;
            dataGridViewContracts.ReadOnly = true;
            dataGridViewContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewContracts.RowHeadersVisible = false;
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Загрузка клиентов в comboBox
                var clients = _clientService.GetAllClients();
                comboBoxClients.DataSource = null;
                comboBoxClients.Items.Clear();

                if (clients.Count > 0)
                {
                    comboBoxClients.DataSource = clients;
                    comboBoxClients.DisplayMember = "FirstName";
                    comboBoxClients.ValueMember = "Id";
                }
                else
                {
                    comboBoxClients.Text = "Нет клиентов";
                }

                // Загрузка объектов в comboBox
                var objects = _objectService.GetAllObjects();
                comboBoxObjects.DataSource = null;
                comboBoxObjects.Items.Clear();

                if (objects.Count > 0)
                {
                    comboBoxObjects.DataSource = objects;
                    comboBoxObjects.DisplayMember = "Address";
                    comboBoxObjects.ValueMember = "Id";
                }
                else
                {
                    comboBoxObjects.Text = "Нет объектов";
                }
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        // Свойства интерфейса IContractView
        public int Id
        {
            get => int.TryParse(txtId.Text, out var id) ? id : 0;
            set => txtId.Text = value.ToString();
        }

        public int ClientId
        {
            get
            {
                if (comboBoxClients.SelectedValue != null && comboBoxClients.SelectedValue is int)
                    return (int)comboBoxClients.SelectedValue;
                return 0;
            }
        }

        public int ObjectId
        {
            get
            {
                if (comboBoxObjects.SelectedValue != null && comboBoxObjects.SelectedValue is int)
                    return (int)comboBoxObjects.SelectedValue;
                return 0;
            }
        }

        public DateTime StartDate
        {
            get => dtpStartDate.Value;
            set => dtpStartDate.Value = value;
        }

        public DateTime EndDate
        {
            get => dtpEndDate.Value;
            set => dtpEndDate.Value = value;
        }

        public int Penalty
        {
            get
            {
                int.TryParse(txtPenalty.Text, out int penalty);
                return penalty;
            }
            set => txtPenalty.Text = value.ToString();
        }

        public float InterestRate
        {
            get
            {
                float.TryParse(txtInterestRate.Text, out float rate);
                return rate;
            }
            set => txtInterestRate.Text = value.ToString("F2");
        }

        public string AdditionalConditions
        {
            get => txtAdditionalConditions.Text;
            set => txtAdditionalConditions.Text = value;
        }

        public float PaymentAmount
        {
            get
            {
                float.TryParse(txtPaymentAmount.Text, out float amount);
                return amount;
            }
            set => txtPaymentAmount.Text = value.ToString("F2");
        }

        // Методы интерфейса
        public void LoadContracts(List<ContractDTO> contracts)
        {
            dataGridViewContracts.Rows.Clear();

            foreach (var contract in contracts)
            {
                dataGridViewContracts.Rows.Add(
                    contract.Id,
                    contract.ClientId,
                    contract.Object?.Id,
                    contract.Object?.Address ?? "Н/Д",
                    contract.StartDate.ToShortDateString(),
                    contract.EndDate.ToShortDateString(),
                    contract.Penalty,
                    contract.InterestRate,
                    contract.AdditionalConditions ?? "",
                    contract.PaymentAmount
                );
            }
        }

        public void ClearFields()
        {
            txtId.Clear();

            if (comboBoxClients.Items.Count > 0)
                comboBoxClients.SelectedIndex = -1;

            if (comboBoxObjects.Items.Count > 0)
                comboBoxObjects.SelectedIndex = -1;

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddYears(1);
            txtPenalty.Text = "0";
            txtInterestRate.Text = "0";
            txtAdditionalConditions.Clear();
            txtPaymentAmount.Text = "0";
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Обновление списка договоров
        private void RefreshContractsList()
        {
            try
            {
                _contractPresenter.LoadContracts();
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка загрузки списка договоров: {ex.Message}");
            }
        }

        // Обработчик клика по таблице
        private void dataGridViewContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var row = dataGridViewContracts.Rows[e.RowIndex];

                    // Заполняем поля формы данными из выбранной строки
                    if (row.Cells["Id"].Value != null)
                        Id = Convert.ToInt32(row.Cells["Id"].Value);

                    // Выбираем клиента в comboBox
                    if (row.Cells["ClientId"].Value != null)
                    {
                        int clientId = Convert.ToInt32(row.Cells["ClientId"].Value);
                        comboBoxClients.SelectedValue = clientId;
                    }

                    // Выбираем объект в comboBox
                    if (row.Cells["ObjectId"].Value != null)
                    {
                        int objectId = Convert.ToInt32(row.Cells["ObjectId"].Value);
                        comboBoxObjects.SelectedValue = objectId;
                    }

                    // Даты
                    if (DateTime.TryParse(row.Cells["StartDate"].Value?.ToString(), out DateTime startDate))
                        StartDate = startDate;

                    if (DateTime.TryParse(row.Cells["EndDate"].Value?.ToString(), out DateTime endDate))
                        EndDate = endDate;

                    // Числовые поля
                    if (row.Cells["Penalty"].Value != null)
                        Penalty = Convert.ToInt32(row.Cells["Penalty"].Value);

                    if (row.Cells["InterestRate"].Value != null)
                        InterestRate = Convert.ToSingle(row.Cells["InterestRate"].Value);

                    if (row.Cells["PaymentAmount"].Value != null)
                        PaymentAmount = Convert.ToSingle(row.Cells["PaymentAmount"].Value);

                    // Текстовое поле
                    AdditionalConditions = row.Cells["AdditionalConditions"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    ShowError($"Ошибка при выборе записи: {ex.Message}");
                }
            }
        }

        // Кнопка "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка выбора клиента
                if (comboBoxClients.SelectedIndex < 0 || comboBoxClients.SelectedValue == null)
                {
                    ShowError("Выберите клиента из списка.");
                    return;
                }

                // Проверка выбора объекта
                if (comboBoxObjects.SelectedIndex < 0 || comboBoxObjects.SelectedValue == null)
                {
                    ShowError("Выберите объект из списка.");
                    return;
                }

                // Проверка дат
                if (EndDate <= StartDate)
                {
                    ShowError("Дата окончания должна быть позже даты начала.");
                    return;
                }

                // Получаем объект по ObjectId
                var objectDto = _objectService.GetObjectById(ObjectId);
                if (objectDto == null)
                {
                    ShowError("Выбранный объект не найден в базе данных.");
                    return;
                }

                // Создаём DTO для нового договора
                var contractDto = new ContractDTO
                {
                    ClientId = ClientId,
                    Object = objectDto,
                    StartDate = StartDate,
                    EndDate = EndDate,
                    Penalty = Penalty,
                    InterestRate = InterestRate,
                    AdditionalConditions = AdditionalConditions,
                    PaymentAmount = PaymentAmount
                };

                // Добавляем через презентер
                _contractPresenter.AddContract(contractDto);
                ClearFields();
                RefreshContractsList();
                ShowMessage("Договор успешно добавлен.");
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при добавлении договора: {ex.Message}");
            }
        }

        // Кнопка "Обновить"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                {
                    ShowError("Выберите договор для обновления из таблицы (кликните по строке).");
                    return;
                }

                if (comboBoxClients.SelectedIndex < 0 || comboBoxClients.SelectedValue == null)
                {
                    ShowError("Выберите клиента из списка.");
                    return;
                }

                if (comboBoxObjects.SelectedIndex < 0 || comboBoxObjects.SelectedValue == null)
                {
                    ShowError("Выберите объект из списка.");
                    return;
                }

                if (EndDate <= StartDate)
                {
                    ShowError("Дата окончания должна быть позже даты начала.");
                    return;
                }

                // Получаем объект по ObjectId
                var objectDto = _objectService.GetObjectById(ObjectId);
                if (objectDto == null)
                {
                    ShowError("Выбранный объект не найден в базе данных.");
                    return;
                }

                // Создаём DTO для обновления
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

                // Обновляем через презентер
                _contractPresenter.UpdateContract(contractDto);
                ClearFields();
                RefreshContractsList();
                ShowMessage("Договор успешно обновлён.");
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при обновлении договора: {ex.Message}");
            }
        }

        // Кнопка "Удалить"
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                {
                    ShowError("Выберите договор для удаления из таблицы (кликните по строке).");
                    return;
                }

                // Подтверждение удаления
                var result = MessageBox.Show(
                    $"Вы уверены, что хотите удалить договор №{Id}?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    _contractPresenter.RemoveContract(Id);
                    ClearFields();
                    RefreshContractsList();
                    ShowMessage("Договор успешно удалён.");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при удалении договора: {ex.Message}");
            }
        }

        // Кнопка "Очистить"
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Кнопка "Обновить список"
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadComboBoxes();
            RefreshContractsList();
            ShowMessage("Список договоров обновлён.");
        }

        // Загрузка формы
        private void ContractForm_Load(object sender, EventArgs e)
        {
            // Настройка начальных значений (если презентер ещё не установлен)
            if (_contractPresenter == null)
            {
                dtpStartDate.Value = DateTime.Now;
                dtpEndDate.Value = DateTime.Now.AddYears(1);
                txtPenalty.Text = "0";
                txtInterestRate.Text = "0";
                txtPaymentAmount.Text = "0";
            }
        }
    }
}