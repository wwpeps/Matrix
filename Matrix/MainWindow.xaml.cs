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

namespace Matrix
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ggr_Click(object sender, RoutedEventArgs e)
        {
            st.a11 = Convert.ToInt32(q.Text);
            st.a12 = Convert.ToInt32(w.Text);
            st.a13 = Convert.ToInt32(d.Text);
            st.a21 = Convert.ToInt32(r.Text);
            st.a22 = Convert.ToInt32(t.Text);
            st.a23 = Convert.ToInt32(y.Text);
            st.a31 = Convert.ToInt32(u.Text);
            st.a32 = Convert.ToInt32(i.Text);
            st.a33 = Convert.ToInt32(o.Text);
            st.res = st.a11 * st.a12 * st.a13 + st.a21  *  st.a22 *  st.a23 +  st.a31 *  st.a32 * st.a33;
            arg.Text += "= " + st.a11.ToString() + " * " + st.a12.ToString() + " * " + st.a13.ToString() + Environment.NewLine + " + " + st.a21.ToString()  + " * " + st.a22.ToString() + " * " + st.a23.ToString() + Environment.NewLine + " + " + st.a31.ToString() + " * " + st.a32.ToString() + " * " + st.a33.ToString() + Environment.NewLine + st.res.ToString();

        }
    }
}
