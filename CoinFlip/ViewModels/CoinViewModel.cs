using CoinFlip.Models;
using CommunityToolkit.Mvvm.ComponentModel;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoinFlip.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        public String _Resultado;

        [ObservableProperty]
        public String _LadoEscolhido;

        [ObservableProperty]
        public String _Imagem;

        public ICommand FlipCommand { get; private set; }
        
        public CoinViewModel()
        {
            FlipCommand = new Command(Flip);
        }

        public void Flip()
        {
            Coin coin = new Coin();
            _Resultado = coin.Jogar(_LadoEscolhido);
            //Pegar o resultado da Moeda e escrever na label
            Imagem = $"{coin.Lado}.png";
        }
    }
}
