using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using ScreenBuilder.Factories;

namespace ScreenBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> componentCodes;
        HTMLFactory HTMLFactory;
        XAMLFactory XAMLFactory;

        public MainWindow()
        {
            InitializeComponent();

            componentCodes = new List<string>();
            HTMLFactory = new HTMLFactory();
            XAMLFactory = new XAMLFactory();
        }

        private void btnRemoveElement_Click(object sender, RoutedEventArgs e)
        {
            if (componentCodes.Count != 0)
            {
                componentCodes.RemoveAt(componentCodes.Count - 1);
                UpdateOutputText();
            }
        }

        private void btnAddButton_Click(object sender, RoutedEventArgs e)
        {
            switch (outputLanguage.SelectedValue.ToString())
            {
                case "HTML":
                    componentCodes.Add(HTMLFactory.CreateButton(txtContent.Text, 
                                                                float.Parse(txtHeight.Text), 
                                                                float.Parse(txtWidth.Text), 
                                                                float.Parse(txtTop.Text), 
                                                                float.Parse(txtLeft.Text)));
                    break;
                case "XAML":
                    componentCodes.Add(XAMLFactory.CreateButton(txtContent.Text,
                                                                float.Parse(txtHeight.Text),
                                                                float.Parse(txtWidth.Text),
                                                                float.Parse(txtTop.Text),
                                                                float.Parse(txtLeft.Text)));
                    break;
            }
            UpdateOutputText();
        }

        private void btnAddTextBlock_Click(object sender, RoutedEventArgs e)
        {
            switch (outputLanguage.SelectedValue.ToString())
            {
                case "HTML":
                    componentCodes.Add(HTMLFactory.CreateTextBox(txtContent.Text,
                                                                float.Parse(txtHeight.Text),
                                                                float.Parse(txtWidth.Text),
                                                                float.Parse(txtTop.Text),
                                                                float.Parse(txtLeft.Text)));
                    break;
                case "XAML":
                    componentCodes.Add(XAMLFactory.CreateTextBox(txtContent.Text,
                                                                float.Parse(txtHeight.Text),
                                                                float.Parse(txtWidth.Text),
                                                                float.Parse(txtTop.Text),
                                                                float.Parse(txtLeft.Text)));
                    break;
            }
            UpdateOutputText();
        }

        private void UpdateOutputText()
        {
            string output = "";

            foreach(var comp in componentCodes)
            {
                output += $"{comp}\n";
            }

            txtOutput.Text = output;
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
