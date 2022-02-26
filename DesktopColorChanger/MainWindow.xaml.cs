using Microsoft.Win32;
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

namespace DesktopColorChanger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RegistryColors colorEditor;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClrPcker_Background_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            clrPicker.SelectedColor = Colors.White;
            cboField.SelectedIndex = 0;
            colorEditor = new RegistryColors();
            cboField.ItemsSource = Enum.GetValues(typeof(RegistryColors.Property)).Cast<RegistryColors.Property>();
        }

        private void cboField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(cboField.SelectedItem);
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            string newColor = $"{clrPicker.SelectedColor.Value.R} {clrPicker.SelectedColor.Value.G} {clrPicker.SelectedColor.Value.B}";
            colorEditor.SetColor((RegistryColors.Property)cboField.SelectedItem, newColor);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            colorEditor.ResetColor((RegistryColors.Property)cboField.SelectedItem);
            clrPicker.SelectedColor = Colors.White;
        }
    }

    class RegistryColors
    {
        private Dictionary<Property, string> defaults = new Dictionary<Property, string>();
        public readonly Dictionary<Property, string> Colors;
        #region definitions
        public enum Property
        {
            ActiveBorder, 
            ActiveTitle, 
            AppWorkSpace, 
            Button, 
            AlternateFace, 
            ButtonDkShadow, 
            ButtonFace, 
            ButtonHilight, 
            ButtonLight, 
            ButtonShadow, 
            ButtonText, 
            GradientActiveTitle,
            GradientInactiveTitle, 
            GrayText, 
            Hilight, 
            HilightText, 
            HotTrackingColor, 
            InactiveBorder, 
            InactiveTitle, 
            InactiveTitleText, 
            InfoText, 
            InfoWindow, 
            Menu, 
            MenuText, 
            Scrollbar, 
            TitleText,
            Window, 
            WindowFrame, 
            WindowText
        }

        string[] values = new string[]
        {
            "212 208 200",
            "10 36 106",
            "128 128 128",
            "181 181 181",
            "64 64 64",
            "212 208 200",
            "255 255 255",
            "212 208 200",
            "128 128 128",
            "0 0 0",
            "166 202 240",
            "192 192 192",
            "128 128 128",
            "10 36 106",
            "255 255 255",
            "0 0 128",
            "212 208 200",
            "128 128 128",
            "212 208 200",
            "0 0 0",
            "255 255 255",
            "212 208 200",
            "0 0 0",
            "212 208 200",
            "255 255 255",
            "255 255 255",
            "0 0 0",
            "0 0 0"
        };
        #endregion

        public RegistryColors()
        {
            for(int i = 0; i < values.Length; i++)
            {
                defaults.Add((Property)i, values[i]);
            }

            Colors = new Dictionary<Property, string>(defaults);
        }

        public void SetColor(Property property, string rgb)
        {
            Colors[property] = rgb;
            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\Colors", property.ToString(), Colors[property]);
        }

        public string GetColor(Property property)
        {
            return Colors[property];
        }

        public void ResetColor(Property property)
        {
            Colors[property] = defaults[property];
            Console.WriteLine("Resetting to " + Colors[property]);
            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\Colors", property.ToString(), Colors[property]);
        }
    }
}
