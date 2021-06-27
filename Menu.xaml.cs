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
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadFunc_Click(object sender, RoutedEventArgs e)
        {
            CadastrarFuncionarios cadFuncionarios = new CadastrarFuncionarios();
            cadFuncionarios.Show();
        }

        private void fabProd_Click(object sender, RoutedEventArgs e)
        {
            FabricarProdutos fabProdutos = new FabricarProdutos();
            fabProdutos.Show();
        }

        private void pagDesp_Click(object sender, RoutedEventArgs e)
        {
            PagarDespesas pagDesp = new PagarDespesas();
            pagDesp.Show();
        }
    }
}
