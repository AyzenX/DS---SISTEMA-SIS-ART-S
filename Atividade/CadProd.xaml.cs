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
    /// Lógica interna para CadProd.xaml
    /// </summary>
    public partial class CadProd : Window
    {
        public CadProd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja salvar um novo Produto? Perderá todos os dados não salvos!", "Mensagem de Alerta", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
               codigo.Text = "";
               valor.Text = "";
               titulo.Text = "";
               desc.Text = "";                
                MessageBox.Show("Cadastre o novo Produto");


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Cliente Excluído com Sucesso!!", "Mensagem de Confirmação");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Cliente Salvo com Sucesso!!", "Mensagem de Confirmação");
        }
    }
}
