namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        
        private void CoinFlipButton_Clicked(object sender, EventArgs e)
        {
            //Joga a moeda onde 0 é coroa e 1 a cara
            //Primeiro desafio: Utiilzar uma Enumeração para Cara ou Coroa
            //Segundo desafio: Utiilzar uma classe para representar a Moeda
            int coin = new Random().Next(2);
            if (coin == 0)
            {                
                CoinImage.Source = "coroa.png";
            }
            if (coin == 1)
            {
                CoinImage.Source = "cara.png";
            }
            //Verifica o que o usuário selecionou
            string selectedSide = Convert.ToString(HeadTailsPicker.SelectedItem);

            if (coin == 0 && selectedSide == "Coroa") {
                ResultLabel.Text = "Parabéns, você ganhou";
            }
            if (coin == 1 && selectedSide == "Coroa"){
                ResultLabel.Text = "Que pena, você perdeu";
            }
            if (coin == 0 && selectedSide == "Cara"){
                ResultLabel.Text = "Que pena, você perdeu";
            }
            if (coin == 1 && selectedSide == "Cara"){
                ResultLabel.Text = "Parabéns, você ganhou";
            }
        }
    }

}
