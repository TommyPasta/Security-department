using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Security_department.DTOs;
using Security_department.Presenters.Interface;
using Security_department.Views;

namespace Security_department.Forms
{
    public partial class SecurityPatrolForm : Form, ISecurityPatrolView
    {
        private readonly ISecurityPatrolPresenter _securityPatrolPresenter;

        public SecurityPatrolForm(ISecurityPatrolPresenter securityPatrolPresenter)
        {
            InitializeComponent();
            _securityPatrolPresenter = securityPatrolPresenter;
            LoadPatrols(); // Загрузка патрульных выездов при инициализации формы
        }

        // Свойства для получения данных из формы
        public string CrewNumber => txtCrewNumber.Text; // Номер экипажа
        public string CommanderName => txtCommanderName.Text; // Имя командира
        public string CallReason => txtCallReason.Text; // Причина вызова
        public DateTime DepartureDateTime => dtpDepartureDateTime.Value; // Дата и время выезда

        private void btnExecutePatrol_Click(object sender, EventArgs e)
        {
            // Логика для выполнения патрулирования
            var patrolDto = new SecurityPatrolDTO
            {
                CrewNumber = CrewNumber,
                CommanderName = CommanderName,
                CallReason = CallReason,
                DepartureDateTime = DepartureDateTime
            };

            _securityPatrolPresenter.ExecutePatrol(patrolDto);
            ShowMessage("Патрулирование выполнено.");
            LoadPatrols(); // Обновление списка патрульных выездов
        }

        private void btnAddStolenItem_Click(object sender, EventArgs e)
        {
            // Логика для добавления украденной вещи
            var stolenItemDto = new StolenItemDTO
            {
                ItemName = txtStolenItemName.Text,
                EstimatedValue = decimal.TryParse(txtStolenItemValue.Text, out var value) ? value : 0
            };

            _securityPatrolPresenter.AddStolenItem(stolenItemDto);
            ShowMessage("Украденная вещь добавлена.");
        }

        private void btnAddArrestDetails_Click(object sender, EventArgs e)
        {
            // Логика для добавления сведений о задержании
            var arrestDetailsDto = new ArrestDetailsDTO
            {
                DocumentNumber = txtDocumentNumber.Text,
                IssuingAuthority = txtIssuingAuthority.Text,
                DateOfIssue = dtpDateOfIssue.Value
            };

            _securityPatrolPresenter.AddArrestDetails(arrestDetailsDto);
            ShowMessage("Сведения о задержании добавлены.");
        }

        public void LoadPatrols(List<SecurityPatrolDTO> patrols)
        {
            // Метод для загрузки патрульных выездов в таблицу
            dataGridViewPatrols.Rows.Clear();
            foreach (var patrol in patrols)
            {
                dataGridViewPatrols.Rows.Add(patrol.CrewNumber, patrol.CommanderName, patrol.CallReason, patrol.DepartureDateTime);
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void ClearFields()
        {
            // Метод для очистки полей ввода
            txtCrewNumber.Clear();
            txtCommanderName.Clear();
            txtCallReason.Clear();
            txtStolenItemName.Clear();
            txtStolenItemValue.Clear();
            txtDocumentNumber.Clear();
            txtIssuingAuthority.Clear();
            dtpDateOfIssue.Value = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}