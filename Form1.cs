using System;

namespace xroot {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            double n, exp, root;
            try {
                n = Convert.ToDouble(nfield.Text);
                exp = Convert.ToDouble(expfield.Text);
                root = Convert.ToDouble(rootfield.Text);
                if (n == 0) {
                    output.Text = " Math error!";
                }
                else if (exp == 0 && root == 0) {
                    output.Text = " Math error!";
                }
                else if (root < 0) {
                    output.Text = $" {Math.Pow(root * (-1), exp / n)}i";
                }
                
                else {
                    output.Text = $" {Math.Pow(root, exp / n)}";
                }
            }
            catch (FormatException) {
                output.Text = " An error occurred!";
            }
            catch (InvalidCastException) {
                output.Text = " An error occurred!";
            }
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pic_TextChanged(object sender, EventArgs e) { }
    }
}