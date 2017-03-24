using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace FunWithSystemWindowsShapes
{
  /// <summary>
  /// Interaction logic for Window1.xaml
  /// </summary>

  public partial class MainWindow : System.Windows.Window
  {

    public MainWindow()
    {
      InitializeComponent();
    }
    protected void SimpleLine_MouseEnter(object sender, MouseEventArgs args)
    {
      this.Title = String.Format("Mouse entered at: {0}", 
        args.GetPosition(SimpleLine));
    }
  }
}