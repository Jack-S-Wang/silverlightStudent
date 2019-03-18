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

namespace SilverlightData.ViewXaml
{
    public partial class JuageWindow : UserControl
    {
        public JuageWindow()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            formal.queryFormal.CustomControlBottomPanel.Visibility = Visibility.Collapsed;
            formal.queryFormal.ResultDataGrid.CheckCellEditable = (b, d, bd) => false;
        }
    }
}
