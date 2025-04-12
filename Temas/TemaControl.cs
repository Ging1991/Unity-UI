using UnityEngine;

namespace Ging1991.UI.Temas {

	public class TemaControl : MonoBehaviour {

		public Tema temaPrincipal;

		// version 1
		public void AplicarTemaPrincipal(ITematizable tematizable) {
			if (temaPrincipal != null) {
				tematizable.AplicarTema(temaPrincipal);
			}
		}


		public void EstablecerTemaPrincipal(Tema tema) {
			temaPrincipal = tema;
			foreach (var componente in GameObject.FindObjectsOfType<MonoBehaviour>(true)) {
				if (componente is ITematizable tematizable) {
					tematizable.AplicarTema(temaPrincipal);
				}
			}
		}


	}

}