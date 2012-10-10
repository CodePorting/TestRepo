using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace WpfApplication2
{
    //enum ProgressType
    //{
    //    audioCDControl = 0,
    //    videoCDControl = 1,
    //    dataCDControl = 2,
    //    audioDVDControl = 3,
    //    videoDVDControl = 4,
    //    dataDVDControl = 5
    //};

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public static UserControl1 userControlP;
        public static void StaticMethod()
        {
            for (int i = 0; i < 30; i++)
            {
                userControlP.UserControlProgressValue = i * 20;
                Thread.Sleep(500);
            }
        }

        public Window1()
        {
            InitializeComponent();

            // for DVD 8 GB
            userControlProgress.UserControlProgressLimit = 450;
            userControlProgress.UserControlProgressValue = 15;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userControlProgress.setControlType(2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            userControlProgress.setControlType(0);
            //Timer timer = new Timer(new TimerCallback(CheckStatus), null, 0, 2000);           

            //userControlP = userControlProgress;
            //Thread progThread = new Thread(new ThreadStart(StaticMethod));

            //// Start the thread.
            //progThread.Start();
        }

        void CheckStatus(Object state)
        {
            userControlProgress.UserControlProgressValue = 200;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            userControlProgress.setControlType(5);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            userControlProgress.setControlType(1);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            userControlProgress.setControlType(2);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            userControlProgress.UserControlProgressValue = 0;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            userControlProgress.UserControlProgressValue = 100;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            userControlProgress.UserControlProgressValue = 200;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            userControlProgress.UserControlProgressValue = 300;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            userControlProgress.UserControlProgressValue = 400;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            userControlProgress.UserControlProgressValue = 500;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            userControlProgress.UserControlProgressValue = 600;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            userControlProgress.UserControlProgressValue = 700;
        }
    }
}
