using org.matheval;
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
    public partial class DoiNhietDo : ContentPage
    {
        private Dictionary<string, Dictionary<string, string>> cnvLogicDict = new Dictionary<string, Dictionary<string, string>>();
        public DoiNhietDo()
        {
            InitializeComponent(); //°C
            var CLogic = new Dictionary<string, string>();
            CLogic.Add("°C", "");
            CLogic.Add("°F", "a * 1.8 + 32");
            CLogic.Add("°K", "a + 273.15");

            cnvLogicDict.Add("°C", CLogic);

            //°F
            var FLogic = new Dictionary<string, string>();
            FLogic.Add("°F", "");
            FLogic.Add("°C", "(a - 32) / 1.8");
            FLogic.Add("°K", "(a - 32) / 1.8 + 273.15");

            cnvLogicDict.Add("°F", FLogic);

            //°K
            var KLogic = new Dictionary<string, string>();
            KLogic.Add("°K", "");
            KLogic.Add("°C", "a - 273.15");
            KLogic.Add("°F", "(a - 273.15) * 1.8 + 32");

            cnvLogicDict.Add("°K", KLogic);

        }

        bool IsUnit1Focused = false, IsUnit2Focused = false;
        private void onText1Changed(object sender, TextChangedEventArgs e)
        {
            if (PFunc.SelectedIndex < 0 || P2Func.SelectedIndex < 0)
                return;

            if (txtA.Text == null || txtA.Text == string.Empty)
                return;

            if (!IsUnit1Focused)
                return;

            string unit1 = PFunc.Items[PFunc.SelectedIndex];
            string unit2 = P2Func.Items[P2Func.SelectedIndex];

            float value = float.Parse(txtA.Text);

            if (unit1 == unit2)
            {
                txtB.Text = (value).ToString();
                return;
            }

            var unitLogic = cnvLogicDict[unit1];
            Expression exp = new Expression(unitLogic[unit2]);
            exp.Bind("a", value);

            decimal result = exp.Eval<decimal>();

            txtB.Text = result.ToString();
        }
        private void onText2Changed(object sender, TextChangedEventArgs e)
        {
            if (PFunc.SelectedIndex < 0 || P2Func.SelectedIndex < 0)
                return;

            if (txtB.Text == null || txtB.Text == string.Empty)
                return;

            if (!IsUnit2Focused)
                return;

            string unit1 = PFunc.Items[PFunc.SelectedIndex];
            string unit2 = P2Func.Items[P2Func.SelectedIndex];

            float value = float.Parse(txtB.Text);

            if (unit1 == unit2)
            {
                txtA.Text = (value).ToString();
                return;
            }

            var unitLogic = cnvLogicDict[unit2];
            Expression exp = new Expression(unitLogic[unit1]);
            exp.Bind("a", value);

            decimal result = exp.Eval<decimal>();

            txtA.Text = result.ToString();
        }

        #region on Picker Changed
        private void onUnit1Changed(object sender, EventArgs e)
        {
            if (PFunc.SelectedIndex < 0 || P2Func.SelectedIndex < 0)
                return;

            if (txtA.Text == null || txtB.Text == null)
                return;

            if (!IsUnit1Focused)
                return;

            string unit1 = PFunc.Items[PFunc.SelectedIndex];
            string unit2 = P2Func.Items[P2Func.SelectedIndex];

            float value = float.Parse(txtA.Text);

            if (unit1 == unit2)
            {
                txtA.Text = txtB.Text;
                return;
            }

            var unitLogic = cnvLogicDict[unit1];
            Expression exp = new Expression(unitLogic[unit2]);
            exp.Bind("a", value);

            decimal result = exp.Eval<decimal>();

            txtB.Text = result.ToString();
        }

        private void onUnit2Changed(object sender, EventArgs e)
        {
            if (PFunc.SelectedIndex < 0 || P2Func.SelectedIndex < 0)
                return;

            if (txtA.Text == null || txtB.Text == null)
                return;

            if (!IsUnit2Focused)
                return;

            string unit1 = PFunc.Items[PFunc.SelectedIndex];
            string unit2 = P2Func.Items[P2Func.SelectedIndex];

            float value = float.Parse(txtB.Text);

            if (unit1 == unit2)
            {
                txtB.Text = txtA.Text;
                return;
            }

            var unitLogic = cnvLogicDict[unit2];
            Expression exp = new Expression(unitLogic[unit1]);
            exp.Bind("a", value);

            decimal result = exp.Eval<decimal>();

            txtA.Text = result.ToString();
        }
        #endregion

        #region on Unit Focused
        private void onUnit1Focused(object sender, FocusEventArgs e)
        {
            IsUnit1Focused = true;
            IsUnit2Focused = false;
        }

        private void onUnit2Focused(object sender, FocusEventArgs e)
        {
            IsUnit1Focused = false;
            IsUnit2Focused = true;
        }
        #endregion
        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new DoiDonVi();
        }

    }
}