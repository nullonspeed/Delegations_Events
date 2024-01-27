using DelegateLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UCLib
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UCUpDDown : UserControl, MyUcInterface
    {
        //public event MyValueChangedDelegate? ValueChangedInformOthers;
       
        public MyModel UCModel { get; set; }
       

        public UCUpDDown()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button)
            {
                Button? btnSender= sender as Button;
                if(Double.TryParse(btnSender?.Tag.ToString(), out double delta) && UCModel !=null )
                {
                    UCModel.ModelValue += delta;
                }
            }
        }

        public void ValueChangeFromOutside(object sender, MyEventArgs e)
        {
            if(UCModel != null)
            {
                lbl_Value.Content = e.Value.ToString("#0.00");
            }
  
        }
    }
}