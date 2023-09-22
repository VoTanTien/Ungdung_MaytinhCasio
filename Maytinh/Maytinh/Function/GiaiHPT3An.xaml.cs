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
    public partial class GiaiHPT3An : ContentPage
    {
        private XuLyData dataAccess;
        string a = "Hệ PT 3 ẨN";
        public GiaiHPT3An()
        {
            InitializeComponent();
            this.dataAccess = new XuLyData();
        }
        private void BtnLamMoi_Clicked(object sender, EventArgs e)
        {
            txtNhapA1.Text = "";
            txtNhapA2.Text = "";
            txtNhapB1.Text = "";
            txtNhapB2.Text = "";
            txtNhapC1.Text = "";
            txtNhapC2.Text = "";
            txtNhapD1.Text = "";
            txtNhapD2.Text = "";
            lbKetQuaX.Text = "";
            lbKetQuaY.Text = "";
            lbKetQuaZ.Text = "";
        }

        private void BtnTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                double a1 = double.Parse(txtNhapA1.Text);
                double b1 = double.Parse(txtNhapB1.Text);
                double c1 = double.Parse(txtNhapC1.Text);
                double d1 = double.Parse(txtNhapD1.Text);
                double a2 = double.Parse(txtNhapA2.Text);
                double b2 = double.Parse(txtNhapB2.Text);
                double c2 = double.Parse(txtNhapC2.Text);
                double d2 = double.Parse(txtNhapD2.Text);
                double a3 = double.Parse(txtNhapA3.Text);
                double b3 = double.Parse(txtNhapB3.Text);
                double c3 = double.Parse(txtNhapC3.Text);
                double d3 = double.Parse(txtNhapD3.Text);

                if (c1 * c1 + c2 * c2 == 0)
                {
                    double dx = d1 * b2 - d2 * b1;
                    double dy = a1 * d2 - a2 * d1;
                    double d = a1 * b2 - a2 * b1;
                    if (d == 0 & dx == 0 & dy == 0)
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if ((d == 0) & (dx * dx + dy * dy != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (d != 0)
                    {
                        double x = dx / d;
                        double y = dy / d;
                        if (c3 == 0)
                        {
                            if (a3 * x + b3 * y == d3)
                            {
                                lbKetQuaX.Text = " x = " + x.ToString();
                                lbKetQuaY.Text = " y = " + y.ToString();
                                lbKetQuaZ.Text = " z = R";
                            }
                            else
                            {
                                lbKetQuaX.Text = "Vô nghiệm";
                            }
                        }
                        else
                        {
                            double z = (d3 - a3 * x - b3 * y) / c3;
                            lbKetQuaX.Text = " x = " + x.ToString();
                            lbKetQuaY.Text = " y = " + y.ToString();
                            lbKetQuaZ.Text = " z = " + z.ToString();
                        }
                    }
                }
                else if (c1 * c1 + c3 * c3 == 0)
                {
                    double dx = d1 * b3 - d3 * b1;
                    double dy = a1 * d3 - a3 * d1;
                    double d = a1 * b3 - a3 * b1;
                    if (d == 0 & dx == 0 & dy == 0)
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if ((d == 0) & (dx * dx + dy * dy != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (d != 0)
                    {
                        double x = dx / d;
                        double y = dy / d;
                        if (c2 == 0)
                        {
                            if (a2 * x + b2 * y == d2)
                            {
                                lbKetQuaX.Text = " x = " + x.ToString();
                                lbKetQuaY.Text = " y = " + y.ToString();
                                lbKetQuaZ.Text = " z = R ";
                            }
                            else
                            {
                                lbKetQuaX.Text = "Vô nghiệm";
                            }
                        }
                        else
                        {
                            double z = (d2 - a2 * x - b2 * y) / c2;
                            lbKetQuaX.Text = " x = " + x.ToString();
                            lbKetQuaY.Text = " y = " + y.ToString();
                            lbKetQuaZ.Text = " z = " + z.ToString();
                        }
                    }
                }
                else if (c2 * c2 + c3 * c3 == 0)
                {
                    double dx = d2 * b3 - d3 * b2;
                    double dy = a2 * d3 - a3 * d2;
                    double d = a2 * b3 - a3 * b2;
                    if (d == 0 & dx == 0 & dy == 0)
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if ((d == 0) & (dx * dx + dy * dy != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (d != 0)
                    {
                        double x = dx / d;
                        double y = dy / d;
                        if (c1 == 0)
                        {
                            if (a1 * x + b1 * y == d1)
                            {
                                lbKetQuaX.Text = " x = " + x.ToString();
                                lbKetQuaY.Text = " y = " + y.ToString();
                                lbKetQuaZ.Text = " z = R ";
                            }
                            else
                            {
                                lbKetQuaX.Text = "Vô nghiệm";
                            }
                        }
                        else
                        {
                            double z = (d1 - a1 * x - b1 * y) / c1;
                            lbKetQuaX.Text = " x = " + x.ToString();
                            lbKetQuaY.Text = " y = " + y.ToString();
                            lbKetQuaZ.Text = " z = " + z.ToString();
                        }
                    }
                }
                else if (b1 * b1 + b2 * b2 == 0)
                {
                    double dx = d1 * c2 - d2 * c1;
                    double dz = a1 * d2 - a2 * d1;
                    double d = a1 * c2 - a2 * c1;
                    if (d == 0 & dx == 0 & dz == 0)
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if ((d == 0) & (dx * dx + dz * dz != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (d != 0)
                    {
                        double x = dx / d;
                        double z = dz / d;
                        if (b3 == 0)
                        {
                            if (a3 * x + c3 * z == d3)
                            {
                                lbKetQuaX.Text = " x = " + x.ToString();
                                lbKetQuaY.Text = " y = R ";
                                lbKetQuaZ.Text = " z = " + z.ToString();
                            }
                            else
                            {
                                lbKetQuaX.Text = "Vô nghiệm";
                            }
                        }
                        else
                        {
                            double y = (d3 - a3 * x - c3 * z) / b3;
                            lbKetQuaX.Text = " x = " + x.ToString();
                            lbKetQuaY.Text = " y = " + y.ToString();
                            lbKetQuaZ.Text = " z = " + z.ToString();
                        }
                    }
                }
                else if (b1 * b1 + b3 * b3 == 0)
                {
                    double dx = d1 * c3 - d3 * c1;
                    double dz = a1 * d3 - a3 * d1;
                    double d = a1 * c3 - a3 * c1;
                    if (d == 0 & dx == 0 & dz == 0)
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if ((d == 0) & (dx * dx + dz * dz != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (d != 0)
                    {
                        double x = dx / d;
                        double z = dz / d;
                        if (b2 == 0)
                        {
                            if (a2 * x + c2 * z == d2)
                            {
                                lbKetQuaX.Text = " x = " + x.ToString();
                                lbKetQuaY.Text = " y = R ";
                                lbKetQuaZ.Text = " z = " + z.ToString();
                            }
                            else
                            {
                                lbKetQuaX.Text = "Vô nghiệm";
                            }
                        }
                        else
                        {
                            double y = (d2 - a2 * x - c2 * z) / b2;
                            lbKetQuaX.Text = " x = " + x.ToString();
                            lbKetQuaY.Text = " y = " + y.ToString();
                            lbKetQuaZ.Text = " z = " + z.ToString();
                        }
                    }
                }
                else if (b2 * b2 + b3 * b3 == 0)
                {
                    double dx = d2 * c3 - d3 * c3;
                    double dz = a2 * d3 - a3 * d2;
                    double d = a2 * c3 - a3 * c2;
                    if (d == 0 & dx == 0 & dz == 0)
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if ((d == 0) & (dx * dx + dz * dz != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (d != 0)
                    {
                        double x = dx / d;
                        double z = dz / d;
                        if (b1 == 0)
                        {
                            if (a1 * x + c1 * z == d1)
                            {
                                lbKetQuaX.Text = " x = " + x.ToString();
                                lbKetQuaY.Text = " y = R ";
                                lbKetQuaZ.Text = " z = " + z.ToString();
                            }
                            else
                            {
                                lbKetQuaX.Text = "Vô nghiệm";
                            }
                        }
                        else
                        {
                            double y = (d1 - a1 * x - c1 * z) / b1;
                            lbKetQuaX.Text = " x = " + x.ToString();
                            lbKetQuaY.Text = " y = " + y.ToString();
                            lbKetQuaZ.Text = " z = " + z.ToString();
                        }
                    }
                }
                else if (a1 * a1 + a2 * a2 == 0)
                {
                    double dy = d1 * c2 - d2 * c1;
                    double dz = b1 * d2 - b2 * d1;
                    double d = b1 * c2 - b2 * c1;
                    if (d == 0 & dy == 0 & dz == 0)
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if ((d == 0) & (dy * dy + dz * dz != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (d != 0)
                    {
                        double y = dy / d;
                        double z = dz / d;
                        if (a3 == 0)
                        {
                            if (b3 * y + c3 * z == d3)
                            {
                                lbKetQuaX.Text = " x = R ";
                                lbKetQuaY.Text = " y = " + y.ToString();
                                lbKetQuaZ.Text = " z = " + z.ToString();
                            }
                            else
                            {
                                lbKetQuaX.Text = "Vô nghiệm";
                            }
                        }
                        else
                        {
                            double x = (d3 - b3 * y - c3 * z) / a3;
                            lbKetQuaX.Text = " x = " + x.ToString();
                            lbKetQuaY.Text = " y = " + y.ToString();
                            lbKetQuaZ.Text = " z = " + z.ToString();
                        }
                    }
                }
                else if (a1 * a1 + a3 * a3 == 0)
                {
                    double dy = d1 * c3 - d3 * c1;
                    double dz = b1 * d3 - b3 * d1;
                    double d = b1 * c3 - b3 * c1;
                    if (d == 0 & dy == 0 & dz == 0)
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if ((d == 0) & (dy * dy + dz * dz != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (d != 0)
                    {
                        double y = dy / d;
                        double z = dz / d;
                        if (a2 == 0)
                        {
                            if (b2 * y + c2 * z == d2)
                            {
                                lbKetQuaX.Text = " x = R ";
                                lbKetQuaY.Text = " y = " + y.ToString();
                                lbKetQuaZ.Text = " z = " + z.ToString();
                            }
                            else
                            {
                                lbKetQuaX.Text = "Vô nghiệm";
                            }
                        }
                        else
                        {
                            double x = (d2 - b2 * y - c2 * z) / a2;
                            lbKetQuaX.Text = " x = " + x.ToString();
                            lbKetQuaY.Text = " y = " + y.ToString();
                            lbKetQuaZ.Text = " z = " + z.ToString();
                        }
                    }
                }
                else if (a2 * a2 + a3 * a3 == 0)
                {
                    double dy = d2 * c3 - d3 * c2;
                    double dz = b2 * d3 - b3 * d2;
                    double d = b2 * c3 - b3 * c2;
                    if (d == 0 & dy == 0 & dz == 0)
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if ((d == 0) & (dy * dy + dz * dz != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (d != 0)
                    {
                        double y = dy / d;
                        double z = dz / d;
                        if (a1 == 0)
                        {
                            if (b1 * y + c1 * z == d1)
                            {
                                lbKetQuaX.Text = " x = R ";
                                lbKetQuaY.Text = " y = " + y.ToString();
                                lbKetQuaZ.Text = " z = " + z.ToString();
                            }
                            else
                            {
                                lbKetQuaX.Text = "Vô nghiệm";
                            }
                        }
                        else
                        {
                            double x = (d1 - b1 * y - c1 * z) / a1;
                            lbKetQuaX.Text = " x = " + x.ToString();
                            lbKetQuaY.Text = " y = " + y.ToString();
                            lbKetQuaZ.Text = " z = " + z.ToString();
                        }
                    }
                }
                else if (c1 == 0)
                {
                    double a = a2 * c3 - a3 * c2;
                    double b = b2 * c3 - b3 * c2;
                    double d = d2 * c3 - d3 * c2;
                    double dx = d * b1 - b * d1;
                    double dy = a * d1 - a1 * d;
                    double D = a * b1 - a1 * b;
                    if (D == 0 & (dx * dx + dy * dy == 0))
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if (D == 0 & (dx * dx + dy * dy != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (D != 0)
                    {
                        double x = dx / D;
                        double y = dy / D;
                        double z = (d2 - a2 * x - b2 * y) / c2;
                        lbKetQuaX.Text = " x = " + x.ToString();
                        lbKetQuaY.Text = " y = " + y.ToString();
                        lbKetQuaZ.Text = " z = " + z.ToString();
                    }
                }
                else if (c2 == 0)
                {
                    double a = a1 * c3 - a3 * c1;
                    double b = b1 * c3 - b3 * c1;
                    double d = d1 * c3 - d3 * c1;
                    double dx = d * b2 - b * d2;
                    double dy = a * d2 - a2 * d;
                    double D = a * b2 - a2 * b;
                    if (D == 0 & (dx * dx + dy * dy == 0))
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if (D == 0 & (dx * dx + dy * dy != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (D != 0)
                    {
                        double x = dx / D;
                        double y = dy / D;
                        double z = (d1 - a1 * x - b1 * y) / c1;
                        lbKetQuaX.Text = " x = " + x.ToString();
                        lbKetQuaY.Text = " y = " + y.ToString();
                        lbKetQuaZ.Text = " z = " + z.ToString();
                    }
                }
                else if (c3 == 0)
                {
                    double a = a1 * c2 - a2 * c1;
                    double b = b1 * c2 - b2 * c1;
                    double d = d1 * c2 - d2 * c1;
                    double dx = d * b3 - b * d3;
                    double dy = a * d3 - a3 * d;
                    double D = a * b3 - a3 * b;
                    if (D == 0 & (dx * dx + dy * dy == 0))
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if (D == 0 & (dx * dx + dy * dy != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (D != 0)
                    {
                        double x = dx / D;
                        double y = dy / D;
                        double z = (d1 - a1 * x - b1 * y) / c1;
                        lbKetQuaX.Text = " x = " + x.ToString();
                        lbKetQuaY.Text = " y = " + y.ToString();
                        lbKetQuaZ.Text = " z = " + z.ToString();
                    }
                }
                else if (c1 != 0 & c2 != 0 & c3 != 0)
                {
                    double a = a1 * c2 - a2 * c1;
                    double b = b1 * c2 - b2 * c1;
                    double d = d1 * c2 - d2 * c1;
                    double aa = a2 * c3 - a3 * c2;
                    double bb = b2 * c3 - b3 * c2;
                    double dd = d2 * c3 - d3 * c2;
                    double dx = d * bb - b * dd;
                    double dy = a * dd - d * aa;
                    double D = a * bb - b * aa;
                    if (D == 0 & (dx * dx + dy * dy == 0))
                    {
                        lbKetQuaX.Text = "Vô số nghiệm";
                    }
                    else if (D == 0 & (dx * dx + dy * dy != 0))
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                    else if (D != 0)
                    {
                        double x = dx / D;
                        double y = dy / D;
                        double z = (d1 - a1 * x - b1 * y) / c1;
                        lbKetQuaX.Text = " x = " + x.ToString();
                        lbKetQuaY.Text = " y = " + y.ToString();
                        lbKetQuaZ.Text = " z = " + z.ToString();
                    }
                }
            }
            catch
            {
                lbKetQuaX.Text = "Lỗi biểu thức";
            }
            string p = lbKetQuaX.Text + " " + lbKetQuaY.Text + "" + lbKetQuaZ;
            this.dataAccess.AddLS(DateTime.Now.ToString(), a, p);
        }

        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ChucNang();
        }
    }
}