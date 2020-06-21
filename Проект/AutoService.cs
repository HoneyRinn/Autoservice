using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class AutoService : Form
    {
        public AutoService()
        {
            InitializeComponent();
        }

        int ColumnTable;
        int RowTable;



        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(               
                "Приветствуем вас в программе для оформления заявок в автосерис\nОформил программу ученик ИСиП-18-21\nФедоров Илья",
                "Уведомление!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var Exit = MessageBox.Show(
                "Вы действительно хотите выйти?",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);

            if(Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Zayavlenie Zayv = new Zayavlenie();
            Zayv.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Exit = MessageBox.Show(  
                "Вы действительно хотите выйти?",    
                "Выход",   
                MessageBoxButtons.YesNo,   
                MessageBoxIcon.Question,   
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);

            if (Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
