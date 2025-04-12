namespace Ging1991.UI {

	public class ContadorNumero : MarcoConTexto {

		public int valor;


		public void SetValor(int valor) {
			this.valor = valor;
			SetTexto($"{valor}");
		}
		

	}

}