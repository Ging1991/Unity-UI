using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI {

	public class FondoGlobalUI : TemaUI {

		public override void SetColorRelleno(Color color) {
			GetComponent<Image>().color = color;
		}

		public override void SetColorTexto(Color color) {}

		public override void SetColorBorde(Color color) {}

	}

}