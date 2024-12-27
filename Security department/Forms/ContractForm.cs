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
        private readonly IContractPresenter _contractPresenter; // Презентер для контрактов
        private readonly IObjectService _objectService; // Сервис для работы с объектами

        public ContractForm(IContractPresenter contractPresenter, IObjectService objectService)
        {
            InitializeComponent();
            _contractPresenter = contractPresenter; // Инициализация презентера
            _objectService = objectService; // Инициализация сервиса объектов
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
            // Получаем объект по ObjectId
            var objectEntity = _objectService.GetObjectById(ObjectId); // Получаем объект из сервиса

            // Проверяем, что объект существует
            if (objectEntity == null)
            {
                ShowMessage("Объект не найден.");
                return;
            }

            // Создаем новый объект ContractDTO на основе данных из формы
            var contractDto = new ContractDTO
            {
                ClientId = ClientId,
                Object = objectEntity, // Используем Id объекта
                StartDate = StartDate,
                EndDate = EndDate,
                Penalty = Penalty,
                InterestRate = InterestRate,
                AdditionalConditions = AdditionalConditions,
                PaymentAmount = PaymentAmount
            };

            // Вызов метода презентера для добавления контракта
            _contractPresenter.AddContract(contractDto);

            // Очистка полей ввода после добавления
            ClearFields();
            ShowMessage("Контракт успешно добавлен.");
        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            var objectEntity = _objectService.GetObjectById(ObjectId); // Получаем объект из сервиса

            // Проверяем, что объект существует
            if (objectEntity == null)
            {
                ShowMessage("Объект не найден.");
                return;
            }
            // Создаем новый объект ContractDTO на основе данных из формы
            var contractDto = new ContractDTO
            {
                Id = Id, // Убедитесь, что Id установлен
                ClientId = ClientId,
                Object = objectEntity,
                StartDate = StartDate,
                EndDate = EndDate,
                Penalty = Penalty,
                InterestRate = InterestRate,
                AdditionalConditions = AdditionalConditions,
                PaymentAmount = PaymentAmount
            };

            // Вызов метода презентера для обновления контракта
            _contractPresenter.UpdateContract(contractDto);

            // Очистка полей ввода после обновления
            ClearFields();
            ShowMessage("Контракт успешно обновлен.");
        }

        private void btnRemoveContract_Click(object sender, EventArgs e)
        {
            // Получаем идентификатор контракта для удаления
            var contractId = Id;

            // Вызов метода презентера для удаления контракта
            _contractPresenter.RemoveContract(contractId);

            // Очистка полей ввода после удаления
            ClearFields();
            ShowMessage("Контракт успешно удален.");
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