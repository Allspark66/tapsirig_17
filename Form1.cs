using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tapsiriq17
{
    public partial class Form1 : Form
    {
        bool isvisiblecvv = false;
        public Form1()
        {
            InitializeComponent();
            dtExpire.Format = DateTimePickerFormat.Custom;
            dtExpire.CustomFormat = "dddd, dd MMMM yyyy";

            cvv.Text = "***";

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void dtExpire_ValueChanged(object sender, EventArgs e)
        {
            expire.Text = dtExpire.Value.ToString("MM/yy"); // Ay/İl formatı

        }

        private void textboxnumber_TextChanged(object sender, EventArgs e)
        {
            string Number = textboxnumber.Text;

            // 16 rəqəm olub-olmadığını yoxlayırıq
            if (Number.Length == 16 && Number.All(char.IsDigit))
            {
                textboxnumber.BackColor = Color.Green;
                number.Text = Number; // Kart şəkilindəki labelə yazırıq
            }
            else
            {

                textboxnumber.BackColor = Color.White; // Normal rəng
                number.Text = "**** **** **** ****"; // Default görünüş
            }
        }

        private void eye_Click(object sender, EventArgs e)
        {
            isvisiblecvv = !isvisiblecvv;
            if (isvisiblecvv)
            {
                cvv.Text = textboxcvv.Text; // CVV göstər
                eye.Image = Properties.Resources.opened; // Açıq göz
            }
            else
            {
                cvv.Text = "***"; // CVV gizli
                eye.Image = Properties.Resources.closed; // Bağlı göz
            }

        }

        private void textboxname_TextChanged(object sender, EventArgs e)
        {
            string namesurname = textboxname.Text;
            name.Text = namesurname;

        }

        private void cvv_Click(object sender, EventArgs e)
        {

        }

        private void textboxcvv_TextChanged(object sender, EventArgs e)

        {
            string kod = textboxcvv.Text;
            if (kod.Length == 3 && kod.All(char.IsDigit))
            {
                cvv.Text = textboxcvv.Text;
            }
            else
            {
                cvv.Text = "***";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kartNumberOk = textboxnumber.Text.Length == 16 && textboxnumber.Text.All(char.IsDigit);
            bool nameOk = !string.IsNullOrWhiteSpace(textboxname.Text);
            bool cvvOk = textboxcvv.Text.Length == 3 && textboxcvv.Text.All(char.IsDigit);
            bool dtOk = true; // Tarix seçimi mütləqdirsə buranı əlavə yoxla

            if (kartNumberOk && nameOk && cvvOk && dtOk)
            {
                MessageBox.Show("Bütün məlumatlar düzgündür!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bəzi məlumatlar düzgün deyil. Xahiş olunur yoxlayın!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
