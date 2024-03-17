using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FormulaCuadraticaMvvm.Models;
using System;

namespace FormulaCuadraticaMvvm.ViewModels
{
    public partial class FormulaCuadraticaViewModel : ObservableObject
    {
        private double _a;
        private double _b;
        private double _c;
        private string? _resultado;

        public double A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }

        public double B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }

        public double C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public string Resultado
        {
            get => _resultado;
            set => SetProperty(ref _resultado, value);
        }

        public bool PuedeCalcular => A != 0 && B != 0 && C != 0;

        [RelayCommand]
        public void Calcular()
        {
            try
            {
                var formula = new FormulaCuadratica();
                formula.A = A;
                formula.B = B;
                formula.C = C;
                Resultado = formula.Calcular();
            }
            catch (Exception ex)
            {
                Resultado = ex.Message;
            }
        }

        [RelayCommand]
        public void Limpiar()
        {
            A = 0;
            B = 0;
            C = 0;
            Resultado = string.Empty;
        }
    }
}
