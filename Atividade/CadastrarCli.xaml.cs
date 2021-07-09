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
using System.Text.RegularExpressions;

namespace projetoSISARTS
{
    /// <summary>
    /// Lógica interna para CadastrarCli.xaml
    /// </summary>
    public partial class CadastrarCli : Window
    {
        public CadastrarCli()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja salvar um novo Cliente? Perderá todos os dados não salvos!", "Mensagem de Alerta", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                nome.Text = "";
                cpf.Text = "";
                RG.Text = "";
                estado.Text = "";
                cidade.Text = "";
                Bairro.Text = "";
                telefone.Text = "";
                numero.Text = "";
                Rua.Text = "";
                MessageBox.Show("Cadastre o novo Cliente");


            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Cliente Salvo com Sucesso!!", "Mensagem de Confirmação");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Usuário excluído com Sucesso!!", "Mensagem de Confirmação");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
