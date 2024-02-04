using System.Globalization;

namespace inch_in_cm_schulaufgabe01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double inch = double.Parse(textBox1.Text, CultureInfo.GetCultureInfo("de-DE"));
                double cm = inch * 2.54;
                MessageBox.Show(cm.ToString("F2") + " cm");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox2.Text.Replace(',', '.'); // Ersetze Komma durch Punkt
                double inch;

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out inch))
                {
                    double cm = inch / 2.54;
                    MessageBox.Show(cm.ToString("F2") + " inch");
                }
                else
                {
                    MessageBox.Show("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
