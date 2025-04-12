using Ging1991.UI.Temas;
using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI {

	public class Relleno : MonoBehaviour, ITematizable {

		public string temaRelleno;

		public void SetImagenRelleno(Sprite imagen) {
			GetComponent<Image>().sprite = imagen;
		}

		public void SetColorRelleno(Color color) {
			GetComponent<Image>().color = color;
		}

		public virtual void AplicarTema(Tema tema) {
			SetColorRelleno(tema.TraerColor(temaRelleno));
		}

    }

}