using UnityEngine;

namespace Ging1991.UI {

	public abstract class TemaUI : MonoBehaviour {

		public string grupo;

		public static void SetGlobalColorTexto(string grupo, Color color) {
			foreach (var tema in FindObjectsOfType<TemaUI>()) {
				if (tema.grupo == grupo) {
					tema.SetColorTexto(color);
				}
			}
		}

		public static void SetGlobalColorRelleno(string grupo, Color color) {
			foreach (var tema in FindObjectsOfType<TemaUI>()) {
				if (tema.grupo == grupo) {
					tema.SetColorRelleno(color);
				}
			}
		}

		public static void SetGlobalColorBorde(string grupo, Color color) {
			foreach (var tema in FindObjectsOfType<TemaUI>()) {
				if (tema.grupo == grupo) {
					tema.SetColorBorde(color);
				}
			}
		}

		public abstract void SetColorRelleno(Color color);

		public abstract void SetColorTexto(Color color);

		public abstract void SetColorBorde(Color color);

	}

}