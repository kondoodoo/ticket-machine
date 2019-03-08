using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Ticket_Machine
{
    enum Moneytype : int
    {
        m10,//10円
        m50,//50円
        m100,//100円
        m500,//500
        m1000,//1000
        m5000,//5000
        m10000,//10000
        IcCard//ICカード
    }

    public partial class ticketMachine : Form
    {

        public struct Money
        {
            public int Remains;//残高
            public int Turned;//返却数
            public int IcMoney;//IC残高
        }

        Money[] TextMoney = new Money[8];


        public ticketMachine()
        {

            InitializeComponent();
            TextMoney[(int)Moneytype.m10].Remains = 15;
            TextMoney[(int)Moneytype.m50].Remains = 3;
            TextMoney[(int)Moneytype.m100].Remains = 2;
            TextMoney[(int)Moneytype.m500].Remains = 1;
            TextMoney[(int)Moneytype.m1000].Remains = 1;
            TextMoney[(int)Moneytype.m5000].Remains = 1;
            TextMoney[(int)Moneytype.m10000].Remains = 1;
            TextMoney[(int)Moneytype.IcCard].Remains = 1;
            TextMoney[(int)Moneytype.IcCard].IcMoney = 1000;
            numberOfSheetTicket.Text = "0";
            MoneyRemain();
            icBalance.Text = TextMoney[(int)Moneytype.IcCard].IcMoney.ToString();
        }



        /// <summary>
        /// 計算処理
        /// </summary>
        private void MoneyRemain()//残枚数反映
        {
            numberOfSheet10.Text = TextMoney[(int)Moneytype.m10].Remains.ToString();
            numberOfSheet50.Text = TextMoney[(int)Moneytype.m50].Remains.ToString();
            numberOfSheet100.Text = TextMoney[(int)Moneytype.m100].Remains.ToString();
            numberOfSheet500.Text = TextMoney[(int)Moneytype.m500].Remains.ToString();
            numberOfSheet1000.Text = TextMoney[(int)Moneytype.m1000].Remains.ToString();
            numberOfSheet5000.Text = TextMoney[(int)Moneytype.m5000].Remains.ToString();
            numberOfSheet10000.Text = TextMoney[(int)Moneytype.m10000].Remains.ToString();
            numberOfSheetIc.Text = TextMoney[(int)Moneytype.IcCard].Remains.ToString();
        }
        private void MoneyPlus(int money)//投入金額の欄に投入金額を足す
        {
            int Total = int.Parse(amountOfMoney.Text);
            Total += money;
            amountOfMoney.Text = Total.ToString();
        }
        private void PayOut()//払い出し金種格納＆後返却用の変数を初期化
        {
            int Total = int.Parse(amountOfMoney.Text);
            for (int i = 0; i < 8; i++)
            {
                TextMoney[i].Turned = 0;
                
            }

            while (Total > 0)
            {
                if (Total >= 10000)
                {
                    TextMoney[(int)Moneytype.m10000].Turned += 1;
                    Total -= 10000;
                }
                else if (Total < 10000 && Total >= 5000)
                {
                    TextMoney[(int)Moneytype.m5000].Turned += 1;
                    Total -= 5000;

                }
                else if (Total < 5000 && Total >= 1000)
                {
                    TextMoney[(int)Moneytype.m1000].Turned += 1;
                    Total -= 1000;

                }
                else if (Total < 1000 && Total >= 500)
                {
                    TextMoney[(int)Moneytype.m500].Turned += 1;
                    Total -= 500;

                }
                else if (Total < 500 && Total >= 100)
                {

                    TextMoney[(int)Moneytype.m100].Turned += 1;
                    Total -= 100;
                }
                else if (Total < 100 && Total >= 50)
                {

                    TextMoney[(int)Moneytype.m50].Turned += 1;
                    Total -= 50;
                }
                else if (Total < 50 && Total >= 10)
                {

                    TextMoney[(int)Moneytype.m10].Turned += 1;
                    Total -= 10;
                }
            }

            PayOutDisplay();
            for (int i = 0; i < 8; i++)
            {
                TextMoney[i].Remains += TextMoney[i].Turned;
                TextMoney[i].Turned = 0;

            }
            amountOfMoney.Text = Total.ToString();


        }
        private void PayOutDisplay()//お釣り表示
        {
            if (TextMoney[(int)Moneytype.IcCard].Remains==1) {
                payoutText.Text = "合計：" + amountOfMoney.Text + "円\n";
                if (TextMoney[(int)Moneytype.m10000].Turned >= 1)
                {

                    payoutText.Text += "10000円" + TextMoney[(int)Moneytype.m10000].Turned.ToString() + "枚\n";

                }
                if (TextMoney[(int)Moneytype.m5000].Turned >= 1)
                {

                    payoutText.Text += "5000円" + TextMoney[(int)Moneytype.m5000].Turned.ToString() + "枚\n";

                }
                if (TextMoney[(int)Moneytype.m1000].Turned >= 1)
                {

                    payoutText.Text += "1000円" + TextMoney[(int)Moneytype.m1000].Turned.ToString() + "枚\n";

                }
                if (TextMoney[(int)Moneytype.m500].Turned >= 1)
                {

                    payoutText.Text += "500円" + TextMoney[(int)Moneytype.m500].Turned.ToString() + "枚\n";

                }
                if (TextMoney[(int)Moneytype.m100].Turned >= 1)
                {

                    payoutText.Text += "100円" + TextMoney[(int)Moneytype.m100].Turned.ToString() + "枚\n";

                }
                if (TextMoney[1].Turned >= 1)
                {

                    payoutText.Text += "50円" + TextMoney[(int)Moneytype.m50].Turned.ToString() + "枚\n";

                }
                if (TextMoney[0].Turned >= 1)
                {

                    payoutText.Text += "10円" + TextMoney[(int)Moneytype.m10].Turned.ToString() + "枚\n";

                }
            }
            else if (TextMoney[(int)Moneytype.IcCard].Remains==0)
            {
                payoutText.Text = "残高：" + amountOfMoney.Text + "円\n";
            }
        }
        private void PaidDisplay() {//投入金種表示
    
            if (TextMoney[(int)Moneytype.IcCard].Remains == 1)
            {
            
                if (TextMoney[(int)Moneytype.m10000].Turned >= 1)
                {

                    paidText.Text += "10000円" + TextMoney[(int)Moneytype.m10000].Turned.ToString() + "枚\n";

                }
                if (TextMoney[(int)Moneytype.m5000].Turned >= 1)
                {

                    paidText.Text += "5000円" + TextMoney[(int)Moneytype.m5000].Turned.ToString() + "枚\n";

                }
                if (TextMoney[(int)Moneytype.m1000].Turned >= 1)
                {

                    paidText.Text += "1000円" + TextMoney[(int)Moneytype.m1000].Turned.ToString() + "枚\n";

                }
                if (TextMoney[(int)Moneytype.m500].Turned >= 1)
                {

                    paidText.Text += "500円" + TextMoney[(int)Moneytype.m500].Turned.ToString() + "枚\n";

                }
                if (TextMoney[(int)Moneytype.m100].Turned >= 1)
                {

                    paidText.Text += "100円" + TextMoney[(int)Moneytype.m100].Turned.ToString() + "枚\n";

                }
                if (TextMoney[(int)Moneytype.m50].Turned >= 1)
                {

                    paidText.Text += "50円" + TextMoney[(int)Moneytype.m50].Turned.ToString() + "枚\n";

                }
                if (TextMoney[(int)Moneytype.m10].Turned >= 1)
                {

                    paidText.Text += "10円" + TextMoney[(int)Moneytype.m10].Turned.ToString() + "枚\n";

                }
            }
            else if (TextMoney[(int)Moneytype.IcCard].Remains == 0)
            {
                paidText.Text = "ICカード" + TextMoney[(int)Moneytype.IcCard].Turned + "枚\n";
            }

        }

        /// <summary>
        /// クリックイベント
        /// </summary>
        void priceBtn_Click(object sender, EventArgs e) {

            
            int Total = int.Parse(amountOfMoney.Text);
            if (Total >= 124)
            {
             
                if (TextMoney[(int)Moneytype.IcCard].Remains == 1)
                {
                    paidText.Text = "";
                    payoutText.Text = "";
                    PaidDisplay();
                    Total -= 130;
                    amountOfMoney.Text = Total.ToString();
                    PayOut();
                    mainDisplay.Text = "ありがとうございました";
                    int Ticket = int.Parse(numberOfSheetTicket.Text);
                    Ticket += 1;
                    numberOfSheetTicket.Text = Ticket.ToString();
                }
                else if (TextMoney[(int)Moneytype.IcCard].Remains == 0)
                {
                    paidText.Text = "";
                    payoutText.Text = "";
                    PaidDisplay();
                    Total -= 124;
                    amountOfMoney.Text = Total.ToString();
                    PayOutDisplay();
                    TextMoney[(int)Moneytype.IcCard].IcMoney = Total;
                    TextMoney[(int)Moneytype.IcCard].Turned = 0;
                    TextMoney[(int)Moneytype.IcCard].Remains = 1;
                    Total = 0;
                    amountOfMoney.Text = Total.ToString();
                    icBalance.Text = TextMoney[(int)Moneytype.IcCard].IcMoney.ToString();
                    mainDisplay.Text = "ありがとうございました";
                    int Ticket = int.Parse(numberOfSheetTicket.Text);
                    Ticket += 1;
                    numberOfSheetTicket.Text = Ticket.ToString();
                }
          
                MoneyRemain();
                
            }
            else
            {

                mainDisplay.Text = "お金が足りません";

            }
        }
        private void money10000Btn_Click(object sender, EventArgs e)//10000
        {
            if (TextMoney[(int)Moneytype.IcCard].Remains == 1)
            {
                if (TextMoney[(int)Moneytype.m10000].Remains > 0)
                {
                    MoneyPlus(10000);
                    TextMoney[(int)Moneytype.m10000].Remains -= 1;
                    TextMoney[(int)Moneytype.m10000].Turned += 1;
                }
             
            }
            mainDisplay.Text = "お金またはICカードを入れてください";
            MoneyRemain();
        }

        private void money5000Btn_Click(object sender, EventArgs e)//5000
        {
            if (TextMoney[(int)Moneytype.IcCard].Remains == 1)
            {
                if (TextMoney[(int)Moneytype.m5000].Remains > 0)
                {

                    MoneyPlus(5000);
                    TextMoney[(int)Moneytype.m5000].Remains -= 1;
                    TextMoney[(int)Moneytype.m5000].Turned += 1;

                }
            }
            mainDisplay.Text = "お金またはICカードを入れてください";
            MoneyRemain();
        }
        private void money_1000Btn_Click(object sender, EventArgs e)//1000
        {
            if (TextMoney[(int)Moneytype.IcCard].Remains == 1)
            {
                if (TextMoney[(int)Moneytype.m1000].Remains > 0)
                {
                    MoneyPlus(1000);
                    TextMoney[(int)Moneytype.m1000].Remains -= 1;
                    TextMoney[(int)Moneytype.m1000].Turned += 1;
                }
            }
            mainDisplay.Text = "お金またはICカードを入れてください";
            MoneyRemain();
        }
        private void money500Btn_Click(object sender, EventArgs e)//500
        {
            if (TextMoney[(int)Moneytype.IcCard].Remains == 1)
            {
                if (TextMoney[(int)Moneytype.m500].Remains > 0)
                {
                    MoneyPlus(500);
                    TextMoney[(int)Moneytype.m500].Remains -= 1;
                    TextMoney[(int)Moneytype.m500].Turned += 1;

                }
            }
            mainDisplay.Text = "お金またはICカードを入れてください";
            MoneyRemain();
        }
        private void money100Btn_Click(object sender, EventArgs e)//100
        {
            if (TextMoney[(int)Moneytype.IcCard].Remains == 1)
            {
                if (TextMoney[(int)Moneytype.m100].Remains > 0)
                {
                    MoneyPlus(100);
                    TextMoney[(int)Moneytype.m100].Remains -= 1;
                    TextMoney[(int)Moneytype.m100].Turned += 1;
                }
            }
            mainDisplay.Text = "お金またはICカードを入れてください";
            MoneyRemain();
        }
        private void money50Btn_Click(object sender, EventArgs e)//50
        {
            if (TextMoney[(int)Moneytype.IcCard].Remains == 1)
            {
                if (TextMoney[(int)Moneytype.m50].Remains > 0)
                {
                    MoneyPlus(50);
                    TextMoney[(int)Moneytype.m50].Remains -= 1;
                    TextMoney[(int)Moneytype.m50].Turned += 1;
                }
            }
            mainDisplay.Text = "お金またはICカードを入れてください";
            MoneyRemain();
        }
        private void money10Btn_Click(object sender, EventArgs e)//10
        {
            if (TextMoney[(int)Moneytype.IcCard].Remains == 1)
            {
                if (TextMoney[(int)Moneytype.m10].Remains > 0)
                {
                    MoneyPlus(10);
                    TextMoney[(int)Moneytype.m10].Remains -= 1;
                    TextMoney[(int)Moneytype.m10].Turned += 1;

                }
            }
            mainDisplay.Text = "お金またはICカードを入れてください";
            MoneyRemain();
        }
        private void moneyIcBtn_Click(object sender, EventArgs e)//ICカード
        {
            int Decision = int.Parse(amountOfMoney.Text);
            if (Decision == 0)
            {
                if (TextMoney[(int)Moneytype.IcCard].Remains == 1)
                {

                    MoneyPlus(TextMoney[(int)Moneytype.IcCard].IcMoney);
                    TextMoney[(int)Moneytype.IcCard].Remains -= 1;
                    TextMoney[(int)Moneytype.IcCard].Turned = 1;
                }
            }
            mainDisplay.Text = "お金またはICカードを入れてください";
            MoneyRemain();
        }
        private void cancel_Click(object sender, EventArgs e)//キャンセル
        {
            int Initialize = 0;

            for (int i = 0; i < 8; i++)
            {
                TextMoney[i].Remains += TextMoney[i].Turned;
                TextMoney[i].Turned = 0;

            }

            amountOfMoney.Text = Initialize.ToString();
            MoneyRemain();

        }

  
    }
}
