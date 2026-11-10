using System.IO;
namespace TestMaiThi

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstMonhoc.Items.Clear();
            lstDachon.Items.Clear();

            lstMonhoc.Items.Add("Toan A1");
            lstMonhoc.Items.Add("6");
            lstMonhoc.Items.Add("2");

            lstDachon.Items.Add("5");
            lstDachon.Items.Add("3");

            txtHocphi.Text = ("800000");
            txtHocphi.ReadOnly = true;





        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            object? monHoc = lstDachon.SelectedItem;
            if (monHoc == null)
            {
                MessageBox.Show("Vui long chon mon hoc!");
                return;
            }
            lstDachon.Items.Remove(monHoc);
            lstMonhoc.Items.Add(monHoc);
        }

        private void btnTatca_Click(object sender, EventArgs e)
        {
            foreach (object monHoc in lstMonhoc.Items)
            {
                lstDachon.Items.Add(monHoc);
            }
            lstMonhoc.Items.Clear();
        }
        private int TinhTongHocPhi()
        {
            int tongDonVi = 0;
            foreach (object monHoc in lstDachon.Items)
            {
                switch (monHoc.ToString())
                {
                    case "Toan A1":
                        tongDonVi += 4;
                        break;
                    case "6":
                        tongDonVi += 6;
                        break;
                    case "2":
                        tongDonVi += 2;
                        break;
                    case "5":
                        tongDonVi += 5;
                        break;
                    case "3":
                        tongDonVi += 3;
                        break;

                }

            }
            return tongDonVi * 100000;
        }

        private void btnTinhhocphi_Click(object sender, EventArgs e)
        {
            int tongTien = TinhTongHocPhi();
            txtHocphi.Text = tongTien.ToString();
        }

        private void btnGhifile_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";
            sfd.FileName = "HocPhi.txt";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                foreach (object monHoc in lstDachon.Items)
                    sw.WriteLine(monHoc);

                sw.WriteLine("Tong hoc phi: " + TinhTongHocPhi() + " dong");
            }

            MessageBox.Show("Ghi file thanh cong!");
        }
    }
}
