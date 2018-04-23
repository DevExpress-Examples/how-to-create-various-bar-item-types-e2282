using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace BarItems_Ex {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            staticItemPos.Content = "Page 1/1";
            staticItemDocName.Content = "Document1.txt";
        }

        private void itemBold_CheckedChanged(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            MessageBox.Show("The Bold item has been toggled");
        }

    }
}
