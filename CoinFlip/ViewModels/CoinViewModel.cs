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
        private string _ladoEscolhido;

        [ObservableProperty]
        private string _resultado;

        public CoinViewModel() {
            JogarCommand = new Command(Jogar);
        }

        public ICommand JogarCommand { get; } 

        public void Jogar()
        {
            Coin coin = new Coin();
            Resultado = coin.Jogar(LadoEscolhido);
        }
    }
}
