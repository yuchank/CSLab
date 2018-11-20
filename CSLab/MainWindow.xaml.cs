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

namespace CSLab
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

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
      Vector v1 = new Vector();   // new
      Vector v2;                  // it also works, but all fields must be assigned.

      v2.x = 5;
      v2.y = 10;

      Vector v3 = v2;

      Console.WriteLine(v1);
      Console.WriteLine(v2);
      Console.WriteLine(v3);

      Change(ref v3);
      Console.WriteLine(v3);

      Point pt1 = new Point(6, 12);
      Point pt2 = pt1;

      pt2.x = 7;
      pt2.y = 22;

      Console.WriteLine("pt1: " + pt1);
      Console.WriteLine("pt2: " + pt2);
    }
    
    // pass by reference
    void Change(ref Vector v)
    {
      v.x = 99;
      v.y = 99;
    }

    // pass by reference
    bool Divide(int n1, int n2, out int result)
    {
      // out parameter 'result' must be assigned to.
      if (n1 == 0)
      {
        result = 0;
        return false;
      }
      result = n1 / n2;
      return true;
    }
  }

  struct Vector
  {
    public int x;
    public int y;

    // struct cannot contain explicit parameterless constructors

    public Vector(int x, int y)
    {
      // all fields must be fully assigned
      this.x = x;
      this.y = y;
    }

    public override string ToString()
    {
      return "x: " + x + ", y: " + y;
    }
  }

  struct Point
  {
    public int x;
    public int y;

    public Point(int x, int y)
    {
      // all fields must be fully assigned
      this.x = x;
      this.y = y;
    }

    public override string ToString()
    {
      return "x: " + x + ", y: " + y;
    }
  }
}
