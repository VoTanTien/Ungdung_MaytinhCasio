using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Maytinh
{

    public partial class MainPage : ContentPage
    {
        private XuLyData dataAccess;
        double ansResult = 0;
        public MainPage()
        {
            InitializeComponent();
            this.dataAccess = new XuLyData();
        }

        private void Btn_Menu_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ChucNang();
        }
        private void BtnDonVi_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new DoiDonVi();
        }
        private void BtnLichSu_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new LichSu();
        }

        private void btnKhong_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "0";
        }
        private void btnPhay_Clicked(object sender, EventArgs e)
        {
            lbBieuThuc.Text += ".";
        }

        private void btnMot_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "1";
        }

        private void btnHai_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "2";
        }

        private void btnBa_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "3";
        }

        private void btnBon_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "4";
        }

        private void btnNam_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "5";
        }

        private void btnSau_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "6";
        }

        private void btnBay_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "7";
        }

        private void btnTam_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "8";
        }

        private void btnChin_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "9";
        }

        private void btnCong_Clicked(object sender, EventArgs e)
        {
            if (lbKetQua.Text != "0")
                lbBieuThuc.Text = lbKetQua.Text;
            lbBieuThuc.Text += "+";

        }

        private void btnTru_Clicked(object sender, EventArgs e)
        {
            if (lbKetQua.Text != "0")
                lbBieuThuc.Text = lbKetQua.Text;
            lbBieuThuc.Text += "-";
        }

        private void btnNhan_Clicked(object sender, EventArgs e)
        {
            if (lbKetQua.Text != "0")
                lbBieuThuc.Text = lbKetQua.Text;
            lbBieuThuc.Text += "*";
        }

        private void btnChia_Clicked(object sender, EventArgs e)
        {
            if (lbKetQua.Text != "0")
                lbBieuThuc.Text = lbKetQua.Text;
            lbBieuThuc.Text += "/";
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text.Length > 0)
                lbBieuThuc.Text = lbBieuThuc.Text.Substring(0, lbBieuThuc.Text.Length - 1);
        }

        private void btnCE_Clicked(object sender, EventArgs e)
        {
            lbBieuThuc.Text = "0";
        }

        private void btnAC_Clicked(object sender, EventArgs e)
        {
            lbBieuThuc.Text = "0";
            lbKetQua.Text = "0";
        }


        private bool isOperator(char checkChar)
        {
            if (checkChar == '+' || checkChar == '−' || checkChar == '×' || checkChar == '÷')
                return true;
            return false;
        }
        // xet do uu tien toan tu
        public int Precedence(char x)
        {
            if (x == '+' || x == '-')
                return 1;
            if (x == '*' || x == '/')
                return 2;
            return 0;
        }
        // chuyen sang bieu thuc hau to
        public List<string> InfixtoPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            List<string> hauTo = new List<string>();
            for (int i = 0; i < infix.Length;)
            {
                if ((int)infix[i] >= 48 && (int)infix[i] <= 57)
                {
                    string token = "";
                    while (i < infix.Length && infix[i] != '(' && infix[i] != ')' && infix[i] != '+' && infix[i] != '-' && infix[i] != '*' && infix[i] != '/')
                    {
                        token += infix[i];
                        i++;
                    }
                    hauTo.Add(token);
                }
                else if (infix[i] == '(')
                {
                    stack.Push(infix[i]);
                    i++;
                }
                else if (infix[i] == ')')
                {
                    string temp = stack.Pop().ToString();
                    while (stack.Count > 0 && temp != "(")
                    {
                        hauTo.Add(temp);
                        temp = stack.Pop().ToString();
                    }
                    i++;
                }
                else
                {
                    while (stack.Count > 0 && Precedence(infix[i]) <= Precedence(stack.Peek()))
                    {
                        hauTo.Add(stack.Pop().ToString());
                    }
                    stack.Push(infix[i]);
                    i++;
                }
            }
            while (stack.Count > 0) hauTo.Add(stack.Pop().ToString());
            return hauTo;
        }
        // tinh gia tri của bieu thu hau to
        public double evalue(string _bieuThuc)
        {
            if (_bieuThuc != "+∞" && _bieuThuc != "-∞")
            {
                if (_bieuThuc[0] == '-')
                {
                    _bieuThuc = "0" + _bieuThuc;
                }
                List<string> hauTo = InfixtoPostfix(_bieuThuc);
                Stack<double> stack = new Stack<double>();
                foreach (var item in hauTo)
                {
                    double a = 0, b = 0;
                    switch (item)
                    {
                        case "+":
                            a = stack.Pop();
                            b = stack.Pop();
                            stack.Push(a + b);
                            break;
                        case "-":
                            a = stack.Pop();
                            b = stack.Pop();
                            stack.Push(b - a);
                            break;
                        case "*":
                            a = stack.Pop();
                            b = stack.Pop();
                            stack.Push(b * a);
                            break;
                        case "/":
                            a = stack.Pop();
                            b = stack.Pop();
                            stack.Push(b / a);
                            break;
                        default:
                            stack.Push(double.Parse(item));
                            break;
                    }
                }
                return stack.Pop();
            }
            else return 0;
        }


        private void btnBang_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                lbKetQua.Text = evalue(lbBieuThuc.Text).ToString();
                ansResult = double.Parse(lbKetQua.Text);

            }
            catch
            {
                lbKetQua.Text = "Lỗi biểu thức";
            }
            string a = lbBieuThuc.Text;
            this.dataAccess.AddLS(DateTime.Now.ToString(), a, ansResult.ToString());
        }
    }
}
