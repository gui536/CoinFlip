using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinFlip.Models;
using System.Windows.Input;


namespace CoinFlip.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _lado;

        [ObservableProperty]
        public String _ladoEscolhido;

        [ObservableProperty]
        public String _imagem;

        [ObservableProperty]
        public String _resultado;

        public ICommand FlipCommand { get; private set; }
        
        public CoinViewModel()
        {
            FlipCommand = new Command(Flip);
        }

        public void Flip()
        {
            Coin coin = new Coin();
            Resultado = coin.Jogar(LadoEscolhido);
            //Pegar o resultado da Moeda e escrever na label
            Imagem = $"{coin.Lado}.png";
        }
    }
}
