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
    public partial class CoinViewModel : ObservableObject, IDisposable
    {
        [ObservableProperty]
        public String _Resultado;

        


        public ICommand ResultCommand { get; private set; }

        public CoinViewModel() {

        }

        public ICommand FlipCommand => new Command(() => { _Resultado = new Coin().Jogar(); });

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
