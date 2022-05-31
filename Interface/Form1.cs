using Logic;

namespace Interface
{
    public partial class Form1 : Form
    {
        CurrencyConverter converter;
        public Form1()
        {
            InitializeComponent();
            converter = new();
            this.MinimumSize = new Size(315, 147);
            this.MaximumSize = new Size(315, 147);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double usd = 0;
            try
            {
                usd = double.Parse(textBox1.Text);
                try
                {
                    converter.SetExchangeRate();
                    label5.Text = converter.ExchangeRate.ToString();
                    label3.Text = Math.Round((usd * converter.ExchangeRate), 4).ToString();
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так! Попробуйте ещё раз или обратитесь в поддержку");
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное значение в формате доллары,центы");
            }
        }
    }
}
