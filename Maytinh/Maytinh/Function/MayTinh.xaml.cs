using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maytinh.Function
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MayTinh : ContentPage
    {
        private XuLyData dataAccess;
        double ansResult = 0;
        int clickArc = 0;
        public MayTinh()
        {
            InitializeComponent();
            this.dataAccess = new XuLyData();
        }
        private void BtnHome_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
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
            lbBieuThuc.Text += "+";
        }

        private void btnTru_Clicked(object sender, EventArgs e)
        {
            lbBieuThuc.Text += "-";
        }

        private void btnNhan_Clicked(object sender, EventArgs e)
        {
            lbBieuThuc.Text += "*";
        }

        private void btnChia_Clicked(object sender, EventArgs e)
        {
            lbBieuThuc.Text += "/";
        }
        private void btnCanBacBa_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "³√(";
        }

        private void btnCanBacHai_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "√(";
        }

        private void btnPI_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "π";
        }

        private void btnGiaiThua_Clicked(object sender, EventArgs e)
        {
            lbBieuThuc.Text += "!";
        }

        private void btnDongNgoac_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += ")";
        }

        private void btnMoNgoac_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "(";
        }

        private void btnMu_Clicked(object sender, EventArgs e)
        {
            lbBieuThuc.Text += "^(";
        }

        private void btnAns_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "Ans";
        }
        private void BtnArc_Clicked(object sender, EventArgs e)
        {
            if (clickArc == 0)
            {
                btnArc.BackgroundColor = Xamarin.Forms.Color.FromHex("#BFE8FF");
                clickArc = 1;
            }
            else
            {
                btnArc.BackgroundColor = Xamarin.Forms.Color.FromHex("#3F75FF");
                clickArc = 0;
            }
        }
        private void btnTan_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            if (clickArc == 1)
            {
                lbBieuThuc.Text += "arctan(";
                clickArc = 0;
                btnArc.BackgroundColor = Xamarin.Forms.Color.FromHex("#3F75FF");
            }
            else lbBieuThuc.Text += "tan(";
        }

        private void btnCos_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            if (clickArc == 1)
            {
                lbBieuThuc.Text += "arccos(";
                clickArc = 0;
                btnArc.BackgroundColor = Xamarin.Forms.Color.FromHex("#3F75FF");
            }
            else lbBieuThuc.Text += "cos(";
        }

        private void btnSin_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            if (clickArc == 1)
            {
                lbBieuThuc.Text += "arcsin(";
                clickArc = 0;
                btnArc.BackgroundColor = Xamarin.Forms.Color.FromHex("#3F75FF");
            }
            else lbBieuThuc.Text += "sin(";
        }

        private void btnLog_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "log(";
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text.Length > 0)
                lbBieuThuc.Text = lbBieuThuc.Text.Substring(0, lbBieuThuc.Text.Length - 1);
        }



        private void btnAC_Clicked(object sender, EventArgs e)
        {
            lbBieuThuc.Text = "0";
            lbKetQua.Text = "0";
        }

        private void btnLn_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "ln(";
        }

        private void btnE_Clicked(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text == "0") lbBieuThuc.Text = "";
            lbBieuThuc.Text += "e";
        }
        private bool isOperator(char checkChar)
        {
            if (checkChar == '+' || checkChar == '−' || checkChar == '×' || checkChar == '÷')
                return true;
            return false;
        }

        public int Precedence(char x)
        {
            if (x == '+' || x == '-')
                return 1;
            if (x == '*' || x == '/')
                return 2;
            return 0;
        }

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
        // tinh cac ham mu
        // tinh gia tri cac luy thua
        public string axtractPow(string expr)
        {
            string result = expr;
            string strGiaiThua = "!";
            while (result.Contains(strGiaiThua))
            {
                for (int i = 1; i <= result.Length - 1; i++)
                {
                    string tempGiaiThua = "";
                    if (result[i] == '!')
                    {
                        int k = i - 1;
                        if ((int)result[k] >= 48 && (int)result[k] <= 57)
                        {
                            string temp = "";
                            while (k >= 0 && (int)result[k] >= 48 && (int)result[k] <= 57)
                            {
                                temp += result[k];
                                k--;
                            }
                            tempGiaiThua = temp;
                            result = result.Substring(0, i) + result.Substring(i + 1);
                            for (int t = 2; t <= int.Parse(tempGiaiThua); t++)
                            {
                                temp = (int.Parse(temp) - 1).ToString();
                                result = result.Insert(i, "*" + temp);
                            }
                        }
                        break;
                    }
                }
            }
            return result;
        }
        // thay so cac hang so
        public string replaceWith(string expr)
        {
            string result = expr;
            while (result.Contains("e") || result.Contains("π") || result.Contains("Ans"))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == 'e')
                    {
                        result = result.Substring(0, i) + result.Substring(i + 1);
                        result = result.Insert(i, Math.E.ToString());
                        break;
                    }
                    if (result[i] == 'π')
                    {
                        result = result.Substring(0, i) + result.Substring(i + 1);
                        result = result.Insert(i, Math.PI.ToString());
                        break;
                    }
                    if (result[i] == 'A' && result[i + 1] == 'n' && result[i + 2] == 's')
                    {
                        result = result.Substring(0, i) + result.Substring(i + 3);
                        result = result.Insert(i, ansResult.ToString());
                    }
                }
            }
            return result;
        }

        public string calcFunc(string expr)
        {
            string result = expr;

            int indexOfSqrt = expr.IndexOf("√(");
            string resultSqrt = "";
            int indexOfSqrt3 = expr.IndexOf("³√(");
            string resultSqrt3 = "";
            int indexOfLn = expr.IndexOf("ln(");
            string resultLn = "";
            int indexOfLog = expr.IndexOf("log(");
            string resultLog = "";
            int indexOfSin = expr.IndexOf("sin(");
            string resultSin = "";
            int indexOfArcSin = expr.IndexOf("arcsin(");
            string resultArcSin = "";
            int indexOfCos = expr.IndexOf("cos(");
            string resultCos = "";
            int indexOfArcCos = expr.IndexOf("arccos(");
            string resultArcCos = "";
            int indexOfTan = expr.IndexOf("tan(");
            string resultTan = "";
            int indexOfArcTan = expr.IndexOf("arctan(");
            string resultArcTan = "";
            int indexOfPow = expr.IndexOf("^(");
            string resultPow = "";

            // tinh ham so mu
            if (result.IndexOf("^(") >= 0)
            {
                indexOfPow = result.IndexOf("^(");
                int i = indexOfPow + 2;
                string tempPow = "";
                string tempBase = "";
                int checkPow = 1;
                int checkBase = 1;
                int indexBeginPow = 0;
                int indexEndPow = 0;
                // lay so mu
                while (i < result.Length && checkPow != 0)
                {
                    if (i < result.Length && result[i] == '(') checkPow++;
                    if (i < result.Length && result[i] == ')') checkPow--;
                    if (checkPow != 0)
                        tempPow += result[i];
                    i++;
                }
                indexEndPow = i;
                // lay co so
                i = indexOfPow - 2;
                while (i >= 0 && checkBase != 0)
                {
                    if (i >= 0 && result[i] == ')') checkBase++;
                    if (i >= 0 && result[i] == '(') checkBase--;
                    if (i >= 0 && checkBase != 0) tempBase = result[i] + tempBase;
                    i--;
                }
                indexBeginPow = i;
                while (tempPow.IndexOf("√(") >= 0 || tempPow.IndexOf("ln(") >= 0 || tempPow.IndexOf("sin(") >= 0
                    || tempPow.IndexOf("cos(") >= 0 || tempPow.IndexOf("tan(") >= 0 || tempPow.IndexOf("log(") >= 0
                    || tempPow.IndexOf("³√(") >= 0 || tempPow.IndexOf("arcsin(") >= 0 || tempPow.IndexOf("arccos(") >= 0
                    || tempPow.IndexOf("arctan(") >= 0 || tempPow.IndexOf("^(") >= 0)
                {
                    tempPow = calcFunc(tempPow);
                }
                while (tempBase.IndexOf("√(") >= 0 || tempBase.IndexOf("ln(") >= 0 || tempBase.IndexOf("sin(") >= 0
                    || tempBase.IndexOf("cos(") >= 0 || tempBase.IndexOf("tan(") >= 0 || tempBase.IndexOf("log(") >= 0
                    || tempBase.IndexOf("³√(") >= 0 || tempBase.IndexOf("arcsin(") >= 0 || tempBase.IndexOf("arccos(") >= 0
                    || tempBase.IndexOf("arctan(") >= 0 || tempBase.IndexOf("^(") >= 0)
                {
                    tempBase = calcFunc(tempBase);
                }
                resultPow = Math.Round(Math.Pow(evalue(tempBase), evalue(tempPow)), 12).ToString();
                decimal dec = decimal.Parse(resultPow);
                resultPow = dec.ToString();
                result = result.Substring(0, indexBeginPow + 1) + result.Substring(indexEndPow);
                result = result.Insert(indexBeginPow + 1, resultPow);
            }
            // tinh ham sqrt
            if (!expr.Contains("³√(") && result.IndexOf("√(") >= 0)
            {
                indexOfSqrt = result.IndexOf("√(");
                int i = indexOfSqrt + 2;
                string tempSqrt = "";
                int check = 1;
                while (i < result.Length && check != 0)
                {
                    if (i < result.Length && result[i] == '(') check++;
                    if (i < result.Length && result[i] == ')') check--;
                    if (check != 0)
                        tempSqrt += result[i];
                    i++;
                }
                while (tempSqrt.IndexOf("√(") >= 0 || tempSqrt.IndexOf("ln(") >= 0 || tempSqrt.IndexOf("sin(") >= 0
                    || tempSqrt.IndexOf("cos(") >= 0 || tempSqrt.IndexOf("tan(") >= 0 || tempSqrt.IndexOf("log(") >= 0
                    || tempSqrt.IndexOf("³√(") >= 0 || tempSqrt.IndexOf("arcsin(") >= 0 || tempSqrt.IndexOf("arccos(") >= 0
                    || tempSqrt.IndexOf("arctan(") >= 0 || tempSqrt.IndexOf("^(") >= 0)
                {
                    tempSqrt = calcFunc(tempSqrt);
                }
                resultSqrt = Math.Round(Math.Sqrt(evalue(tempSqrt)), 12).ToString();
                result = result.Substring(0, indexOfSqrt) + result.Substring(i);
                result = result.Insert(indexOfSqrt, resultSqrt);
            }
            // tinh ham sqrt3
            if (expr.Contains("³√(") && result.IndexOf("³√(") >= 0)
            {
                indexOfSqrt3 = result.IndexOf("³√(");
                int i = indexOfSqrt3 + 3;
                string tempSqrt3 = "";
                int check = 1;
                while (i < result.Length && check != 0)
                {
                    if (i < result.Length && result[i] == '(') check++;
                    if (i < result.Length && result[i] == ')') check--;
                    if (check != 0)
                        tempSqrt3 += result[i];
                    i++;
                }
                while (tempSqrt3.IndexOf("√(") >= 0 || tempSqrt3.IndexOf("ln(") >= 0 || tempSqrt3.IndexOf("sin(") >= 0
                    || tempSqrt3.IndexOf("cos(") >= 0 || tempSqrt3.IndexOf("tan(") >= 0 || tempSqrt3.IndexOf("log(") >= 0
                    || tempSqrt3.IndexOf("³√(") >= 0 || tempSqrt3.IndexOf("arcsin(") >= 0 || tempSqrt3.IndexOf("arccos(") >= 0
                    || tempSqrt3.IndexOf("arctan(") >= 0 || tempSqrt3.IndexOf("^(") >= 0)
                {
                    tempSqrt3 = calcFunc(tempSqrt3);
                }
                resultSqrt3 = Math.Round(Math.Pow(evalue(tempSqrt3), (double)1 / 3), 12).ToString();
                result = result.Substring(0, indexOfSqrt3) + result.Substring(i);
                result = result.Insert(indexOfSqrt3, resultSqrt3);
            }
            // tinh ham ln
            else if (result.Contains("ln(") && result.IndexOf("ln(") >= 0)
            {
                indexOfLn = result.IndexOf("ln(");
                int i = indexOfLn + 3;
                string tempLn = "";
                int check = 1;
                while (i < result.Length && check != 0)
                {
                    if (i < result.Length && result[i] == '(') check++;
                    if (i < result.Length && result[i] == ')') check--;
                    if (check != 0)
                        tempLn += result[i];
                    i++;
                }
                while (tempLn.IndexOf("√(") >= 0 || tempLn.IndexOf("ln(") >= 0 || tempLn.IndexOf("sin(") >= 0
                    || tempLn.IndexOf("cos(") >= 0 || tempLn.IndexOf("tan(") >= 0 || tempLn.IndexOf("log(") >= 0
                    || tempLn.IndexOf("³√(") >= 0 || tempLn.IndexOf("arcsin(") >= 0 || tempLn.IndexOf("arccos(") >= 0
                    || tempLn.IndexOf("arctan(") >= 0 || tempLn.IndexOf("^(") >= 0)
                {
                    tempLn = calcFunc(tempLn);
                }
                resultLn = Math.Round((Math.Log(evalue(tempLn)) / Math.Log(Math.E)), 12).ToString();
                result = result.Substring(0, indexOfLn) + result.Substring(i);
                if (resultLn[0] == '-')
                {
                    result = result.Insert(indexOfLn, "(0" + resultLn + ")");
                }
                else result = result.Insert(indexOfLn, resultLn);
            }
            // tinh ham log
            else if (result.Contains("log(") && result.IndexOf("log(") >= 0)
            {

                indexOfLog = result.IndexOf("log(");
                int i = indexOfLog + 4;
                string tempLog = "";
                int check = 1;
                while (i < result.Length && check != 0)
                {
                    if (i < result.Length && result[i] == '(') check++;
                    if (i < result.Length && result[i] == ')') check--;
                    if (check != 0)
                        tempLog += result[i];
                    i++;
                }
                while (tempLog.IndexOf("√(") >= 0 || tempLog.IndexOf("ln(") >= 0 || tempLog.IndexOf("sin(") >= 0
                    || tempLog.IndexOf("cos(") >= 0 || tempLog.IndexOf("tan(") >= 0 || tempLog.IndexOf("log(") >= 0
                    || tempLog.IndexOf("³√(") >= 0 || tempLog.IndexOf("arcsin(") >= 0 || tempLog.IndexOf("arccos(") >= 0
                    || tempLog.IndexOf("arctan(") >= 0 || tempLog.IndexOf("^(") >= 0)
                {
                    tempLog = calcFunc(tempLog);

                }
                resultLog = Math.Round(Math.Log(evalue(tempLog)) / Math.Log(10), 12).ToString();
                result = result.Substring(0, indexOfLog) + result.Substring(i);
                if (resultLog[0] == '-')
                {
                    result = result.Insert(indexOfLog, "(0" + resultLog + ")");
                }
                else result = result.Insert(indexOfLog, resultLog);
            }

            // tinh ham sin
            else if (!result.Contains("arcsin(") && result.IndexOf("sin(") >= 0)
            {
                indexOfSin = result.IndexOf("sin(");
                int i = indexOfSin + 4;
                string tempSin = "";
                int check = 1;
                while (i < result.Length && check != 0)
                {
                    if (i < result.Length && result[i] == '(') check++;
                    if (i < result.Length && result[i] == ')') check--;
                    if (check != 0)
                        tempSin += result[i];
                    i++;
                }
                while (tempSin.IndexOf("√(") >= 0 || tempSin.IndexOf("ln(") >= 0 || tempSin.IndexOf("sin(") >= 0
                    || tempSin.IndexOf("cos(") >= 0 || tempSin.IndexOf("tan(") >= 0 || tempSin.IndexOf("log(") >= 0
                    || tempSin.IndexOf("³√(") >= 0 || tempSin.IndexOf("arcsin(") >= 0 || tempSin.IndexOf("arccos(") >= 0
                    || tempSin.IndexOf("arctan(") >= 0 || tempSin.IndexOf("^(") >= 0)
                {
                    tempSin = calcFunc(tempSin);
                }
                if (rdRadian.IsToggled)
                    resultSin = Math.Round(Math.Sin(evalue(tempSin)), 12).ToString();
                else resultSin = Math.Round(Math.Sin(evalue(tempSin) / 180 * Math.PI), 12).ToString();
                result = result.Substring(0, indexOfSin) + result.Substring(i);
                if (resultSin[0] == '-')
                {
                    result = result.Insert(indexOfSin, "(0" + resultSin + ")");
                }
                else result = result.Insert(indexOfSin, resultSin);
            }
            // tinh ham arcsin
            else if (result.IndexOf("arcsin(") >= 0)
            {
                indexOfArcSin = result.IndexOf("arcsin(");
                int i = indexOfArcSin + 7;
                string tempArcSin = "";
                int check = 1;
                while (i < result.Length && check != 0)
                {
                    if (i < result.Length && result[i] == '(') check++;
                    if (i < result.Length && result[i] == ')') check--;
                    if (check != 0)
                        tempArcSin += result[i];
                    i++;
                }
                while (tempArcSin.IndexOf("√(") >= 0 || tempArcSin.IndexOf("ln(") >= 0 || tempArcSin.IndexOf("sin(") >= 0
                    || tempArcSin.IndexOf("cos(") >= 0 || tempArcSin.IndexOf("tan(") >= 0 || tempArcSin.IndexOf("log(") >= 0
                    || tempArcSin.IndexOf("³√(") >= 0 || tempArcSin.IndexOf("arcsin(") >= 0 || tempArcSin.IndexOf("arccos(") >= 0
                    || tempArcSin.IndexOf("arctan(") >= 0 || tempArcSin.IndexOf("^(") >= 0)
                {
                    tempArcSin = calcFunc(tempArcSin);
                }
                if (rdRadian.IsToggled)
                    resultArcSin = Math.Round(Math.Asin(evalue(tempArcSin)), 12).ToString();
                else resultArcSin = Math.Round(Math.Asin(evalue(tempArcSin) / 180 * Math.PI), 12).ToString();
                result = result.Substring(0, indexOfArcSin) + result.Substring(i);
                if (resultArcSin[0] == '-')
                {
                    result = result.Insert(indexOfArcSin, "(0" + resultArcSin + ")");
                }
                else result = result.Insert(indexOfArcSin, resultArcSin);
            }
            // tinh ham cos
            else if (!result.Contains("arccos(") && result.IndexOf("cos(") >= 0)
            {
                indexOfCos = result.IndexOf("cos(");
                int i = indexOfCos + 4;
                string tempCos = "";
                int check = 1;
                while (i < result.Length && check != 0)
                {
                    if (i < result.Length && result[i] == '(') check++;
                    if (i < result.Length && result[i] == ')') check--;
                    if (check != 0)
                        tempCos += result[i];
                    i++;
                }
                while (tempCos.IndexOf("√(") >= 0 || tempCos.IndexOf("ln(") >= 0 || tempCos.IndexOf("sin(") >= 0
                   || tempCos.IndexOf("cos(") >= 0 || tempCos.IndexOf("tan(") >= 0 || tempCos.IndexOf("log(") >= 0
                   || tempCos.IndexOf("³√(") >= 0 || tempCos.IndexOf("arcsin(") >= 0 || tempCos.IndexOf("arccos(") >= 0
                   || tempCos.IndexOf("arctan(") >= 0 || tempCos.IndexOf("^(") >= 0)
                {
                    tempCos = calcFunc(tempCos);
                }
                if (rdRadian.IsToggled)
                    resultCos = Math.Round(Math.Cos(evalue(tempCos)), 12).ToString();
                else resultCos = Math.Round(Math.Cos(evalue(tempCos) / 180 * Math.PI), 12).ToString();
                result = result.Substring(0, indexOfCos) + result.Substring(i);
                if (resultCos[0] == '-')
                {
                    result = result.Insert(indexOfCos, "(0" + resultCos + ")");
                }
                else result = result.Insert(indexOfCos, resultCos);
            }
            // tinh ham arccos
            else if (result.IndexOf("arccos(") >= 0)
            {
                indexOfArcCos = result.IndexOf("arccos(");
                int i = indexOfArcCos + 7;
                string tempArcCos = "";
                int check = 1;
                while (i < result.Length && check != 0)
                {
                    if (i < result.Length && result[i] == '(') check++;
                    if (i < result.Length && result[i] == ')') check--;
                    if (check != 0)
                        tempArcCos += result[i];
                    i++;
                }
                while (tempArcCos.IndexOf("√(") >= 0 || tempArcCos.IndexOf("ln(") >= 0 || tempArcCos.IndexOf("sin(") >= 0
                   || tempArcCos.IndexOf("cos(") >= 0 || tempArcCos.IndexOf("tan(") >= 0 || tempArcCos.IndexOf("log(") >= 0
                   || tempArcCos.IndexOf("³√(") >= 0 || tempArcCos.IndexOf("arcsin(") >= 0 || tempArcCos.IndexOf("arccos(") >= 0
                   || tempArcCos.IndexOf("arctan(") >= 0 || tempArcCos.IndexOf("^(") >= 0)
                {
                    tempArcCos = calcFunc(tempArcCos);
                }
                if (rdRadian.IsToggled)
                    resultArcCos = Math.Round(Math.Acos(evalue(tempArcCos)), 12).ToString();
                else resultArcCos = Math.Round(Math.Acos(evalue(tempArcCos) / 180 * Math.PI), 12).ToString();
                result = result.Substring(0, indexOfArcCos) + result.Substring(i);
                if (resultArcCos[0] == '-')
                {
                    result = result.Insert(indexOfArcCos, "(0" + resultArcCos + ")");
                }
                else result = result.Insert(indexOfArcCos, resultArcCos);
            }
            // tinh ham tan
            else if (!result.Contains("arctan(") && result.IndexOf("tan(") >= 0)
            {
                indexOfTan = result.IndexOf("tan(");
                int i = indexOfTan + 4;
                string tempTan = "";
                int check = 1;
                while (i < result.Length && check != 0)
                {
                    if (i < result.Length && result[i] == '(') check++;
                    if (i < result.Length && result[i] == ')') check--;
                    if (check != 0)
                        tempTan += result[i];
                    i++;
                }
                while (tempTan.IndexOf("√(") >= 0 || tempTan.IndexOf("ln(") >= 0 || tempTan.IndexOf("sin(") >= 0
                  || tempTan.IndexOf("cos(") >= 0 || tempTan.IndexOf("tan(") >= 0 || tempTan.IndexOf("log(") >= 0
                  || tempTan.IndexOf("³√(") >= 0 || tempTan.IndexOf("arcsin(") >= 0 || tempTan.IndexOf("arccos(") >= 0
                  || tempTan.IndexOf("arctan(") >= 0 || tempTan.IndexOf("^(") >= 0)
                {
                    tempTan = calcFunc(tempTan);
                }
                if (rdRadian.IsToggled)
                    resultTan = Math.Round(Math.Tan(evalue(tempTan)), 12).ToString();
                else resultTan = Math.Round(Math.Tan(evalue(tempTan) / 180 * Math.PI), 12).ToString();
                result = result.Substring(0, indexOfTan) + result.Substring(i);
                if (resultTan[0] == '-')
                {
                    result = result.Insert(indexOfTan, "(0" + resultTan + ")");
                }
                else result = result.Insert(indexOfTan, resultTan);
            }
            // tinh ham arctan
            else if (result.IndexOf("arctan(") >= 0)
            {
                indexOfArcTan = result.IndexOf("arctan(");
                int i = indexOfArcTan + 7;
                string tempArcTan = "";
                int check = 1;
                while (i < result.Length && check != 0)
                {
                    if (i < result.Length && result[i] == '(') check++;
                    if (i < result.Length && result[i] == ')') check--;
                    if (check != 0)
                        tempArcTan += result[i];
                    i++;
                }
                while (tempArcTan.IndexOf("√(") >= 0 || tempArcTan.IndexOf("ln(") >= 0 || tempArcTan.IndexOf("sin(") >= 0
                  || tempArcTan.IndexOf("cos(") >= 0 || tempArcTan.IndexOf("tan(") >= 0 || tempArcTan.IndexOf("log(") >= 0
                  || tempArcTan.IndexOf("³√(") >= 0 || tempArcTan.IndexOf("arcsin(") >= 0 || tempArcTan.IndexOf("arccos(") >= 0
                  || tempArcTan.IndexOf("arctan(") >= 0 || tempArcTan.IndexOf("^(") >= 0)
                {
                    tempArcTan = calcFunc(tempArcTan);
                }
                if (rdRadian.IsToggled)
                    resultArcTan = Math.Round(Math.Atan(evalue(tempArcTan)), 12).ToString();
                else resultArcTan = Math.Round(Math.Atan(evalue(tempArcTan) / 180 * Math.PI), 12).ToString();
                result = result.Substring(0, indexOfArcTan) + result.Substring(i);
                if (resultArcTan[0] == '-')
                {
                    result = result.Insert(indexOfArcTan, "(0" + resultArcTan + ")");
                }
                else result = result.Insert(indexOfArcTan, resultArcTan);
            }

            while (result.IndexOf("√(") >= 0 || result.IndexOf("ln(") >= 0 || result.IndexOf("sin(") >= 0
                  || result.IndexOf("cos(") >= 0 || result.IndexOf("tan(") >= 0 || result.IndexOf("log(") >= 0
                  || result.IndexOf("³√(") >= 0 || result.IndexOf("arcsin(") >= 0 || result.IndexOf("arccos(") >= 0
                  || result.IndexOf("arctan(") >= 0 || result.IndexOf("^(") >= 0)
                result = calcFunc(result);

            return result;
        }
        
        private void btnBang_Clicked(object sender, EventArgs e)
        {
            try
            {
                string bieuThucDonGian = replaceWith(lbBieuThuc.Text);
                string bieuThucKhongCoMu = axtractPow(bieuThucDonGian);
                string bieuThucKhongCoHam = calcFunc(bieuThucKhongCoMu);
                lbKetQua.Text = evalue(bieuThucKhongCoHam).ToString();
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