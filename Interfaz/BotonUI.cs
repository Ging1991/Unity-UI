using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI {

	public class BotonUI : TemaUI {

		public GameObject candado;

		public override void SetColorRelleno(Color color) {
			transform.GetChild(0).GetComponent<Image>().color = color;
		}

		public override void SetColorTexto(Color color) {
			transform.GetChild(0).GetComponentInChildren<Text>().color = color;
		}

		public override void SetColorBorde(Color color) {
			GetComponent<Image>().color = color;
		}

		public void Bloquear(bool bloqueado) {
			GetComponentInChildren<Button>().interactable = !bloqueado;
			if (candado != null)
				candado.SetActive(bloqueado);
		}

	}

}