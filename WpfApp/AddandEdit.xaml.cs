using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для AddandEdit.xaml
    /// </summary>
    public partial class AddandEdit : Window
    {
        private readonly MainWindow _main;
        private const string path = @"D:\repository\ООП\OOP_labs\OOP_labs\Lab8\text.txt";

        /// <summary>
        /// Initializes a new instance of the <see cref="AddandEdit"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public AddandEdit(MainWindow main)
        {
            InitializeComponent();
            _main = main;
            TypeShape.Items.Add("окружность");
            TypeShape.Items.Add("прямоугольник");
            TypeShape.SelectedIndex = 0;
            if (main.ShapeList.SelectedItem != null) EditInitialize();
        }

        private void EditInitialize()
        {
            string[] info = _main.ShapeList.SelectedItem.ToString().Split(new char[] { ' ' });
            if (info[1] == "окружность")
            {
                radiusText.Visibility = Visibility.Visible;
                labelRadius.Visibility = Visibility.Visible;
                labelx.Content = "x";
                labely.Content = "y";
                xText.Text = info[2];
                yText.Text = info[3];
                radiusText.Text = info[4];
                colorText.Text = info[5];

            }
            if (info[1] == "прямоугольник")
            {
                radiusText.Visibility = Visibility.Hidden;
                labelRadius.Visibility = Visibility.Hidden;
                labelx.Content = "Ширина";
                labely.Content = "Высота";
                xText.Text = info[2];
                yText.Text = info[3];
                colorText.Text = info[4];
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WriteFlatToFile(path);
            _main.InitShapes(path);
            _main.InitializeList();
            Close();
        }

        private void Eddit_Click(object sender, RoutedEventArgs e)
        {
            ChangeInFile(path, false);
            _main.InitShapes(path);
            _main.InitializeList();
            Close();
        }

        private void ChangeInFile(string inputPath, bool isForDelete)
        {
            string outputPath = inputPath.Split('.')[0] + " - tmp.txt";
            int ind = _main.ShapeList.SelectedIndex;

            using (StreamReader input = new StreamReader(inputPath))
            using (StreamWriter output = new StreamWriter(outputPath))
            {
                string line;
                int i = 0;
                while ((line = input.ReadLine()) != null)
                {
                    if (i != ind)
                        output.WriteLine(line);
                    else if (!isForDelete)
                        output.WriteLine(InitializeTextBox());
                    i += 1;
                }
            }
            FileInfo fileToDelete = new FileInfo(inputPath);
            fileToDelete.Delete();
            FileInfo fileToRename = new FileInfo(outputPath);
            fileToRename.MoveTo(inputPath);
        }

        private void WriteFlatToFile(string path)
        {
            using (StreamWriter stream = new StreamWriter(path, true)) //Инициализация массивов
            {
                stream.WriteLine(InitializeTextBox());
            }
        }

        private string InitializeTextBox()
        {
            if (TypeShape.Text == "окружность")
                return $"{TypeShape.Text} {xText.Text} {yText.Text} {radiusText.Text} {colorText.Text} ";
            else if (TypeShape.Text == "прямоугольник") return $"{TypeShape.Text} {xText.Text} {yText.Text} {colorText.Text} ";
            else return null;
        }

        private void TypeShape_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TypeShape.SelectedIndex == 1)
            {
                radiusText.Visibility = Visibility.Hidden;
                labelRadius.Visibility = Visibility.Hidden;
                labelx.Content = "Ширина";
                labely.Content = "Высота";
            }
            else
            {
                radiusText.Visibility = Visibility.Visible;
                labelRadius.Visibility = Visibility.Visible;
                labelx.Content = "x";
                labely.Content = "y";
            }
        }

        private void XText_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex number = new Regex(@"^\d+$");
            if (!number.IsMatch(xText.Text)) xText.Text = "";
        }

        private void YText_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex number = new Regex(@"^\d+$");
            if (!number.IsMatch(xText.Text)) xText.Text = "";
        }

        private void RadiusText_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex number = new Regex(@"^\d+$");
            if (!number.IsMatch(xText.Text)) xText.Text = "";
        }
    }
}