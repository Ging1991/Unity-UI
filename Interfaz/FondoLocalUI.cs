using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI {

	public class FondoLocalUI : TemaUI {

		public override void SetColorRelleno(Color color) {
			transform.GetChild(0).GetComponent<Image>().color = color;
		}

		public override void SetColorTexto(Color color) {}

		public override void SetColorBorde(Color color) {
			GetComponent<Image>().color = color;
		}

		public void SetTexto(string texto) {
			GetComponentInChildren<Text>().text = texto;
		}

		public static FondoLocalUI GetInstancia(string nombre) {
			GameObject objeto = GameObject.Find(nombre);
			if (objeto != null) {
				return objeto.GetComponent<FondoLocalUI>();
			}
			return null;
		}

	}

}