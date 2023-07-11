namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            textBox3.Text = "Total" + Environment.NewLine + "000000";
        }

        private void btn_Compute_Click(object sender, EventArgs e)
        {
            float number1, number2;
            if (!float.TryParse(textBox1.Text, out number1))
            {
                MessageBox.Show("First Number Invalid");
                return;
            }
            if (!float.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Second Number Invalid");
                return;
            }

            string operation = comboBox1.Text;
            switch (operation)
            {
                case "+":
                    BasicComputation.BasicCompute add = new BasicComputation.BasicCompute();
                    textBox3.Text = "Total" + Environment.NewLine + Convert.ToString(add.Addition(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)));
                    break;

                case "-":
                    BasicComputation.BasicCompute subtract = new BasicComputation.BasicCompute();
                    textBox3.Text = "Total" + Environment.NewLine + Convert.ToString(subtract.Subtraction(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)));
                    break;

                case "*":
                    BasicComputation.BasicCompute multiply = new BasicComputation.BasicCompute();
                    textBox3.Text = "Total" + Environment.NewLine + Convert.ToString(multiply.Multiplication(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)));
                    break;


                case "/":
                    if (number2 == 0)
                    {
                        MessageBox.Show("Division by ZERO");
                    }
                    else
                    {
                        BasicComputation.BasicCompute divide = new BasicComputation.BasicCompute();
                        textBox3.Text = "Total" + Environment.NewLine + Convert.ToString(divide.Division(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)));
                    }
                    break;



                default:
                    MessageBox.Show("Operation in INVALID!");
                    break;
            }
        }
    }
}