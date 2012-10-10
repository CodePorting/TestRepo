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

namespace WpfApplication2
{
    enum ProgressType
    {
        audioCDControl = 0,
        videoCDControl = 1,
        dataCDControl = 2,
        audioDVDControl = 3,
        videoDVDControl = 4,
        dataDVDControl = 5
    };
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        double stepSize;
        ProgressType cType;
        
        public UserControl1()
        {
            InitializeComponent();
        }

        public double UserControlProgressLimit
        {
            get { return this.rectTotal.Width; }
            set { 
                    this.rectTotal.Width = value;
                    this.stepSize = (int)this.rectTotal.Width / 100;
                }
        }

        public double UserControlProgressValue
        {
            get { return this.rectProgress.Width; }
            set {
                    double val = 100.0 / 280.0;
                    this.rectProgress.Width = val*value+25.0;
                    this.DisplayString();
                }
        }

        public double UserControlStepSize
        {
            get { return this.stepSize; }
            set { this.stepSize = value; }
        }

        public void IncrementProgress(int steps)
        {
            if (steps == 0)
                this.rectProgress.Width += stepSize;
            else
                this.rectProgress.Width += (steps * stepSize);
        }


        public void setControlType(int iType)
        {
            cType = (ProgressType)iType;
            this.DisplayString();
        }
        

        void DisplayString()
        {
            switch (cType)
            {
                case ProgressType.audioCDControl:
                    //TextValue.Text = "0min                20min                 40min                 80min                 100min                 120min";
                    //TextValue.Text = " 0min     10min     20min     30min    40min    50min    60min    70min   80min   90min   100min   110min    120min";
                    TextValue.Text = " 0min    10min    20min     30min    40min    50min    60min    70min  80min  90min 100min 110min 120min";
                    break;
                case ProgressType.videoCDControl:
                case ProgressType.dataCDControl:
                    //TextValue.Text = "0 Mb        100 Mb       200 Mb      300 Mb      400 Mb      500 Mb      600 Mb      700 Mb";
                    TextValue.Text = " 0Mb   100Mb    200Mb    300Mb   400Mb   500Mb   600Mb   700Mb";
                    break;
                case ProgressType.audioDVDControl:
                case ProgressType.videoDVDControl:
                case ProgressType.dataDVDControl:
                    TextValue.Text = "0 Gb       1 Gb        2Gb        3 Gb       4 Gb       5 Gb       6 Gb      7 Gb     8 Gb";
                    break;
               
            }
            //if (this.rectTotal.Width <= 300)
            //{
            //    //TextValue.Text = "0 Mb        100 Mb       200 Mb      300 Mb      400 Mb      500 Mb      600 Mb      700 Mb";
            //}
            //else
            //{
            //    //TextValue.Text = "0 Gb          1 Gb            2Gb           3 Gb           4 Gb           5 Gb          6 Gb           7 Gb          8 Gb";
            //}
        }

        private void TextValue_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void userControlProgress_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
