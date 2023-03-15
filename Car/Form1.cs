namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
        }
    }
}