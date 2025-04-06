using Ging1991.UI.Marcos;
using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI.Contadores {

	public class Contador : Marco {

		public GameObject valorOBJ;
		public int valor;

		public void SetColorTexto(Color color) {
			valorOBJ.GetComponent<Text>().color = color;
		}
		
		public void SetValor(int valor) {
			this.valor = valor;
			valorOBJ.GetComponent<Text>().text = $"{valor}";
		}
		
	}

}