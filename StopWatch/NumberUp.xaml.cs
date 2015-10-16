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

namespace StopWatch
{
    /// <summary>
    /// NumberUp.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NumberUp : UserControl
    {
        public NumberUp()
        {
            InitializeComponent();
            Values = 0;
            tb_text.Text = Values.ToString();
        }
        public int Values
        {
            get;
            set;
        }
        private void tb_up_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Values = int.Parse(tb_text.Text);
            Values++;
            tb_text.Text = Values.ToString();
        }
        private void tb_down_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Values = int.Parse(tb_text.Text);
            Values--;
            tb_text.Text = Values.ToString();
        }
        string IntParsing(string text)
        {
            string value = string.Empty;
            foreach(char c in text.ToArray())
            {
                if (char.IsNumber(c))
                    value += c;
            }
            return value == string.Empty ? "0" : value;
        }

        private void tb_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            tb_text.Text = IntParsing(tb_text.Text);
            Values = int.Parse(tb_text.Text);
            tb_text.SelectionStart = tb_text.Text.Length;
            tb_text.SelectionLength = tb_text.Text.Length;
        }
    }
}
