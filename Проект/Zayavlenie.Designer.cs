namespace Проект
{
    partial class Zayavlenie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zayavlenie));
            this.Zagolovok = new System.Windows.Forms.Label();
            this.nameClient = new System.Windows.Forms.Label();
            this.autoMark = new System.Windows.Forms.Label();
            this.autoNum = new System.Windows.Forms.Label();
            this.orderInfo = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Zagolovok
            // 
            this.Zagolovok.AutoSize = true;
            this.Zagolovok.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zagolovok.Location = new System.Drawing.Point(30, 9);
            this.Zagolovok.Name = "Zagolovok";
            this.Zagolovok.Size = new System.Drawing.Size(354, 21);
            this.Zagolovok.TabIndex = 1;
            this.Zagolovok.Text = "Заявка на прием автомобиля в автосервис:";
            // 
            // nameClient
            // 
            this.nameClient.AutoSize = true;
            this.nameClient.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameClient.Location = new System.Drawing.Point(12, 56);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(92, 17);
            this.nameClient.TabIndex = 2;
            this.nameClient.Text = "Имя клиента:";
            // 
            // autoMark
            // 
            this.autoMark.AutoSize = true;
            this.autoMark.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoMark.Location = new System.Drawing.Point(12, 82);
            this.autoMark.Name = "autoMark";
            this.autoMark.Size = new System.Drawing.Size(92, 17);
            this.autoMark.TabIndex = 3;
            this.autoMark.Text = "Модель авто:";
            // 
            // autoNum
            // 
            this.autoNum.AutoSize = true;
            this.autoNum.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoNum.Location = new System.Drawing.Point(12, 107);
            this.autoNum.Name = "autoNum";
            this.autoNum.Size = new System.Drawing.Size(51, 17);
            this.autoNum.TabIndex = 4;
            this.autoNum.Text = "Гос.№:";
            // 
            // orderInfo
            // 
            this.orderInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderInfo.Location = new System.Drawing.Point(12, 131);
            this.orderInfo.Name = "orderInfo";
            this.orderInfo.Size = new System.Drawing.Size(126, 41);
            this.orderInfo.TabIndex = 5;
            this.orderInfo.Text = "Краткое описание заказа:";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money.Location = new System.Drawing.Point(6, 249);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(57, 17);
            this.money.TabIndex = 6;
            this.money.Text = "Оплата:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(168, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(226, 20);
            this.tbName.TabIndex = 7;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(168, 79);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(226, 20);
            this.tbModel.TabIndex = 8;
            this.tbModel.TextChanged += new System.EventHandler(this.tbModel_TextChanged);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(168, 105);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(226, 20);
            this.tbNum.TabIndex = 9;
            this.tbNum.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            // 
            // tbOrder
            // 
            this.tbOrder.Location = new System.Drawing.Point(168, 131);
            this.tbOrder.Multiline = true;
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.Size = new System.Drawing.Size(226, 66);
            this.tbOrder.TabIndex = 10;
            this.tbOrder.TextChanged += new System.EventHandler(this.tbOrder_TextChanged);
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(65, 248);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(89, 20);
            this.tbMoney.TabIndex = 11;
            this.tbMoney.TextChanged += new System.EventHandler(this.tbMoney_TextChanged);
            this.tbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMoney_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(287, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 38);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(165, 226);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 17);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Статус заказа:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Выполняется",
            "В ожиданиии оплаты",
            "Выполнен"});
            this.cmbStatus.Location = new System.Drawing.Point(168, 246);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(115, 21);
            this.cmbStatus.TabIndex = 14;
            this.cmbStatus.Text = "Выполняется";
            this.cmbStatus.TextChanged += new System.EventHandler(this.cmbStatus_TextChanged);
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // Zayavlenie
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(406, 279);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.tbOrder);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.money);
            this.Controls.Add(this.orderInfo);
            this.Controls.Add(this.autoNum);
            this.Controls.Add(this.autoMark);
            this.Controls.Add(this.nameClient);
            this.Controls.Add(this.Zagolovok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zayavlenie";
            this.Text = "Добавить заявку";
            this.Load += new System.EventHandler(this.Zayavlenie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Zagolovok;
        private System.Windows.Forms.Label nameClient;
        private System.Windows.Forms.Label autoMark;
        private System.Windows.Forms.Label autoNum;
        private System.Windows.Forms.Label orderInfo;
        private System.Windows.Forms.Label money;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbModel;
        public System.Windows.Forms.TextBox tbNum;
        public System.Windows.Forms.TextBox tbOrder;
        public System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}