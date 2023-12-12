namespace Organizador_de_tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Quantidade = 0;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nome = textBox1.Text;
            var preco = textBox2.Text;
            string codigo = textBox3.Text;

            if (Nome == "" || Data == "" || desc == "")
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                listBox1.Items.Add("Nome: " + Nome + " | Preço: " + preco + " | Codigo: " + codigo + " " + dateTimePicker1.Value + ";" + "\n");
                Quantidade = Quantidade + 1;
                label10.Text = Quantidade.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string codigoExcluir = textBox4.Text;

            if (codigoExcluir == "")
            {

            }
            else
            {
                
                foreach (var item in listBox1.Items.Cast<string>().ToList())
                {
                    if (item.Contains("Codigo: " + codigoExcluir))
                    {
                        listBox1.Items.Remove(item);
                        Quantidade = Quantidade - 1;
                        label10.Text = Quantidade.ToString();
                        textBox4.Text = "";
                        
                        return;
                        ;

                    }
                }

                

                label4.Text = "Produto não encontrado";
            }
            listBox1.Items.RemoveAt(Width - Convert.ToInt32(textBox4.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int CodigoAleatorio = random.Next(1, 1999999999);
            textBox3.Text = CodigoAleatorio.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
         
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}