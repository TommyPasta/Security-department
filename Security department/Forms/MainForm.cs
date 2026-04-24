using Security_department.Forms;
using System;
using System.Windows.Forms;

namespace Security_department
{
    public partial class MainForm : Form
    {
        private readonly ClientForm _clientForm;
        private readonly ObjectForm _objectForm;
        private readonly ContractForm _contractForm;
        private readonly SecurityPatrolForm _securityPatrolForm;

        public MainForm(ClientForm clientForm, ObjectForm objectForm, ContractForm contractForm, SecurityPatrolForm securityPatrolForm)
        {
            InitializeComponent();
            _clientForm = clientForm;
            _objectForm = objectForm;
            _contractForm = contractForm;
            _securityPatrolForm = securityPatrolForm;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            _clientForm.ShowDialog();
        }

        private void btnObjects_Click(object sender, EventArgs e)
        {
            _objectForm.ShowDialog();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            _contractForm.ShowDialog();
        }

        private void btnSecurityPatrols_Click(object sender, EventArgs e)
        {
            _securityPatrolForm.ShowDialog();
        }
    }
}