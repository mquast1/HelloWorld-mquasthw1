namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Hello World Dialog");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Hello World 2.0", "Hello World Dialog with Buttons", MessageBoxButtons.CancelTryContinue);
            
            if(r == DialogResult.Cancel)
            {
                return;
            }
            else if(r == DialogResult.TryAgain)
            {
                MessageBox.Show("I don't wanna.", "Don't wanna", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if(r == DialogResult.Continue)
            {
                MessageBox.Show("Continuing...", "Continue?", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2("Ringo");

            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            DialogResult r = form.ShowDialog();

            if(r == DialogResult.OK)
            {
                Form2 form2 = new Form2(form.GetName());
                form2.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Form4 form = new Form4();
            DialogResult r = form.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}