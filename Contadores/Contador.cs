using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI.Contadores {

	public class Contador : MonoBehaviour {

		public GameObject rellenoOBJ;
		public GameObject valorOBJ;

		public void SetColorRelleno(Color color) {
			rellenoOBJ.GetComponent<Image>().color = color;
		}
		
		public void SetColorTexto(Color color) {
			valorOBJ.GetComponent<Text>().color = color;
		}
		
		public void SetValor(int valor) {
			valorOBJ.GetComponent<Text>().text = $"{valor}";
		}
		
	}

}