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

namespace Wpf_Basics
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is - {this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckBox.IsChecked = this.AssemblyCheckBox.IsChecked = this.PlasmaCheckBox.IsChecked 
                = this.LaserCheckBox.IsChecked = this.PurchaseCheckBox.IsChecked = this.LatheCheckBox.IsChecked
                = this.DrillCheckBox.IsChecked = this.FoldCheckBox.IsChecked = this.RollCheckBox.IsChecked
                = this.SawCheckBox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //Once we tick our checkboxes the item appear in our length
            this.LengthText.Text += ((CheckBox)sender).Content; //adding and casting(string)((CheckBox)sender) instead of be an object
        }

        private void FinishDropDown_SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null) return;
            var combo = (ComboBox)sender; //casting
            var value = (ComboBoxItem)combo.SelectedValue; //casting 
            this.NoteText.Text = (string)value.Content; //
            //this.NoteText.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropDown_SelectionChange(this.FinishDropDown, null);
        }

        private void SuppplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassText.Text = this.SuppplierNameText.Text;
        }
    }
}
