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

namespace MagicSquare
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

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (tbxSize.Text != "")
            {
                GenerateGrid(MagicSquareGenerator.Generate(Convert.ToInt32(tbxSize.Text)));
            }
        }

        private void GenerateGrid(List<List<int>> matrix)
        {
            Grid magicGrid = new Grid();

            for (int i = 0; i < matrix.Count; i++)
            {
                magicGrid.ColumnDefinitions.Add(new ColumnDefinition());
                magicGrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix.Count; j++)
                {
                    TextBlock tb = new TextBlock
                    {
                        Text = matrix[i][j].ToString(),
                        FontSize = 18,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center
                    };

                    Grid.SetRow(tb, i);
                    Grid.SetColumn(tb, j);
                    magicGrid.Children.Add(tb);
                }
            }

            magicGrid.ShowGridLines = true;
            
            grid.Children.Clear();
            grid.Children.Add(magicGrid);
        }
    }
}
