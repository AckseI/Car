using System.Data;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Car[] cars = new Car[0];
        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.maxSpeed = int.Parse(textBox1.Text);
            car.weight = float.Parse(textBox2.Text);
            car.isDamage = checkBox1.Checked;
            car.color = textBox4.Text;
            car.sits = int.Parse(textBox3.Text);

            Array.Resize(ref cars, cars.Length + 1);

            cars[cars.Length - 1] = car;

            dataGridView1.Rows.Add(car.maxSpeed, car.weight, car.isDamage, car.color, car.sits);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else {e.Handled = true;}
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == Convert.ToChar(",")) return;
            else {e.Handled = true;}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                cars[i].maxSpeed = int.Parse(dataGridView1.Rows[i].Cells["maxSpeed"].Value.ToString());
                cars[i].weight = float.Parse(dataGridView1.Rows[i].Cells["weight"].Value.ToString());
                cars[i].isDamage = bool.Parse(dataGridView1.Rows[i].Cells["isDamage"].Value.ToString());
                cars[i].color = dataGridView1.Rows[i].Cells["color"].Value.ToString();
                cars[i].sits = int.Parse(dataGridView1.Rows[i].Cells["sits"].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells["maxSpeed"].Value = cars[i].maxSpeed;
                dataGridView1.Rows[i].Cells["weight"].Value = cars[i].weight;
                dataGridView1.Rows[i].Cells["isDamage"].Value = cars[i].isDamage;
                dataGridView1.Rows[i].Cells["color"].Value = cars[i].color;
                dataGridView1.Rows[i].Cells["sits"].Value = cars[i].sits;
            }
        }
    }
}