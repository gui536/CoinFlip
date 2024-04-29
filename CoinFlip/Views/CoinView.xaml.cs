namespace CoinFlip.Views;
using CoinFlip.Models;
using CoinFlip.ViewModels;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		HeadTailsPicker.SelectedIndex = 0;
		this.BindingContext = new CoinViewModel();
	}

    private void CoinFlipButton_Clicked(object sender, EventArgs e)
    {
		string ladoEscolhido = HeadTailsPicker.SelectedItem.ToString();
		//Jogar a moeda
		Coin coin = new Coin();
		string resultado = coin.Jogar(ladoEscolhido);
        //Pegar o resultado da Moeda e escrever na label
        ResultLabel.Text = resultado;
		CoinImage.Source = $"{coin.Lado}.png";
    }
}