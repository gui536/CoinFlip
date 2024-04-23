namespace CoinFlip.Views;
using CoinFlip.Models;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		HeadTailsPicker.SelectedIndex = 0;
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