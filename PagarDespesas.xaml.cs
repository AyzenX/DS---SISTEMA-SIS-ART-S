using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace projetoSISARTS
{
    /// <summary>
    /// Lógica interna para PagarDespesas.xaml
    /// </summary>
    public partial class PagarDespesas : Window
    {
        public string[] despesasCadastradas { get; set; }

        public PagarDespesas()
        {
            InitializeComponent();

            despesasCadastradas = new string[] { "Água", "Luz",};

            DataContext = this;
        }

        private void btnPagar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("O pagamento da despesa foi realizado com sucesso !!");
            this.Close();
            
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja cancelar o pagamento da despesa ??", "Cancelar Pagamento", MessageBoxButton.YesNo,MessageBoxImage.Question );

            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    break;
            }
            
            
        }
    }
}
