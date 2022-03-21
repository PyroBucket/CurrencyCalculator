using System.Xml;
using System.Xml.Serialization;

namespace CurrencyCalculator
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> _exchangeRates = new Dictionary<string, decimal>();
        private Calculator _calculator;
        public Form1()
        {
            InitializeComponent();
            exchangeRatesFromXML();
            populateCurrencyDropdown();
            _calculator = new Calculator(_exchangeRates);
        }

        private void populateCurrencyDropdown()
        {
            CurrencyComboBox.Items.AddRange(_exchangeRates.Keys.ToArray());
            CurrencyComboBox.Text = CurrencyComboBox.Items[0].ToString();
        }
        private void exchangeRatesFromXML()
        {
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            using (var fileStream = File.OpenText("ExchangeRates.xml"))
            using (XmlReader reader = XmlReader.Create(fileStream, settings))
            {
                while (reader.Read())
                {

                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Cube" && reader.AttributeCount == 2)
                    {
                        string currency = reader.GetAttribute("currency");
                        decimal price = Convert.ToDecimal(reader.GetAttribute("rate"));
                        result.Add(currency, price);
                    }
                }
            }
            _exchangeRates = result;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            decimal initialSum = Convert.ToDecimal(InputNumericBox.Text);
            Money initialMoney = new Money("EUR", initialSum);
            OutputTextBox.Text = _calculator.Convert(initialMoney, CurrencyComboBox.Text).ToString();
        }
    }
}