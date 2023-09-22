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
    public partial class GiaiPTBac3 : ContentPage
    {
        private XuLyData dataAccess;
        string a = "PT Bậc 3";
        public GiaiPTBac3()
        {
            InitializeComponent();
            this.dataAccess = new XuLyData();
        }
        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage= new ChucNang();
        }

        private void BtnTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dblGiaTriA = double.Parse(txtA.Text);
                double dblGiaTriB = double.Parse(txtB.Text);
                double dblGiaTriC = double.Parse(txtC.Text);
                double dblGiaTriD = double.Parse(txtD.Text);
                double dblGiaTriX1, dblGiaTriX2, dblGiaTriX3;
                if (dblGiaTriA == 0)
                {
                    if (dblGiaTriB == 0)
                    {
                        if (dblGiaTriC == 0)
                        {
                            if (dblGiaTriD == 0)
                            {
                                lbKetQua1.Text = "Vô số nghiệm";
                            }
                            else if (dblGiaTriD != 0)
                            {
                                lbKetQua1.Text = "Vô nghiệm";
                            }
                        }
                        else if (dblGiaTriC != 0)
                        {
                            double fNghiem = -dblGiaTriD / dblGiaTriC;
                            lbKetQua1.Text = "x = " + fNghiem.ToString();
                        }
                    }
                    else if (dblGiaTriB != 0)
                    {
                        double fD = dblGiaTriC * dblGiaTriC - 4 * dblGiaTriB * dblGiaTriD;
                        if (fD < 0)
                        {
                            lbKetQua1.Text = "Phương trình vô nghiệm";
                        }
                        else if (fD == 0)
                        {
                            double fNghiem = -dblGiaTriC / (2 * dblGiaTriB);
                            lbKetQua1.Text = "x1 = x2 = " + fNghiem.ToString();
                        }
                        else
                        {
                            double fNghiem1 = (-dblGiaTriC + Math.Sqrt(fD)) / (2 * dblGiaTriB);
                            double fNghiem2 = (-dblGiaTriC - Math.Sqrt(fD)) / (2 * dblGiaTriB);
                            lbKetQua1.Text = "x1 = " + fNghiem1.ToString();
                            lbKetQua2.Text = "x2 = " + fNghiem2.ToString();
                        }
                    }
                }
                else
                {

                    // Tìm biến số f
                    // f = [(3c/a) - (b²/a²)] / 3
                    double dblF = (((3 * dblGiaTriC) / dblGiaTriA) - ((dblGiaTriB * dblGiaTriB) / (dblGiaTriA * dblGiaTriA))) / 3;

                    // Tìm biến số g
                    // g = [(2b³/a³) - (9bc/a²) + (27d/a)] / 27
                    double dblG = (((2 * dblGiaTriB * dblGiaTriB * dblGiaTriB) / (dblGiaTriA * dblGiaTriA * dblGiaTriA)) - ((9 * dblGiaTriB * dblGiaTriC) / (dblGiaTriA * dblGiaTriA)) + ((27 * dblGiaTriD) / dblGiaTriA)) / 27;

                    // Tìm biến số h
                    // h = (g²/4) + (f³/27)
                    double dblH = ((dblG * dblG) / 4) + ((dblF * dblF * dblF) / 27);


                    // Nếu h > 0, phương trình chỉ có duy nhất 1 nghiệm thực
                    if (dblH > 0)
                    {
                        // Tìm giá trị R
                        // R = -(g/2) + (h)½
                        double dblHMu1Phan2 = Math.Sqrt(dblH);
                        double dblR = -(dblG / 2) + dblHMu1Phan2;

                        // Vì không thể tính được Căn Bậc 3 của một số âm nên chúng ta sẽ sử dụng giá trị e
                        double dblE = 1;
                        if (dblR < 0)
                        {
                            dblE = -1;
                        }
                        else
                        {
                            dblE = 1;
                        }
                        double dblRMu1Phan3 = Math.Pow(dblR * dblE, 0.33333333333333333333333333333333);
                        dblRMu1Phan3 = dblRMu1Phan3 * dblE;

                        // Tìm giá trị S
                        // S = (R)^(1/3)
                        double dblS = dblRMu1Phan3;

                        // Tìm giá trị T
                        // T = -(g/2) - (h)½
                        double dblT = -(dblG / 2) - dblHMu1Phan2;
                        if (dblT < 0)
                        {
                            dblE = -1;
                        }
                        else
                        {
                            dblE = 1;
                        }
                        double dblTMu1Phan3 = Math.Pow(dblT * dblE, 0.33333333333333333333333333333333);
                        dblTMu1Phan3 = dblTMu1Phan3 * dblE;

                        // Tìm giá trị U
                        // U = (T)^(1/3)
                        double dblU = dblTMu1Phan3;


                        // Tính giá trị X1
                        // X1 = (S + U) - (b/3a)
                        dblGiaTriX1 = (dblS + dblU) - (dblGiaTriB / (3 * dblGiaTriA));
                        dblGiaTriX1 = Math.Round(dblGiaTriX1, 8);

                        // Tính giá trị X2
                        // X2 = -(S + U)/2 - (b/3a) + i*(S-U)*(3)½/2
                        double dbl3Mu1Phan2 = Math.Pow(3, 0.5);
                        double dblVeTraiX2 = -(dblS + dblU) / 2 - (dblGiaTriB / (3 * dblGiaTriA));
                        double dblVePhaiX2 = ((dblS - dblU) * dbl3Mu1Phan2) / 2;


                        // Tính giá trị X3
                        // X3 = -(S + U)/2 - (b/3a) - i*(S-U)*(3)½/2
                        double dblVeTraiX3 = -(dblS + dblU) / 2 - (dblGiaTriB / (3 * dblGiaTriA));
                        double dblVePhaiX3 = ((dblS - dblU) * dbl3Mu1Phan2) / 2;


                        // Hiển thị giá trị các nghiệm
                        lbKetQua1.Text = "x1 = " + dblGiaTriX1.ToString();
                        lbKetQua2.Text = "x2 = " + dblVeTraiX2.ToString() + " + " + dblVePhaiX2.ToString() + "*i";
                        lbKetQua3.Text = "x3 = " + dblVeTraiX3.ToString() + " - " + dblVePhaiX3.ToString() + "*i";

                    }



                    // Trong trường hợp đặc biệt khi mà f = 0, g = 0 và h = 0 thì tất cả 3 nghiệm là thực và bằng nhau
                    // X1 = X2 = X3= (d/a)^(1/3) * (-1)
                    else if (dblF == 0 && dblG == 0 && dblH == 0)
                    {
                        //double dblS = 1;
                        double dblDTrenAMu1Phan3 = 0;
                        double dblDTrenA = dblGiaTriD / dblGiaTriA;
                        dblDTrenAMu1Phan3 = Math.Pow(Math.Abs(dblDTrenA), 0.33333333333333333333333333333333);
                        if (dblDTrenA < 0)
                        {
                            dblDTrenAMu1Phan3 = dblDTrenAMu1Phan3 * 1;
                        }
                        if (dblDTrenA > 0)
                        {
                            dblDTrenAMu1Phan3 = dblDTrenAMu1Phan3 * (-1);
                        }



                        // Tính giá trị X1
                        dblGiaTriX1 = Math.Round(dblDTrenAMu1Phan3, 8);

                        // Tính giá trị X2
                        dblGiaTriX2 = Math.Round(dblDTrenAMu1Phan3, 8);

                        // Tính giá trị X3
                        dblGiaTriX3 = Math.Round(dblDTrenAMu1Phan3, 8);

                        // Hiển thị giá trị các nghiệm
                        lbKetQua1.Text = "x1 = x2 = x3 = " + dblGiaTriX1.ToString();
                    }




                    // Khi h <= 0, thì tất cả 3 nghiệm là thực
                    else if (dblH <= 0)
                    {
                        // Tìm biến số i
                        // i = ((g²/4) - h) ½ 
                        double dblS = 1;
                        double dblBieuThuc = (dblG * dblG) / 4 - dblH;
                        double dblI = Math.Pow(dblBieuThuc, 0.5);
                        if (dblI < 0)
                        {
                            dblS = -1;
                        }
                        if (dblI > 0)
                        {
                            dblS = 1;
                        }
                        dblI = Math.Pow(dblBieuThuc * dblS, 0.5);
                        dblI = dblI * dblS;



                        // Tìm biến số j
                        // j = (i)^(1/3)
                        double dblJ = Math.Pow(dblI, 0.33333333333333333333333333333333);
                        if (dblJ < 0)
                        {
                            dblS = -1;
                        }
                        if (dblJ > 0)
                        {
                            dblS = 1;
                        }
                        dblJ = Math.Pow(dblI * dblS, 0.33333333333333333333333333333333);
                        dblJ = dblJ * dblS;

                        // Tìm biến số k
                        // k = arc cosine (- (g / 2i)) 
                        double dblGTren2i = -(dblG / (2 * dblI));
                        double dblK = Math.Acos(dblGTren2i);

                        // Tìm giá trị của L
                        // L = j * (-1)
                        double dblL = dblJ * (-1);

                        // Tìm giá trị của M
                        // M = cosine (K/3)
                        double dblKTren3 = dblK / 3;
                        double dblM = Math.Cos(dblKTren3);


                        // Tìm giá trị của N
                        // N = (Căn bậc 2 của 3) * sine (K/3)
                        double dblCanBac2Cua3 = Math.Sqrt(3);
                        double dblSinCuaKTren3 = Math.Sin(dblKTren3);
                        double dblN = dblCanBac2Cua3 * dblSinCuaKTren3;


                        // Tìm giá trị của P
                        // P = (b/3a) * (-1)
                        double dblP = (dblGiaTriB / (3 * dblGiaTriA)) * (-1);

                        // Tính giá trị X1
                        // X1 = 2j * cosine(k/3) - (b/3a)
                        double dblCosinCuaKTren3 = Math.Cos(dblKTren3);
                        double dblX1 = 2 * dblJ * dblCosinCuaKTren3 - (dblGiaTriB / (3 * dblGiaTriA));
                        dblGiaTriX1 = Math.Round(dblX1, 8);

                        // Tính giá trị X2
                        // X2 = L * (M + N) + P
                        dblGiaTriX2 = (dblL * (dblM + dblN)) + dblP;
                        dblGiaTriX2 = Math.Round(dblGiaTriX2, 8);

                        // Tính giá trị X3
                        // X3 = L * (M - N) + P
                        dblGiaTriX3 = (dblL * (dblM - dblN)) + dblP;
                        dblGiaTriX3 = Math.Round(dblGiaTriX3, 8);

                        // Hiển thị giá trị các nghiệm
                        lbKetQua1.Text = "x1 = " + dblGiaTriX1.ToString();
                        lbKetQua2.Text = "x2 = " + dblGiaTriX2.ToString();
                        lbKetQua3.Text = "x3 = " + dblGiaTriX3.ToString();

                    }
                }
            }
            catch
            {
                lbKetQua1.Text = "Lỗi biểu thức";
            }
            string p = lbKetQua1.Text;
            this.dataAccess.AddLS(DateTime.Now.ToString(), a, p);
        }

        private void BtnLamMoi_Clicked(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            lbKetQua1.Text = "";
            lbKetQua2.Text = "";
            lbKetQua3.Text = "";
        }
    }
}