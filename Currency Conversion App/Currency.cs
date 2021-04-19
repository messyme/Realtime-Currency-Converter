using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Conversion_App {
	class Currency {
		public string name { get; }
		private float compareUnit = -1;
		public float CompareUnit {
			get {
				if(compareUnit == -1) {
					APIRequester currencyRequest = new APIRequester(string.Format("https://free.currconv.com/api/v7/convert?apiKey=acb1dfa8644dc094dc15&q={0}_{1}&compact=y",
						name, "USD"));
					ConversionData conversionData = ConversionData.Deserialize(currencyRequest.SendAndGetResponse());
					this.compareUnit = 1/(float)conversionData.val;
				}
				return compareUnit;
			}
		}

		public Currency(string name) {
			this.name = name;
		}

		public Currency(string name, float compareUnit) {
			this.name = name;
			this.compareUnit = compareUnit;
		}

		public float ConvertTo(float money, Currency currency) {
			return money / CompareUnit * currency.CompareUnit;
		}
	}
}
