using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI.Marcos {

	public class Marco : MonoBehaviour {

		public GameObject rellenoOBJ;

		public void SetColorRelleno(Color color) {
			rellenoOBJ.GetComponent<Image>().color = color;
		}

		public void SetColorBorde(Color color) {
			GetComponent<Image>().color = color;
		}
		
	}

}