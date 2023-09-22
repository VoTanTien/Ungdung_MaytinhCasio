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
    public partial class KhoangCach : ContentPage
    {
        private Dictionary<string, Dictionary<string, double>> cnvLogicDict = new Dictionary<string, Dictionary<string, double>>();
        public KhoangCach()
        {
            InitializeComponent();
            // mm
            var mmLogic = new Dictionary<string, double>();
            mmLogic.Add("mm", 0);
            mmLogic.Add("cm", -10);
            mmLogic.Add("m", -10000);
            mmLogic.Add("km", -1000000);
            mmLogic.Add("inch", 0.0393700787);

            cnvLogicDict.Add("mm", mmLogic);

            // cm
            var cmLogic = new Dictionary<string, double>();
            cmLogic.Add("mm", 10);
            cmLogic.Add("cm", 0);
            cmLogic.Add("m", -100);
            cmLogic.Add("km", -100000);
            cmLogic.Add("inch", 0.393700787);

            cnvLogicDict.Add("cm", cmLogic);

            // m
            var mLogic = new Dictionary<string, double>();
            mLogic.Add("mm", 1000);
            mLogic.Add("cm", 100);
            mLogic.Add("m", 0);
            mLogic.Add("km", -1000);
            mLogic.Add("inch", 39.3700787);

            cnvLogicDict.Add("m", mLogic);

            // km
            var kmLogic = new Dictionary<string, double>();
            kmLogic.Add("mm", 1000000);
            kmLogic.Add("cm", 100000);
            kmLogic.Add("m", 1000);
            kmLogic.Add("km", 0);
            kmLogic.Add("inch", 39370.0787);

            cnvLogicDict.Add("km", kmLogic);

            // inch
            var inchLogic = new Dictionary<string, double>();
            inchLogic.Add("mm", -0.0393700787);
            inchLogic.Add("cm", -0.393700787);
            inchLogic.Add("m", -39.3700787);
            inchLogic.Add("km", -39370.0787);
            inchLogic.Add("inch", 0);

            cnvLogicDict.Add("inch", inchLogic);
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

            txtB.Text = Math.Round(((unitAlg > 0) ? value * unitAlg : value / Math.Abs(unitAlg)), 5).ToString();
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