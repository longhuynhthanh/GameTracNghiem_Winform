using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] DanhSachCauHoi = new string[,] {
            {"Long có đẹp trai không?", "Rất đẹp trai", "Quá đẹp trai", "Chuẩn quá anh ơi", "Siêu Đẹp"},
            {"1 + 1 = ?", "2", "3", "4", "5"},
            {"Bạn có thấy mình giống chó không?", "Không", "Có", "Quá Giống", "Rất Giống"},
            {"Bạn làm gì khi vào nhà tắm?", "Đi ỉa", "Đi Đái", "Quay Tay", "Làm Việc Khác" },
            {"Nói Thiệt đi bạn đã xem phim con heo lần nào chưa?", "Mình còn nhỏ chưa xem bao giờ", "Mình thanh niên cứng", "Thằng nào chả xem", "Phim con heo là gì?" },
                                              };
        string[] DapAn = new string[] { "Quá đẹp trai", "3", "Quá Giống", "Quay Tay", "Mình còn nhỏ chưa xem bao giờ" };
        string[] DapAnNguoiChoiChon;
        int cauhoi;
        RadioButton[] DanhSachCacRadioButton;
        PictureBox ptr;
        Random rd;
        ToolTip tl;
        int giay = 0, phut = 0;
        bool KiemTraDaTraLoiCauHoi = false;
        DialogResult traloi;
        DialogResult ThongBaohetGio;
        bool KiemTraThongBaoHetGio = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            // start đồng hồ đếm thời gian làm cả 5 câu trắc nghiệm.
            tmThoiGian.Start();
            // start đồng hồ giới hạn thời gian làm một câu
            tmDem.Start();



            tl = new ToolTip();
            rd = new Random();
            ptr = new PictureBox();
            ptr.SizeMode = PictureBoxSizeMode.StretchImage;
            ptr.Size = new Size(767, 552);
            this.Controls.Add(ptr);
            ptr.Click += Ptr_Click;
            ptr.Visible = false;

            cauhoi = 1;
            LoadCauHoi(cauhoi);
            DapAnNguoiChoiChon = new string[DanhSachCauHoi.GetLength(0)];
            //Tạo tự động các radio button câu hỏi đã trả lời, khi click trả lời đúng câu hỏi thì sẽ hiện ra và 
            //click vào sẽ xem lại được câu đã trả lời
            DanhSachCacRadioButton = new RadioButton[DanhSachCauHoi.GetLength(0)];
            for (int i = 0; i < DanhSachCacRadioButton.Count(); ++i)
            {
                DanhSachCacRadioButton[i] = new RadioButton();
                DanhSachCacRadioButton[i].Location = new Point(gbCauHoi.Location.X + gbCauHoi.Size.Width + 20, gbCauHoi.Location.Y + 30 * i);
                DanhSachCacRadioButton[i].Text = "Câu Hỏi " + (i + 1);
                DanhSachCacRadioButton[i].Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                DanhSachCacRadioButton[i].AutoSize = true;
                DanhSachCacRadioButton[i].Enabled = false;
                DanhSachCacRadioButton[i].Tag = i + 1;
                this.Controls.Add(DanhSachCacRadioButton[i]);
                DanhSachCacRadioButton[i].CheckedChanged += DanhSachCacRadioButton_CheckedChanged;
            }


            foreach (Control c in this.gbDapAn.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    rd.CheckedChanged += KiemTraDapAn_CheckedChanged;
                }
            }
            foreach (Control c in this.gbDapAn.Controls)
            {
                if (c is TextBox)
                {
                    c.Click += KiemTraDapAn_Click;
                }
            }
        }
        private void DanhSachCacRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            if (rd.Checked)
            {
                LoadCauHoi((int)rd.Tag);

                // Load đáp án đúng
                if (cauhoi < (int)rd.Tag || this.gbDapAn.Enabled == false)
                {
                    if (txtA.Text == DapAn[(int)rd.Tag - 1])
                    {
                        txtA.BackColor = Color.Red;
                        txtA.ForeColor = Color.White;
                    }
                    else if (txtB.Text == DapAn[(int)rd.Tag - 1])
                    {
                        txtB.BackColor = Color.Red;
                        txtB.ForeColor = Color.White;
                    }
                    else if (txtC.Text == DapAn[(int)rd.Tag - 1])
                    {
                        txtC.BackColor = Color.Red;
                        txtC.ForeColor = Color.White;
                    }
                    else if (txtD.Text == DapAn[(int)rd.Tag - 1])
                    {
                        txtD.BackColor = Color.Red;
                        txtD.ForeColor = Color.White;
                    }
                }

                // Load đáp án của người chơi chọn
                if (txtA.Text == DapAnNguoiChoiChon[(int)rd.Tag - 1])
                {
                    txtA.BackColor = Color.Blue;
                    txtA.ForeColor = Color.White;
                }
                else if (txtB.Text == DapAnNguoiChoiChon[(int)rd.Tag - 1])
                {
                    txtB.BackColor = Color.Blue;
                    txtB.ForeColor = Color.White;
                }
                else if (txtC.Text == DapAnNguoiChoiChon[(int)rd.Tag - 1])
                {
                    txtC.BackColor = Color.Blue;
                    txtC.ForeColor = Color.White;
                }
                else if (txtD.Text == DapAnNguoiChoiChon[(int)rd.Tag - 1])
                {
                    txtD.BackColor = Color.Blue;
                    txtD.ForeColor = Color.White;
                }
                this.gbDapAn.Enabled = false;
                if (rd.Checked == DanhSachCacRadioButton[cauhoi - 1].Checked)
                {
                    this.gbDapAn.Enabled = true;
                }
            }
        }

        private void LoadCauHoi(int cauhoi)
        {
            //KiemTraDaTraLoiCauHoi = false;

            this.gbDapAn.Enabled = true;
            txtA.BackColor = txtB.BackColor = txtC.BackColor = txtD.BackColor = Color.White;
            txtA.ForeColor = txtB.ForeColor = txtC.ForeColor = txtD.ForeColor = Color.Black;

            // Reset lại các radio button
            rdbA.Checked = rdbB.Checked = rdbC.Checked = rdbD.Checked = false;
            //foreach (Control c in this.Controls)
            //{
            //    if (c is RadioButton)
            //    {
            //        RadioButton rd = (RadioButton)c;
            //        rd.Checked = false;
            //    }
            //}

            // Hiện lại radio button câu hỏi đã trả lời đúng
            if (cauhoi >= 2)
            {
                DanhSachCacRadioButton[cauhoi - 2].Enabled = true;
                DanhSachCacRadioButton[cauhoi - 1].Enabled = true;

                DanhSachCacRadioButton[cauhoi - 1].Checked = true;
            }
            txtCauHoi.Text = DanhSachCauHoi[cauhoi - 1, 0];
            txtA.Text = DanhSachCauHoi[cauhoi - 1, 1];
            txtB.Text = DanhSachCauHoi[cauhoi - 1, 2];
            txtC.Text = DanhSachCauHoi[cauhoi - 1, 3];
            txtD.Text = DanhSachCauHoi[cauhoi - 1, 4];
        }

        private void KiemTraDapAn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            if (rd.Checked)
            {
                txtA.BackColor = txtB.BackColor = txtC.BackColor = txtD.BackColor = Color.White;
                txtA.ForeColor = txtB.ForeColor = txtC.ForeColor = txtD.ForeColor = Color.Black;
                string s = "";
                if (rdbA.Checked)
                {
                    txtA.BackColor = Color.Blue;
                    txtA.ForeColor = Color.White;
                    s = txtA.Text;
                }
                else if (rdbB.Checked)
                {
                    txtB.BackColor = Color.Blue;
                    txtB.ForeColor = Color.White;
                    s = txtB.Text;
                }
                else if (rdbC.Checked)
                {
                    txtC.BackColor = Color.Blue;
                    txtC.ForeColor = Color.White;
                    s = txtC.Text;
                }
                else if (rdbD.Checked)
                {
                    txtD.BackColor = Color.Blue;
                    txtD.ForeColor = Color.White;
                    s = txtD.Text;
                }
                DapAnNguoiChoiChon[cauhoi - 1] = s;
                traloi = MessageBox.Show("Bạn có chắc chắn đây là Đáp Án cuối cùng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    KiemTraDaTraLoiCauHoi = true;
                    if (s == DapAn[cauhoi - 1])
                    {
                        MessageBox.Show("Bạn trả lời chuẩn quá");
                        // Đừng thời gian đếm lại.
                        tmDem.Stop();
                        dem = 0;
                        lblDem.Text = "00";

                        LoadHinhAnh();
                    }
                    else
                    {
                        MessageBox.Show("Sai Rồi!!!!! Ngu như chó");
                        tmDem.Stop();
                        tmThoiGian.Stop();
                        MessageBox.Show("Bạn đã chơi hết " + lblDongHo.Text + "s cảm ơn bạn đã chơi");
                        foreach (Control c in this.gbDapAn.Controls)
                        {
                            if (c is TextBox)
                            {
                                TextBox tx = (TextBox)c;
                                if (tx.Text == DapAn[cauhoi - 1])
                                {
                                    tx.BackColor = Color.Red;
                                    tx.ForeColor = Color.White;
                                }
                            }
                        }
                        this.gbDapAn.Enabled = false;
                        foreach (Control c in this.Controls)
                        {
                            if (c is RadioButton)
                            {
                                RadioButton rdb = (RadioButton)c;
                                rdb.Enabled = false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lần sau chắc chắn nha mày");
                    if (KiemTraThongBaoHetGio == false)
                    {
                        rd.Checked = false;
                        txtA.BackColor = txtB.BackColor = txtC.BackColor = txtD.BackColor = Color.White;
                        txtA.ForeColor = txtB.ForeColor = txtC.ForeColor = txtD.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void KiemTraDapAn_Click(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            if (tx.Name == "txtA")
            {
                rdbA.Checked = true;
            }
            else if (tx.Name == "txtB")
            {
                rdbB.Checked = true;
            }
            else if (tx.Name == "txtC")
            {
                rdbC.Checked = true;
            }
            else if (tx.Name == "txtD")
            {
                rdbD.Checked = true;
            }
        }
        void LoadHinhAnh()
        {
            for (int i = 0; i < this.Controls.Count; ++i)
            {
                this.Controls[i].Visible = false;
            }
            ptr.Visible = true;
            int index = rd.Next(1, 7);
            string s = "Hinh Gai Dep/" + index + ".jpg";
            ptr.Image = Image.FromFile(s);
            tl.SetToolTip(ptr, "Click vào em để qua câu mới nha !!!!!");
        }

        private void tmThoiGian_Tick(object sender, EventArgs e)
        {
            giay++;
            if (giay == 60)
            {
                phut++;
                giay = 0;
            }
            lblDongHo.Text = phut.ToString().Count() == 1 ? "0" + phut.ToString() : phut.ToString();
            lblDongHo.Text += ":" + (giay.ToString().Count() == 1 ? "0" + giay.ToString() : giay.ToString());
        }
        int dem = 0;
        private void tmDem_Tick(object sender, EventArgs e)
        {
            dem++;
            lblDem.Text = dem.ToString().Count() == 1 ? "0" + dem.ToString() : dem.ToString();
            if (dem == 10 && KiemTraDaTraLoiCauHoi == false)
            {
                tmDem.Stop();
                tmThoiGian.Stop();
                this.gbDapAn.Enabled = false;
                this.gbCauHoi.Enabled = false;

                ThongBaohetGio =  MessageBox.Show("Đã hết thời gian bạn thua rồi", "Thông Báo", MessageBoxButtons.OK);
                MessageBox.Show("Bạn đã chơi hết " + lblDongHo.Text + "s cảm ơn bạn đã chơi");
                KiemTraThongBaoHetGio = true;
                if (ThongBaohetGio == DialogResult.OK)
                {
                    SendKeys.Send("{TAB}");
                    SendKeys.Send("{ENTER}");
                    SendKeys.Send("{ENTER}");
                    foreach (Control c in this.gbDapAn.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox tx = (TextBox)c;
                            if (tx.Text == DapAn[cauhoi - 1])
                            {
                                tx.BackColor = Color.Red;
                                tx.ForeColor = Color.White;
                            }
                        }
                    }
                    foreach (Control c in this.Controls)
                    {
                        if (c is RadioButton)
                        {
                            RadioButton rdb = (RadioButton)c;
                            rdb.Enabled = false;
                        }
                    }
                }
            }
        }

        private void Ptr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; ++i)
            {
                this.Controls[i].Visible = true;
            }
            cauhoi++;
            if (cauhoi > DanhSachCauHoi.GetLength(0))
            {
                tmDem.Stop();
                tmThoiGian.Stop();
                ptr.Visible = false;
                MessageBox.Show("Đã hết câu hỏi, bạn đã chơi hết " + lblDongHo.Text + "s cảm ơn bạn đã chơi");
                this.gbDapAn.Enabled = false;
                cauhoi--;
            }
            else
            {
                ptr.Visible = false;

                // Chạy lại thời gian giới hạn dành cho câu hỏi
                tmDem.Start();

                LoadCauHoi(cauhoi);
            }
        }
    }
}
