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
    /// Lógica interna para Controle_Caixa.xaml
    /// </summary>
    public partial class Controle_Caixa : Window
    {
        public Controle_Caixa()
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
            MessageBoxResult result = MessageBox.Show("Categoria Turbantes selecionada!", "Mensagem de Confirmação");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Categoria Lembrancinhas selecionada!", "Mensagem de Confirmação");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Categoria Máscaras selecionada!", "Mensagem de Confirmação");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Categoria Laços selecionada!", "Mensagem de Confirmação");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Categoria Bebês selecionada!", "Mensagem de Confirmação");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Categoria Tiaras selecionada!", "Mensagem de Confirmação");
        }
    }
}
