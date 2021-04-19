using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Conversion_App {
	public partial class Form1 : Form {

		private List<Currency> currencies;

		public Form1() {
			InitializeComponent();
			InitializeCurrency();
			SetUpComponent();
			Convert();
		}

		private void InitializeCurrency() {
			APIRequester currencyListRequest = new APIRequester("https://free.currconv.com/api/v7/currencies?apiKey=acb1dfa8644dc094dc15");
			CurrencyList currencyList = CurrencyList.Deserialize(currencyListRequest.SendAndGetResponse());
			currencies = new List<Currency>();
			CurrencyData[] datas = currencyList.ToArray();
			foreach(CurrencyData currency in datas) {
				CreateNewCurrency(currency.id); ;
			}
		}

		private void CreateNewCurrency(string name) {
			currencies.Add(new Currency(name));
		}

		private void SetUpComponent() {
			foreach(Currency currency in currencies) {
				inputCurrency.Items.Add(currency.name);
				outputCurrency.Items.Add(currency.name);
			}
			inputMoney.Minimum = 0;
			inputMoney.Maximum = decimal.MaxValue;
			inputMoney.DecimalPlaces = 2;
			inputCurrency.SelectedIndex = 0;
			outputCurrency.SelectedIndex = 0;
			inputCurrency.SelectedIndexChanged += InputCurrency_SelectedIndexChanged;
			outputCurrency.SelectedIndexChanged += OutputCurrency_SelectedIndexChanged;
			inputMoney.ValueChanged += InputMoney_ValueChanged;
		}

		private void InputMoney_ValueChanged(object sender, EventArgs e) {
			Convert();
		}

		private void OutputCurrency_SelectedIndexChanged(object sender, EventArgs e) {
			Convert();
		}

		private void InputCurrency_SelectedIndexChanged(object sender, EventArgs e) {
			Convert();
		}

		private Currency GetCurrencyByName(string name) {
			for(int i = 0; i < currencies.Count; i++) {
				if(currencies[i].name == name) {
					return currencies[i];
				}
			}
			return null;
		}

		private void Convert() {
			float money = (float)inputMoney.Value;
			Currency inCurrency = GetCurrencyByName(inputCurrency.Text);
			Currency outCurrency = GetCurrencyByName(outputCurrency.Text);
			float output = inCurrency.ConvertTo(money, outCurrency);
			outputMoney.Text = "" + output;
		}

	}
}
