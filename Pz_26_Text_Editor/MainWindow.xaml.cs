using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Microsoft.Win32;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace TextEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            richTextBox.TextChanged += (sender, e) =>
            {
                richTextBox.Document.LineHeight = 0.1 * richTextBox.FontSize;
            };
            richTextBox.PreviewKeyDown += richTextBox_PreviewKeyDown;
            DataContext = new ViewModel();
            fileList.SelectionChanged += fileList_SelectionChanged;
        }
        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void New_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Document = new FlowDocument();
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                string fileText = File.ReadAllText(fileName);
                richTextBox.Document = new FlowDocument(new Paragraph(new Run(fileText)));
            }
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.InitialDirectory = @"C:\Users\79228\source\repos\Shmidt_Anton\Pz_26_Text_Editor\data";
            if (saveFileDialog.ShowDialog() == true)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Text);
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Document = new FlowDocument();
        }
        private void richTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                TextPointer caret = richTextBox.CaretPosition;
                caret.InsertTextInRun("\t");
                richTextBox.CaretPosition = caret.GetPositionAtOffset(1);
                e.Handled = true;
            }
        }
        private void Italic_Click(object sender, RoutedEventArgs e)
        {
            var currentValue = richTextBox.Selection.GetPropertyValue(Inline.FontStyleProperty);
            if (currentValue != DependencyProperty.UnsetValue && currentValue.Equals(FontStyles.Italic))
                richTextBox.Selection.ApplyPropertyValue(Inline.FontStyleProperty, FontStyles.Normal);
            else
                richTextBox.Selection.ApplyPropertyValue(Inline.FontStyleProperty, FontStyles.Italic);
        }
        private void Bold_Click(object sender, RoutedEventArgs e)
        {
            var currentValue = richTextBox.Selection.GetPropertyValue(Inline.FontWeightProperty);
            if (currentValue != DependencyProperty.UnsetValue && currentValue.Equals(FontWeights.Bold))
                richTextBox.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Normal);
            else
                richTextBox.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Bold);
        }
        private void Underline_Click(object sender, RoutedEventArgs e)
        {
            var currentValue = richTextBox.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            if (currentValue != DependencyProperty.UnsetValue && currentValue.Equals(TextDecorations.Underline))
                richTextBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
            else
                richTextBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создатель: Шмидт Антон, поддержите юного таланта хорошей оценкой, его будущее в ваших руках!");
        }
        public class ViewModel
        {
            public ObservableCollection<string> Files { get; set; }

            public ViewModel()
            {
                Files = new ObservableCollection<string>();
                string[] fileEntries = Directory.GetFiles(@"C:\Users\79228\source\repos\Shmidt_Anton\Pz_26_Text_Editor\data\", "*.txt");
                foreach (string fileName in fileEntries)
                {
                    Files.Add(Path.GetFileName(fileName));
                }
            }
        }
        private void fileList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fileList.SelectedItem != null)
            {
                string fileName = fileList.SelectedItem.ToString();
                string filePath = Path.Combine(@"C:\Users\79228\source\repos\Shmidt_Anton\Pz_26_Text_Editor\data", fileName);
                string fileText = File.ReadAllText(filePath);
                richTextBox.Document = new FlowDocument(new Paragraph(new Run(fileText)));
            }
        }
    }
}