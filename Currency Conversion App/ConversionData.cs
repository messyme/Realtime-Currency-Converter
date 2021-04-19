using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Currency_Conversion_App {
	class ConversionData {
		public decimal val;

		public static ConversionData Deserialize(string data) {
			return JsonConvert.DeserializeObject<Dictionary<String, ConversionData>>(data).ElementAt(0).Value;
		}
	}
}
