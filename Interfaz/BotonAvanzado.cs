using UnityEngine.UI;

namespace Bounds.Menu {

	public class BotonAvanzado : Button {

		public bool bloqueado;

		protected override void Start() {
			base.Start();
		}


		public void Desbloquear() {
			bloqueado = false;
			interactable = true;

			if (transform.childCount > 1) {
				Destroy(transform.GetChild(1).gameObject);
			}
		}


		public void OnClick() {
			if (!bloqueado) {
				base.onClick.Invoke();
			}
		}

	}

}