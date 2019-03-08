namespace Ticket_Machine
{
    partial class ticketMachine
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainDisplay = new System.Windows.Forms.Label();
            this.priceBtn = new System.Windows.Forms.Button();
            this.windowGroup = new System.Windows.Forms.Panel();
            this.paid = new System.Windows.Forms.Label();
            this.paidText = new System.Windows.Forms.Label();
            this.oturiText = new System.Windows.Forms.Label();
            this.payoutText = new System.Windows.Forms.Label();
            this.AmountOfMoneyText = new System.Windows.Forms.Label();
            this.amountOfMoney = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.numberOfSheet1000 = new System.Windows.Forms.Label();
            this.money1000Btn = new System.Windows.Forms.Button();
            this.money1000Group = new System.Windows.Forms.Panel();
            this.money10000Group = new System.Windows.Forms.Panel();
            this.money10000Btn = new System.Windows.Forms.Button();
            this.numberOfSheet10000 = new System.Windows.Forms.Label();
            this.money5000Group = new System.Windows.Forms.Panel();
            this.money5000Btn = new System.Windows.Forms.Button();
            this.numberOfSheet5000 = new System.Windows.Forms.Label();
            this.money500Group = new System.Windows.Forms.Panel();
            this.money500Btn = new System.Windows.Forms.Button();
            this.numberOfSheet500 = new System.Windows.Forms.Label();
            this.money100Group = new System.Windows.Forms.Panel();
            this.money100Btn = new System.Windows.Forms.Button();
            this.numberOfSheet100 = new System.Windows.Forms.Label();
            this.money50Group = new System.Windows.Forms.Panel();
            this.money50Btn = new System.Windows.Forms.Button();
            this.numberOfSheet50 = new System.Windows.Forms.Label();
            this.money10Group = new System.Windows.Forms.Panel();
            this.money10Btn = new System.Windows.Forms.Button();
            this.numberOfSheet10 = new System.Windows.Forms.Label();
            this.moneyIcGroup = new System.Windows.Forms.Panel();
            this.moneyIcBtn = new System.Windows.Forms.Button();
            this.numberOfSheetIc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ticketGroup = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numberOfSheetTicket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.icBalance = new System.Windows.Forms.Label();
            this.windowGroup.SuspendLayout();
            this.money1000Group.SuspendLayout();
            this.money10000Group.SuspendLayout();
            this.money5000Group.SuspendLayout();
            this.money500Group.SuspendLayout();
            this.money100Group.SuspendLayout();
            this.money50Group.SuspendLayout();
            this.money10Group.SuspendLayout();
            this.moneyIcGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ticketGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDisplay
            // 
            this.mainDisplay.BackColor = System.Drawing.SystemColors.ControlText;
            this.mainDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainDisplay.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mainDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainDisplay.Location = new System.Drawing.Point(60, 35);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(800, 64);
            this.mainDisplay.TabIndex = 1;
            this.mainDisplay.Text = "お金またはICカードを入れてください";
            this.mainDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceBtn
            // 
            this.priceBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.priceBtn.ForeColor = System.Drawing.Color.Black;
            this.priceBtn.Location = new System.Drawing.Point(80, 150);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(221, 94);
            this.priceBtn.TabIndex = 2;
            this.priceBtn.Text = "現金：130円\r\nICカード：124円";
            this.priceBtn.UseVisualStyleBackColor = false;
            this.priceBtn.Click += new System.EventHandler(this.priceBtn_Click);
            // 
            // windowGroup
            // 
            this.windowGroup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.windowGroup.Controls.Add(this.paid);
            this.windowGroup.Controls.Add(this.paidText);
            this.windowGroup.Controls.Add(this.oturiText);
            this.windowGroup.Controls.Add(this.payoutText);
            this.windowGroup.Controls.Add(this.AmountOfMoneyText);
            this.windowGroup.Controls.Add(this.amountOfMoney);
            this.windowGroup.Controls.Add(this.cancelBtn);
            this.windowGroup.Controls.Add(this.priceBtn);
            this.windowGroup.Controls.Add(this.mainDisplay);
            this.windowGroup.Location = new System.Drawing.Point(36, 12);
            this.windowGroup.Name = "windowGroup";
            this.windowGroup.Size = new System.Drawing.Size(900, 400);
            this.windowGroup.TabIndex = 3;
            // 
            // paid
            // 
            this.paid.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.paid.Location = new System.Drawing.Point(537, 134);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(115, 23);
            this.paid.TabIndex = 9;
            this.paid.Text = "投入金種";
            // 
            // paidText
            // 
            this.paidText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paidText.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.paidText.ForeColor = System.Drawing.Color.Red;
            this.paidText.Location = new System.Drawing.Point(516, 167);
            this.paidText.Name = "paidText";
            this.paidText.Size = new System.Drawing.Size(151, 152);
            this.paidText.TabIndex = 8;
            // 
            // oturiText
            // 
            this.oturiText.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.oturiText.Location = new System.Drawing.Point(745, 134);
            this.oturiText.Name = "oturiText";
            this.oturiText.Size = new System.Drawing.Size(115, 23);
            this.oturiText.TabIndex = 7;
            this.oturiText.Text = "お釣り";
            // 
            // payoutText
            // 
            this.payoutText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payoutText.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.payoutText.ForeColor = System.Drawing.Color.Red;
            this.payoutText.Location = new System.Drawing.Point(709, 167);
            this.payoutText.Name = "payoutText";
            this.payoutText.Size = new System.Drawing.Size(151, 152);
            this.payoutText.TabIndex = 6;
            // 
            // AmountOfMoneyText
            // 
            this.AmountOfMoneyText.AutoSize = true;
            this.AmountOfMoneyText.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AmountOfMoneyText.Location = new System.Drawing.Point(510, 350);
            this.AmountOfMoneyText.Name = "AmountOfMoneyText";
            this.AmountOfMoneyText.Size = new System.Drawing.Size(93, 20);
            this.AmountOfMoneyText.TabIndex = 5;
            this.AmountOfMoneyText.Text = "投入金額";
            // 
            // amountOfMoney
            // 
            this.amountOfMoney.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.amountOfMoney.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountOfMoney.ForeColor = System.Drawing.Color.Red;
            this.amountOfMoney.Location = new System.Drawing.Point(618, 336);
            this.amountOfMoney.Name = "amountOfMoney";
            this.amountOfMoney.Size = new System.Drawing.Size(242, 44);
            this.amountOfMoney.TabIndex = 4;
            this.amountOfMoney.Text = "0";
            this.amountOfMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cancelBtn.Location = new System.Drawing.Point(80, 324);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(120, 46);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "取り消し";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancel_Click);
            // 
            // numberOfSheet1000
            // 
            this.numberOfSheet1000.AutoSize = true;
            this.numberOfSheet1000.Location = new System.Drawing.Point(72, 81);
            this.numberOfSheet1000.Name = "numberOfSheet1000";
            this.numberOfSheet1000.Size = new System.Drawing.Size(37, 15);
            this.numberOfSheet1000.TabIndex = 6;
            this.numberOfSheet1000.Text = "残数";
            // 
            // money1000Btn
            // 
            this.money1000Btn.AutoSize = true;
            this.money1000Btn.Image = global::ticket_machine.Properties.Resources.money_1000;
            this.money1000Btn.Location = new System.Drawing.Point(3, 3);
            this.money1000Btn.Name = "money1000Btn";
            this.money1000Btn.Size = new System.Drawing.Size(116, 58);
            this.money1000Btn.TabIndex = 4;
            this.money1000Btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.money1000Btn.UseVisualStyleBackColor = true;
            this.money1000Btn.Click += new System.EventHandler(this.money_1000Btn_Click);
            // 
            // money1000Group
            // 
            this.money1000Group.Controls.Add(this.money1000Btn);
            this.money1000Group.Controls.Add(this.numberOfSheet1000);
            this.money1000Group.Location = new System.Drawing.Point(439, 34);
            this.money1000Group.Name = "money1000Group";
            this.money1000Group.Size = new System.Drawing.Size(158, 111);
            this.money1000Group.TabIndex = 7;
            // 
            // money10000Group
            // 
            this.money10000Group.Controls.Add(this.money10000Btn);
            this.money10000Group.Controls.Add(this.numberOfSheet10000);
            this.money10000Group.Location = new System.Drawing.Point(37, 34);
            this.money10000Group.Name = "money10000Group";
            this.money10000Group.Size = new System.Drawing.Size(158, 111);
            this.money10000Group.TabIndex = 8;
            // 
            // money10000Btn
            // 
            this.money10000Btn.AutoSize = true;
            this.money10000Btn.Image = global::ticket_machine.Properties.Resources.money_10000;
            this.money10000Btn.Location = new System.Drawing.Point(3, 3);
            this.money10000Btn.Name = "money10000Btn";
            this.money10000Btn.Size = new System.Drawing.Size(116, 58);
            this.money10000Btn.TabIndex = 4;
            this.money10000Btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.money10000Btn.UseVisualStyleBackColor = true;
            this.money10000Btn.Click += new System.EventHandler(this.money10000Btn_Click);
            // 
            // numberOfSheet10000
            // 
            this.numberOfSheet10000.AutoSize = true;
            this.numberOfSheet10000.Location = new System.Drawing.Point(72, 81);
            this.numberOfSheet10000.Name = "numberOfSheet10000";
            this.numberOfSheet10000.Size = new System.Drawing.Size(37, 15);
            this.numberOfSheet10000.TabIndex = 6;
            this.numberOfSheet10000.Text = "残数";
            // 
            // money5000Group
            // 
            this.money5000Group.Controls.Add(this.money5000Btn);
            this.money5000Group.Controls.Add(this.numberOfSheet5000);
            this.money5000Group.Location = new System.Drawing.Point(244, 34);
            this.money5000Group.Name = "money5000Group";
            this.money5000Group.Size = new System.Drawing.Size(158, 111);
            this.money5000Group.TabIndex = 8;
            // 
            // money5000Btn
            // 
            this.money5000Btn.AutoSize = true;
            this.money5000Btn.Image = global::ticket_machine.Properties.Resources.money_5000;
            this.money5000Btn.Location = new System.Drawing.Point(3, 3);
            this.money5000Btn.Name = "money5000Btn";
            this.money5000Btn.Size = new System.Drawing.Size(116, 59);
            this.money5000Btn.TabIndex = 4;
            this.money5000Btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.money5000Btn.UseVisualStyleBackColor = true;
            this.money5000Btn.Click += new System.EventHandler(this.money5000Btn_Click);
            // 
            // numberOfSheet5000
            // 
            this.numberOfSheet5000.AutoSize = true;
            this.numberOfSheet5000.Location = new System.Drawing.Point(72, 81);
            this.numberOfSheet5000.Name = "numberOfSheet5000";
            this.numberOfSheet5000.Size = new System.Drawing.Size(37, 15);
            this.numberOfSheet5000.TabIndex = 6;
            this.numberOfSheet5000.Text = "残数";
            // 
            // money500Group
            // 
            this.money500Group.Controls.Add(this.money500Btn);
            this.money500Group.Controls.Add(this.numberOfSheet500);
            this.money500Group.Location = new System.Drawing.Point(639, 34);
            this.money500Group.Name = "money500Group";
            this.money500Group.Size = new System.Drawing.Size(86, 111);
            this.money500Group.TabIndex = 8;
            // 
            // money500Btn
            // 
            this.money500Btn.AutoSize = true;
            this.money500Btn.Image = global::ticket_machine.Properties.Resources.money_500;
            this.money500Btn.Location = new System.Drawing.Point(3, 3);
            this.money500Btn.Name = "money500Btn";
            this.money500Btn.Size = new System.Drawing.Size(58, 58);
            this.money500Btn.TabIndex = 4;
            this.money500Btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.money500Btn.UseVisualStyleBackColor = true;
            this.money500Btn.Click += new System.EventHandler(this.money500Btn_Click);
            // 
            // numberOfSheet500
            // 
            this.numberOfSheet500.AutoSize = true;
            this.numberOfSheet500.Location = new System.Drawing.Point(34, 81);
            this.numberOfSheet500.Name = "numberOfSheet500";
            this.numberOfSheet500.Size = new System.Drawing.Size(37, 15);
            this.numberOfSheet500.TabIndex = 6;
            this.numberOfSheet500.Text = "残数";
            // 
            // money100Group
            // 
            this.money100Group.Controls.Add(this.money100Btn);
            this.money100Group.Controls.Add(this.numberOfSheet100);
            this.money100Group.Location = new System.Drawing.Point(40, 175);
            this.money100Group.Name = "money100Group";
            this.money100Group.Size = new System.Drawing.Size(86, 111);
            this.money100Group.TabIndex = 9;
            // 
            // money100Btn
            // 
            this.money100Btn.AutoSize = true;
            this.money100Btn.Image = global::ticket_machine.Properties.Resources.money_100;
            this.money100Btn.Location = new System.Drawing.Point(3, 3);
            this.money100Btn.Name = "money100Btn";
            this.money100Btn.Size = new System.Drawing.Size(58, 58);
            this.money100Btn.TabIndex = 4;
            this.money100Btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.money100Btn.UseVisualStyleBackColor = true;
            this.money100Btn.Click += new System.EventHandler(this.money100Btn_Click);
            // 
            // numberOfSheet100
            // 
            this.numberOfSheet100.AutoSize = true;
            this.numberOfSheet100.Location = new System.Drawing.Point(34, 81);
            this.numberOfSheet100.Name = "numberOfSheet100";
            this.numberOfSheet100.Size = new System.Drawing.Size(37, 15);
            this.numberOfSheet100.TabIndex = 6;
            this.numberOfSheet100.Text = "残数";
            // 
            // money50Group
            // 
            this.money50Group.Controls.Add(this.money50Btn);
            this.money50Group.Controls.Add(this.numberOfSheet50);
            this.money50Group.Location = new System.Drawing.Point(187, 175);
            this.money50Group.Name = "money50Group";
            this.money50Group.Size = new System.Drawing.Size(86, 111);
            this.money50Group.TabIndex = 10;
            // 
            // money50Btn
            // 
            this.money50Btn.AutoSize = true;
            this.money50Btn.Image = global::ticket_machine.Properties.Resources.money_50;
            this.money50Btn.Location = new System.Drawing.Point(3, 3);
            this.money50Btn.Name = "money50Btn";
            this.money50Btn.Size = new System.Drawing.Size(58, 58);
            this.money50Btn.TabIndex = 4;
            this.money50Btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.money50Btn.UseVisualStyleBackColor = true;
            this.money50Btn.Click += new System.EventHandler(this.money50Btn_Click);
            // 
            // numberOfSheet50
            // 
            this.numberOfSheet50.AutoSize = true;
            this.numberOfSheet50.Location = new System.Drawing.Point(34, 81);
            this.numberOfSheet50.Name = "numberOfSheet50";
            this.numberOfSheet50.Size = new System.Drawing.Size(37, 15);
            this.numberOfSheet50.TabIndex = 6;
            this.numberOfSheet50.Text = "残数";
            // 
            // money10Group
            // 
            this.money10Group.Controls.Add(this.money10Btn);
            this.money10Group.Controls.Add(this.numberOfSheet10);
            this.money10Group.Location = new System.Drawing.Point(336, 175);
            this.money10Group.Name = "money10Group";
            this.money10Group.Size = new System.Drawing.Size(86, 111);
            this.money10Group.TabIndex = 11;
            // 
            // money10Btn
            // 
            this.money10Btn.AutoSize = true;
            this.money10Btn.Image = global::ticket_machine.Properties.Resources.money_10;
            this.money10Btn.Location = new System.Drawing.Point(3, 3);
            this.money10Btn.Name = "money10Btn";
            this.money10Btn.Size = new System.Drawing.Size(58, 58);
            this.money10Btn.TabIndex = 4;
            this.money10Btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.money10Btn.UseVisualStyleBackColor = true;
            this.money10Btn.Click += new System.EventHandler(this.money10Btn_Click);
            // 
            // numberOfSheet10
            // 
            this.numberOfSheet10.AutoSize = true;
            this.numberOfSheet10.Location = new System.Drawing.Point(34, 81);
            this.numberOfSheet10.Name = "numberOfSheet10";
            this.numberOfSheet10.Size = new System.Drawing.Size(37, 15);
            this.numberOfSheet10.TabIndex = 6;
            this.numberOfSheet10.Text = "残数";
            // 
            // moneyIcGroup
            // 
            this.moneyIcGroup.Controls.Add(this.moneyIcBtn);
            this.moneyIcGroup.Controls.Add(this.numberOfSheetIc);
            this.moneyIcGroup.Location = new System.Drawing.Point(481, 170);
            this.moneyIcGroup.Name = "moneyIcGroup";
            this.moneyIcGroup.Size = new System.Drawing.Size(105, 116);
            this.moneyIcGroup.TabIndex = 8;
            // 
            // moneyIcBtn
            // 
            this.moneyIcBtn.AutoSize = true;
            this.moneyIcBtn.Image = global::ticket_machine.Properties.Resources.train_ic_card;
            this.moneyIcBtn.Location = new System.Drawing.Point(3, 3);
            this.moneyIcBtn.Name = "moneyIcBtn";
            this.moneyIcBtn.Size = new System.Drawing.Size(76, 63);
            this.moneyIcBtn.TabIndex = 4;
            this.moneyIcBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.moneyIcBtn.UseVisualStyleBackColor = true;
            this.moneyIcBtn.Click += new System.EventHandler(this.moneyIcBtn_Click);
            // 
            // numberOfSheetIc
            // 
            this.numberOfSheetIc.AutoSize = true;
            this.numberOfSheetIc.Location = new System.Drawing.Point(45, 86);
            this.numberOfSheetIc.Name = "numberOfSheetIc";
            this.numberOfSheetIc.Size = new System.Drawing.Size(37, 15);
            this.numberOfSheetIc.TabIndex = 6;
            this.numberOfSheetIc.Text = "残数";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ticketGroup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.icBalance);
            this.groupBox1.Controls.Add(this.moneyIcGroup);
            this.groupBox1.Controls.Add(this.money10Group);
            this.groupBox1.Controls.Add(this.money50Group);
            this.groupBox1.Controls.Add(this.money100Group);
            this.groupBox1.Controls.Add(this.money500Group);
            this.groupBox1.Controls.Add(this.money5000Group);
            this.groupBox1.Controls.Add(this.money10000Group);
            this.groupBox1.Controls.Add(this.money1000Group);
            this.groupBox1.Location = new System.Drawing.Point(106, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 317);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "金種＆チケット";
            // 
            // ticketGroup
            // 
            this.ticketGroup.Controls.Add(this.pictureBox1);
            this.ticketGroup.Controls.Add(this.numberOfSheetTicket);
            this.ticketGroup.Location = new System.Drawing.Point(620, 170);
            this.ticketGroup.Name = "ticketGroup";
            this.ticketGroup.Size = new System.Drawing.Size(105, 116);
            this.ticketGroup.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ticket_machine.Properties.Resources.ticket;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 61);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // numberOfSheetTicket
            // 
            this.numberOfSheetTicket.AutoSize = true;
            this.numberOfSheetTicket.Location = new System.Drawing.Point(45, 86);
            this.numberOfSheetTicket.Name = "numberOfSheetTicket";
            this.numberOfSheetTicket.Size = new System.Drawing.Size(37, 15);
            this.numberOfSheetTicket.TabIndex = 6;
            this.numberOfSheetTicket.Text = "残数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "残高";
            // 
            // icBalance
            // 
            this.icBalance.AutoSize = true;
            this.icBalance.Location = new System.Drawing.Point(526, 289);
            this.icBalance.Name = "icBalance";
            this.icBalance.Size = new System.Drawing.Size(37, 15);
            this.icBalance.TabIndex = 14;
            this.icBalance.Text = "残高";
            // 
            // ticketMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 777);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.windowGroup);
            this.Name = "ticketMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketMachine";
            this.windowGroup.ResumeLayout(false);
            this.windowGroup.PerformLayout();
            this.money1000Group.ResumeLayout(false);
            this.money1000Group.PerformLayout();
            this.money10000Group.ResumeLayout(false);
            this.money10000Group.PerformLayout();
            this.money5000Group.ResumeLayout(false);
            this.money5000Group.PerformLayout();
            this.money500Group.ResumeLayout(false);
            this.money500Group.PerformLayout();
            this.money100Group.ResumeLayout(false);
            this.money100Group.PerformLayout();
            this.money50Group.ResumeLayout(false);
            this.money50Group.PerformLayout();
            this.money10Group.ResumeLayout(false);
            this.money10Group.PerformLayout();
            this.moneyIcGroup.ResumeLayout(false);
            this.moneyIcGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ticketGroup.ResumeLayout(false);
            this.ticketGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label mainDisplay;
        private System.Windows.Forms.Button priceBtn;
        private System.Windows.Forms.Panel windowGroup;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label amountOfMoney;
        private System.Windows.Forms.Label AmountOfMoneyText;
        private System.Windows.Forms.Label numberOfSheet1000;
        private System.Windows.Forms.Button money1000Btn;
        private System.Windows.Forms.Panel money1000Group;
        private System.Windows.Forms.Panel money10000Group;
        private System.Windows.Forms.Button money10000Btn;
        private System.Windows.Forms.Label numberOfSheet10000;
        private System.Windows.Forms.Panel money5000Group;
        private System.Windows.Forms.Button money5000Btn;
        private System.Windows.Forms.Label numberOfSheet5000;
        private System.Windows.Forms.Panel money500Group;
        private System.Windows.Forms.Button money500Btn;
        private System.Windows.Forms.Label numberOfSheet500;
        private System.Windows.Forms.Panel money100Group;
        private System.Windows.Forms.Button money100Btn;
        private System.Windows.Forms.Label numberOfSheet100;
        private System.Windows.Forms.Panel money50Group;
        private System.Windows.Forms.Button money50Btn;
        private System.Windows.Forms.Label numberOfSheet50;
        private System.Windows.Forms.Panel money10Group;
        private System.Windows.Forms.Button money10Btn;
        private System.Windows.Forms.Label numberOfSheet10;
        private System.Windows.Forms.Panel moneyIcGroup;
        private System.Windows.Forms.Button moneyIcBtn;
        private System.Windows.Forms.Label numberOfSheetIc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label icBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label payoutText;
        private System.Windows.Forms.Label oturiText;
        private System.Windows.Forms.Panel ticketGroup;
        private System.Windows.Forms.Label numberOfSheetTicket;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label paid;
        private System.Windows.Forms.Label paidText;
    }
}

