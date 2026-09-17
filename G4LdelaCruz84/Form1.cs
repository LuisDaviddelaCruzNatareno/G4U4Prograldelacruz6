namespace G4LdelaCruz84
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int a = int.Parse(textBox3.Text);
            string Mes = "";
            switch (m)
            {
                case 1:
                    Mes = "Enero";
                break;
                case 2:
                    Mes = "Enero";
                    break;
                case 3:
                    Mes = "Enero";
                    break;
                case 4:
                    Mes = "Enero";
                    break;
                case 5:
                    Mes = "Enero";
                    break;
                case 6:
                    Mes = "Enero";
                    break;
                case 7:
                    Mes = "Enero";
                    break;
                case 8:
                    Mes = "Enero";
                    break;
                case 9:
                    Mes = "Enero";
                    break;
                case 10:
                    Mes = "Enero";
                    break;
                case 11:
                    Mes = "Enero";
                    break;
                case 12:
                    Mes = "Enero";
                    break;
                default:
                    MessageBox.Show("INgrese un mes valido");
                    break;
            }
            textBox4.Text = d + " de " + Mes + " de " + a;
        }
    }
}
