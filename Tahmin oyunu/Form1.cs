namespace Tahmin_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rnd;
        Random r;
        int tahminSayisi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Random();
            rnd = r.Next(1, 101);
        }

        private void btnTahminet_Click(object sender, EventArgs e)
        {
            tahminSayisi++;

            if (txtTahmin.Text.Length < 1)
            {
                MessageBox.Show("L�tfen bir say� giriniz", "Say� Girilmedi");
            }

            int tahmin = int.Parse(txtTahmin.Text);

            if (tahmin == rnd)
            {
                var cevap = MessageBox.Show($"Do�ru Tahmin Ettiniz {tahminSayisi} denemede bilginiz. Tekrar oynamak istermisiniz?", "Tebrikler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.No)
                {
                    this.Close();
                }
                else if (cevap == DialogResult.Yes)
                {
                    rnd = r.Next(1, 101);
                    tahminSayisi = 0;
                }
            }
            else if (tahmin > rnd)
            {
                MessageBox.Show("Daha k���k bir say� giriniz");
            }
            else if (tahmin < rnd)
            {
                MessageBox.Show("Daha b�y�k bir say� giriniz");
            }
            txtTahmin.Text = "";
            txtTahmin.Focus();
        }

        private void txtTahmin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTahminet.PerformClick();

            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtTahmin.Focus();

        }
    }
}
