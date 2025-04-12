using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI {

	public class Boton : MarcoConTexto {

		public GameObject candado;

		public void Bloquear(bool bloqueado) {
			GetComponentInChildren<Button>().interactable = !bloqueado;
			if (candado != null)
				candado.SetActive(bloqueado);
		}

	}

}