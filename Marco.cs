using Ging1991.UI.Temas;
using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI {

	public class Marco : Relleno {

		public string temaBorde;
		public GameObject rellenoOBJ;

		public void SetColorBorde(Color color) {
			GetComponent<Image>().color = color;
		}


		public override void SetColorRelleno(Color color) {
			rellenoOBJ.GetComponent<Image>().color = color;
		}


		public override void AplicarTema(Tema tema) {
			if (!esPersonalizado) {
				base.AplicarTema(tema);
				SetColorBorde(tema.TraerColor(temaBorde));				
			}
		}


	}

}