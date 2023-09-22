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
    public partial class DoiTrongLuong : ContentPage
    {
        private Dictionary<string, Dictionary<string, double>> cnvLogicDict = new Dictionary<string, Dictionary<string, double>>();
        public DoiTrongLuong()
        {
            InitializeComponent();
            // g
            var gLogic = new Dictionary<string, double>();
            gLogic.Add("g", 0);
            gLogic.Add("kg", -1000);
            gLogic.Add("lb", -453.59237);

            cnvLogicDict.Add("g", gLogic);

            // kg
            var kgLogic = new Dictionary<string, double>();
            kgLogic.Add("g", 1000);
            kgLogic.Add("kg", 0);
            kgLogic.Add("lb", -0.45359237);

            cnvLogicDict.Add("kg", kgLogic);

            // lb
            var lbLogic = new Dictionary<string, double>();
            lbLogic.Add("g", 453.59237);
            lbLogic.Add("kg", 0.45359237);
            lbLogic.Add("lb", 0);

            cnvLogicDict.Add("lb", lbLogic);
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
            double unitAlg = unitLogic[unit2];

            txtB.Text = ((unitAlg > 0) ? value * unitAlg : value / Math.Abs(unitAlg)).ToString();
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
            double unitAlg = unitLogic[unit1];

            txtA.Text = ((unitAlg > 0) ? value * unitAlg : value / Math.Abs(unitAlg)).ToString();
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
            double unitAlg = unitLogic[unit2];

            txtB.Text = ((unitAlg > 0) ? value * unitAlg : value / Math.Abs(unitAlg)).ToString();
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
            double unitAlg = unitLogic[unit1];

            txtA.Text = ((unitAlg > 0) ? value * unitAlg : value / Math.Abs(unitAlg)).ToString();
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