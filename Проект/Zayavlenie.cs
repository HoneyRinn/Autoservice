using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Проект
{
    public partial class Zayavlenie : Form
    {
        public ClientsClass ClientsInfo { get; set; }
        public Zayavlenie()
        {
            InitializeComponent();
            cmbStatus.KeyPress += OnKeyPress;
        }


        private void Zayavlenie_Load(object sender, EventArgs e)
        {
            if(ClientsInfo != null)
            {
                tbName.Text = ClientsInfo.iName;
                tbModel.Text = ClientsInfo.iModel;
                tbNum.Text = ClientsInfo.iNum;
                tbOrder.Text = ClientsInfo.iOrder;
                cmbStatus.Text = ClientsInfo.iStatus;
                tbMoney.Text = ClientsInfo.iMoney;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClientsInfo.iName = tbName.Text;
            ClientsInfo.iModel = tbModel.Text;
            ClientsInfo.iNum = tbNum.Text;
            ClientsInfo.iOrder = tbOrder.Text;
            ClientsInfo.iStatus = cmbStatus.Text;
            ClientsInfo.iMoney = tbMoney.Text;
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void tbMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf(".") == -1) && (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbModel.Text != "" && cmbStatus.Text != "" && tbNum.Text != "" && tbOrder.Text != "" && tbMoney.Text != "")
            {
                btnAdd.Enabled = true;
            }

        }

        private void tbModel_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbModel.Text != "" && cmbStatus.Text != "" && tbNum.Text != "" && tbOrder.Text != "" && tbMoney.Text != "")
            {
                btnAdd.Enabled = true;
            }
        }

        private void tbNum_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbModel.Text != "" && cmbStatus.Text != "" && tbNum.Text != "" && tbOrder.Text != "" && tbMoney.Text != "")
            {
                btnAdd.Enabled = true;
            }
        }

        private void tbOrder_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbModel.Text != "" && cmbStatus.Text != "" && tbNum.Text != "" && tbOrder.Text != "" && tbMoney.Text != "")
            {
                btnAdd.Enabled = true;
            }
        }

        private void tbMoney_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbModel.Text != "" && cmbStatus.Text != "" && tbNum.Text != "" && tbOrder.Text != "" && tbMoney.Text != "")
            {
                btnAdd.Enabled = true;
            }
        }

        private void cmbStatus_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbModel.Text != "" && cmbStatus.Text != "" && tbNum.Text != "" && tbOrder.Text != "" && tbMoney.Text != "")
            {
                btnAdd.Enabled = true;
            }
        }
    }
    
}
