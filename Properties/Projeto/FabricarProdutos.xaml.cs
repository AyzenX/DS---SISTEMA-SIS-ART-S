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
    /// Lógica interna para FabricarProdutos.xaml
    /// </summary>
    public partial class FabricarProdutos : Window
    {
        public FabricarProdutos()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public class Produtos
        {
            public String produtoID { get; set; }
            public String produtoLinhaDeProducao { get; set; }
            public String produtoQTD { get; set; }
        }

        private void Adicionar(object sender, RoutedEventArgs e)
        {
            String LinhaDeProducao = txNomeProduto.Text;
            String ProdutoQTD = txQuantidade.Text;

            Produtos produtos = new Produtos();

            //Por hora não captura ID, pois deve o id atribuido do Cadastro de Produtos
            produtos.produtoLinhaDeProducao = LinhaDeProducao;
            produtos.produtoQTD = ProdutoQTD;

            DataGridProdutos.Items.Add(produtos);
        }

        private void Sair(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Produzir(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Produtos adicionados à linha de produção");
        }

        private void Remover(object sender, RoutedEventArgs e)
        {
        }
    }
}
