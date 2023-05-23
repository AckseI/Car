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
            car.weight = int.Parse(textBox2.Text);
            car.isDamage = checkBox1.Checked;
            car.color = textBox4.Text;
            car.price = int.Parse(textBox3.Text);

            Array.Resize(ref cars, cars.Length + 1);

            cars[cars.Length - 1] = car;

            dataGridView1.Rows.Add(car.maxSpeed, car.weight, car.isDamage, car.color, car.price);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else { e.Handled = true; }
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == Convert.ToChar(",")) return;
            else { e.Handled = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                cars[i].maxSpeed = int.Parse(dataGridView1.Rows[i].Cells["maxSpeed"].Value.ToString());
                cars[i].weight = int.Parse(dataGridView1.Rows[i].Cells["weight"].Value.ToString());
                cars[i].isDamage = bool.Parse(dataGridView1.Rows[i].Cells["isDamage"].Value.ToString());
                cars[i].color = dataGridView1.Rows[i].Cells["color"].Value.ToString();
                cars[i].price = int.Parse(dataGridView1.Rows[i].Cells["sits"].Value.ToString());
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
                dataGridView1.Rows[i].Cells["sits"].Value = cars[i].price;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isSort = false;

            DateTime startTime = DateTime.Now;

            while (!isSort)
            {
                isSort = true;
                for (int i = 0; i < cars.Length - 1; i++)
                {
                    if (cars[i].maxSpeed > cars[i + 1].maxSpeed)
                    {
                        Car c = new Car();
                        c = cars[i];
                        cars[i] = cars[i + 1];
                        cars[i + 1] = c; isSort = false;
                    }
                }
            }
            System.TimeSpan time = startTime - DateTime.Now;

            label6.Text = time.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < int.Parse(textBox5.Text); i++)
            {
                dataGridView1.Rows.Add(i+1, rnd.Next(1,10), true, "jj", rnd.Next(1,10));
            }
            Array.Resize(ref cars, 0);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Array.Resize(ref cars, cars.Length + 1);
                cars[i] = new Car();
                cars[i].maxSpeed = int.Parse(dataGridView1.Rows[i].Cells["maxSpeed"].Value.ToString());
                cars[i].weight = int.Parse(dataGridView1.Rows[i].Cells["weight"].Value.ToString());
                cars[i].isDamage = bool.Parse(dataGridView1.Rows[i].Cells["isDamage"].Value.ToString());
                cars[i].color = dataGridView1.Rows[i].Cells["color"].Value.ToString();
                cars[i].price = int.Parse(dataGridView1.Rows[i].Cells["sits"].Value.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int j;
            int step = cars.Length / 2;
            DateTime startTime = DateTime.Now;
            while (step > 0)
            {
                for (int i = 0; i < (cars.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (cars[j].maxSpeed > cars[j + step].maxSpeed))
                    {
                        Car c = new Car();
                        c = cars[j];
                        cars[j] = cars[j + step];
                        cars[j + step] = c;
                        j -= step;
                    }
                }
                step /= 2;
            }
            System.TimeSpan time = startTime - DateTime.Now;
            label6.Text = time.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int start = 0;
            int end = cars.Length - 1;
            bool swapped = true;
            DateTime startTime = DateTime.Now;

            while (swapped)
            {
                swapped = false;
                for (int i = start; i < end; ++i)
                {
                    if (cars[i].maxSpeed > cars[i + 1].maxSpeed)
                    {
                        Car temp = new Car();
                        temp = cars[i];
                        cars[i] = cars[i + 1];
                        cars[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                swapped = false;

                for (int i = end - 1; i >= start; --i)
                {
                    if (cars[i].maxSpeed > cars[i + 1].maxSpeed)
                    {
                        Car temp = new Car();
                        temp = cars[i];
                        cars[i] = cars[i + 1];
                        cars[i + 1] = temp;
                        swapped = true;
                    }
                }

                ++start;
            }
            System.TimeSpan time = startTime - DateTime.Now;
            label6.Text = time.ToString();
            //Шейкер
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int weight_cost = int.Parse(textBox6.Text);
            int r = 0;
            int r_max = 0;
            int count = cars.Length;
            int sum_max = 0;
            int weight_max = 0;
            DateTime startTime = DateTime.Now;

            while (r < Math.Pow(2, count))
            {
                string bit = Convert.ToString(r, 2);
                int sum = 0;
                int weight = 0;

                for (int i = 0; i < bit.Length; i++)
                {
                    if (bit[i] == '1')
                    {
                        weight += cars[i].weight;
                        sum += cars[i].price;
                    }
                }

                if (weight <= weight_cost && sum_max < sum)
                {
                    sum_max = sum;
                    weight_max = weight;
                    r_max = r;
                }
                r++;
            }
            System.TimeSpan time = DateTime.Now - startTime;
            label6.Text = time.ToString();

            richTextBox1.AppendText(Convert.ToString(r_max, 2));
            richTextBox1.AppendText("\n Сумма = " + sum_max.ToString());
            richTextBox1.AppendText("\n Вес = " + weight_max.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int capacity = int.Parse(textBox6.Text);
            int[,] bp = new int[cars.Length+1, capacity + 1];
            DateTime startTime = DateTime.Now;

            for (int i = 0; i < cars.Length+1; i++)
            {
                for(int j = 0; j < capacity+1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        bp[i, j] = 0;
                    }
                    else if (cars[i-1].weight <= j)
                    {
                        bp[i, j] = Math.Max(cars[i-1].price + bp[i-1, j - cars[i-1].weight], bp[i-1, j]);
                    }
                    else 
                    { 
                        bp[i, j] = bp[i-1, j]; 
                    }
                }
            }
            System.TimeSpan time = DateTime.Now - startTime;
            label6.Text = time.ToString();

            string items = "";
            int currentItem = cars.Length;
            int currentCapacity = capacity;
            int maxWeight = 0;

            while (currentItem > 0 && currentCapacity > 0)
            {
                if (bp[currentItem, currentCapacity] != bp[currentItem - 1, currentCapacity])
                {
                    items += cars[currentItem - 1].maxSpeed + " ";
                    maxWeight += cars[currentItem - 1].weight;
                    currentCapacity -= cars[currentItem - 1].weight;
                }
                currentItem--;
            }
            int maxSumma = bp[cars.Length, maxWeight];
            richTextBox1.AppendText("\nПредметы:\n" + items + "Сумма = " + maxSumma.ToString() + "\nВес = " + maxWeight);
        }
    }
}
