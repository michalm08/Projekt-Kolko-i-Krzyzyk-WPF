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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kolko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int Znak = 0;
        int IleX = 0;
        int IleO = 0;
        

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (Znak % 2 == 0)
                bt1.Content = "X";
            else
                bt1.Content = "O";
            Znak++;
            CzyWygranko();
            KtoTo();
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (Znak % 2 == 0)
                bt2.Content = "X";
            else
                bt2.Content = "O";
            Znak++;
            CzyWygranko();
            KtoTo();
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (Znak % 2 == 0)
                bt3.Content = "X";
            else
                bt3.Content = "O";
            Znak++;
            CzyWygranko();
            KtoTo();
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (Znak % 2 == 0)
                bt4.Content = "X";
            else
                bt4.Content = "O";
            Znak++;
            CzyWygranko();
            KtoTo();
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (Znak % 2 == 0)
                bt5.Content = "X";
            else
                bt5.Content = "O";
            Znak++;
            CzyWygranko();
            KtoTo();
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (Znak % 2 == 0)
                bt6.Content = "X";
            else
                bt6.Content = "O";
            Znak++;
            CzyWygranko();
            KtoTo();
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            if (Znak % 2 == 0)
                bt7.Content = "X";
            else
                bt7.Content = "O";
            Znak++;
            CzyWygranko();
            KtoTo();
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            if (Znak % 2 == 0)
                bt8.Content = "X";
            else
                bt8.Content = "O";
            Znak++;
            CzyWygranko();
            KtoTo();
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            if (Znak % 2 == 0)
                bt9.Content = "X";
            else
                bt9.Content = "O";
            Znak++;
            CzyWygranko();
            KtoTo();
        }


        private void CzyWygranko()
        {

            if ((bt1.Content == "X" && bt2.Content == "X" && bt3.Content == "X" ||
                bt4.Content == "X" && bt5.Content == "X" && bt6.Content == "X" ||
                bt7.Content == "X" && bt8.Content == "X" && bt9.Content == "X" ||
                bt1.Content == "X" && bt4.Content == "X" && bt7.Content == "X" ||
                bt2.Content == "X" && bt5.Content == "X" && bt8.Content == "X" ||
                bt3.Content == "X"  && bt6.Content == "X" && bt9.Content == "X" ||
                bt1.Content == "X" && bt5.Content == "X" && bt9.Content == "X" ||
                bt3.Content == "X" && bt5.Content == "X" && bt7.Content == "X"))
            {
                MessageBox.Show("Wygral X");
                Zerowanie();
                IleX++;
                lbX.Content = "Gracz X:" + IleX;
            }

            if ((bt1.Content == "O" && bt2.Content == "O" && bt3.Content == "O" ||
                bt4.Content == "O" && bt5.Content == "O" && bt6.Content == "O" ||
                bt7.Content == "O" && bt8.Content == "O" && bt9.Content == "O" ||
                bt1.Content == "O" && bt4.Content == "O" && bt7.Content == "O" ||
                bt2.Content == "O" && bt5.Content == "O" && bt8.Content == "O" ||
                bt3.Content == "O" && bt6.Content == "O" && bt9.Content == "O" ||
                bt1.Content == "O" && bt5.Content == "O" && bt9.Content == "O" ||
                bt3.Content == "O" && bt5.Content == "O" && bt7.Content == "O"))
            {
                MessageBox.Show("Wygral O");
                Zerowanie();
                IleO++;
                lbO.Content = "Gracz O:" + IleO;
            }

        }

        private void Zerowanie()
        {
            bt1.Content = "";
            bt2.Content = "";
            bt3.Content = "";
            bt4.Content = "";
            bt5.Content = "";
            bt6.Content = "";
            bt7.Content = "";
            bt8.Content = "";
            bt9.Content = "";
        }

        private void KtoTo()
        {
            if (Znak%2==0)
                lbKto.Content = "Teraz Gracz X";
            else
                lbKto.Content = "Teraz Gracz O";
        }

        private void btReset_Click(object sender, RoutedEventArgs e)
        {
            Znak = 0;
            IleX = 0;
            IleO = 0;
            lbX.Content= "Gracz X:"+IleX;
            lbO.Content = "Gracz O:"+IleO;

        }
    }
}
