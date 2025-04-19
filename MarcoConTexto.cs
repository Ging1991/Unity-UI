using Ging1991.UI.Temas;
using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI {

	public class MarcoConTexto : Marco {

		public GameObject textoOBJ;
		public string temaTexto;

        public virtual void SetColorTexto(Color color) {
			textoOBJ.GetComponent<Text>().color = color;
		}


		public void SetTexto(string texto) {
			textoOBJ.GetComponent<Text>().text = texto;
		}


		public override void AplicarTema(Tema tema) {
			if (!esPersonalizado) {
				base.AplicarTema(tema);
				SetColorTexto(tema.TraerColor(temaTexto));
			}
		}


	}

}