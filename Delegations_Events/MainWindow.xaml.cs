using DelegateLib;
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
using UCLib;

namespace Delegations_Events
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            MyModel modelForAll = new MyModel();
            foreach (var item in mainGrid.Children)
            {
                if (item is MyUcInterface)
                {
                    (item as MyUcInterface).UCModel = modelForAll;
                    modelForAll.ValueChangedInformOthers += (item as MyUcInterface).ValueChangeFromOutside;
                }
              
            }
        }



            //foreach (UIElement item in mainGrid.Children)
            //{
            //    if (item is UCUpDDown)
            //    {
            //        foreach (UIElement eventRecieverElement in mainGrid.Children)
            //        {
            //            if (eventRecieverElement is UCUpDDown && item != eventRecieverElement)
            //            {

            //                (item as UCUpDDown).ValueChangedInformOthers += (eventRecieverElement as UCUpDDown).ValueChangeFromOutside;
            //            }
            //            else if (eventRecieverElement is UserControl1 && item != eventRecieverElement)
            //            {

            //                (item as UCUpDDown).ValueChangedInformOthers += (eventRecieverElement as UserControl1).ValueChangeFromOutside;
            //            }
            //        }
            //    }
            //    else if (item is UserControl1)
            //    {
            //       foreach(UIElement eventRecieverElement in mainGrid.Children)
            //        {
            //            if (eventRecieverElement is UCUpDDown && item != eventRecieverElement)
            //            {

            //                (item as UserControl1).ValueChangedInformOthers += (eventRecieverElement as UCUpDDown).ValueChangeFromOutside;
            //            }
            //            else if (eventRecieverElement is UserControl1 && item != eventRecieverElement)
            //            {

            //                (item as UserControl1).ValueChangedInformOthers += (eventRecieverElement as UserControl1).ValueChangeFromOutside;
            //            }
            //        }

            //    }

        
            //uc1.ValueChangedInformOthers += uc2.ValueChangeFromOutside;
            //uc1.ValueChangedInformOthers += uc3.ValueChangeFromOutside;

            //uc2.ValueChangedInformOthers += uc1.ValueChangeFromOutside;
            //uc2.ValueChangedInformOthers += uc3.ValueChangeFromOutside;

            //uc3.ValueChangedInformOthers += uc1.ValueChangeFromOutside;
            //uc3.ValueChangedInformOthers += uc2.ValueChangeFromOutside;

        }
    }

