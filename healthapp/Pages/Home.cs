using System;

using Xamarin.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace healthapp
{
	public class Home : ContentPage
	{
		public Home ()
		{
			var hello = new Label {
				Text = "Teste"
			};

			var button = new Button {
				Text = "Teste de clique"
			};

			button.Clicked += async (sender, e) => await teste();

			var stackLayout = new StackLayout {
				Children = {
					hello,
					button
				}
			};

			this.Content = stackLayout;
		}

		public async Task teste() {

			Pessoa newPessoa = new Pessoa
			{ 
				Email = String.Format("{0}@a.com", Guid.NewGuid().ToString()),
				Senha = "123123",
				Nome = "Teste 1",
				Nascimento = DateTime.Now,
				Telefone = "123",
				Peso= 123,
				Altura = 1234,
				Sexo = false
			};
			Pessoa newPessoaResponse = await WebHandler.HttpPost<Pessoa> ("/api/pessoa/", newPessoa);

			Pessoa getPessoa = await WebHandler.HttpGet<Pessoa> ($"/api/pessoa/?email={newPessoa.Email}&senha={newPessoa.Senha}");

			getPessoa.Senha = "abc123"; //Muda senha

			Pessoa getPessoaComNovaSenha = await WebHandler.HttpPut<Pessoa> ("/api/pessoa/", getPessoa);

			await DisplayAlert ("test", "teste", "test");
		}
	}
}


