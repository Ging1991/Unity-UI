using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI {

	public class CartelUI : TemaUI {

		public override void SetColorRelleno(Color color) {
			transform.GetChild(0).GetComponent<Image>().color = color;
		}

		public override void SetColorTexto(Color color) {
			transform.GetChild(1).GetComponent<Text>().color = color;
		}

		public override void SetColorBorde(Color color) {
			GetComponent<Image>().color = color;
		}

		public void SetTexto(string texto) {
			GetComponentInChildren<Text>().text = texto;
		}

		public static CartelUI GetInstancia(string nombre) {
			GameObject objeto = GameObject.Find(nombre);
			if (objeto != null) {
				return objeto.GetComponent<CartelUI>();
			}
			return null;
		}


	}

}