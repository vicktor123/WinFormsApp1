namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            MessageBox.Show("test");
            MessageBox.Show("test1234");
            MessageBox.Show("123456test");
            MessageBox.Show("test");
        }
}
