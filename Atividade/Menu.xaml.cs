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

        private void recVend_Click(object sender, RoutedEventArgs e)
        {
            ReceberVenda recVend = new ReceberVenda();
            recVend.Show();
        }

        private void cadProd_Click(object sender, RoutedEventArgs e)
        {
            CadProd produto = new CadProd();
            produto.Show();
        }

        private void cadCli_Click(object sender, RoutedEventArgs e)
        {
            

            CadastrarCli cli = new CadastrarCli();
            cli.Show();
        }

        private void cadForn_Click(object sender, RoutedEventArgs e)
        {
            CadFornecedor fornec = new CadFornecedor();
            fornec.Show();
        }

        private void conCai_Click(object sender, RoutedEventArgs e)
        {
            Controle_Caixa caixa = new Controle_Caixa();
            caixa.Show();
            this.Close();
        }
    }
}
