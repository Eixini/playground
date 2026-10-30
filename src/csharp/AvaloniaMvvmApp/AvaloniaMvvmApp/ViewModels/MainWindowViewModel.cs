using AvaloniaMvvmApp.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AvaloniaMvvmApp.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject {
        // DataBinding для блока Лейбла с кнопками
        [ObservableProperty]
        private string labelTwoButtons = "Text two buttons";
        public string YesButton { get; } = "Yes";
        public string NoButton { get; } = "No";

        [RelayCommand]
        private void YesButtonClick() {

            LabelTwoButtons = "Yes";
        }

        [RelayCommand]
        private void NoButtonClick() {
            LabelTwoButtons = "No";
        }

        // DataBinding для блока с Радио кнопками
        [ObservableProperty]
        private string selectedTextRB = "Label RB";
        public string RadioButton1 { get; } = "RB 1";
        public string RadioButton2 { get; } = "RB 2";
        public string RadioButton3 { get; } = "RB 3";

        [ObservableProperty]
        private bool _isOption1;

        [ObservableProperty]
        private bool _isOption2;

        [ObservableProperty]
        private bool _isOption3;

        partial void OnIsOption1Changed(bool value) {
            if (value) {
                SelectedTextRB = RadioButton1;
                IsOption2 = false;
                IsOption3 = false;
            }
        }

        partial void OnIsOption2Changed(bool value) {
            if (value) {
                SelectedTextRB = RadioButton2;
                IsOption1 = false;
                IsOption3 = false;
            }
        }

        partial void OnIsOption3Changed(bool value) {
            if (value) {
                SelectedTextRB = RadioButton3;
                IsOption1 = false;
                IsOption2 = false;
            }
        }

        // DataBinding для блока с Чекбоксами
        [ObservableProperty]
        private bool _isCheckBox1;

        [ObservableProperty]
        private bool _isCheckBox2;

        [ObservableProperty]
        private bool _isCheckBox3;

        public string CheckBox1 { get; } = "CheckBox 1";
        public string CheckBox2 { get; } = "CheckBox 2";
        public string CheckBox3 { get; } = "CheckBox 3";

        [ObservableProperty]
        private string checkBoxLabel1 = "Label 1";
        [ObservableProperty]
        private string checkBoxLabel2 = "Label 2";
        [ObservableProperty]
        private string checkBoxLabel3 = "Label 3";

        partial void OnIsCheckBox1Changed(bool value) {
            CheckBoxLabel1 = value.ToString();
        }

        partial void OnIsCheckBox2Changed(bool value) {
            CheckBoxLabel2 = value.ToString();
        }

        partial void OnIsCheckBox3Changed(bool value) {
            CheckBoxLabel3 = value.ToString();
        }

        // DataBinding для блока с ToggleButton
        [ObservableProperty]
        private string toggleButton = "Test";

        [RelayCommand]
        private void ToggleButtonClick() {
            ToggleButton = "Test, yes!";
        }

        // DataBinding для блока c TextBox
        [ObservableProperty]
        public string textBoxContent = "Test";
        [ObservableProperty]
        public string textEditLabel = "Test";
        public string ActionButton { get; } = "Action";

        [RelayCommand]
        private void ActionButtonClick() {
            TextBoxContent = String.Empty;
        }

        [RelayCommand]
        private void TextBoxChangedHandler() {
            TextEditLabel = TextBoxContent;
        }

        // DataBinding для блока c ComboBox
        [ObservableProperty]
        public string? comboBoxTextBox = "";
        public List<string> ColorList => ["Black", "White", "Blue", "Red", "Yellow"];
        public ObservableCollection<string> ShapeList { get; set; } = new();

        [RelayCommand]
        private void AddShape() {
            if (!string.IsNullOrEmpty(ComboBoxTextBox)) {
                ShapeList.Add(ComboBoxTextBox);
                ComboBoxTextBox = null;
            }
        }

        [RelayCommand]
        private void RemoveShape() {
            if (ShapeList.Count > 0) {
                ShapeList.RemoveAt(ShapeList.Count - 1);
            }
        }

        // DataBinding для блока c ListBox
        public ObservableCollection<string> CatList => ["Stella", "Vasya", "Chernish", "Kuzya"];

        // DataBinding для блока c DataGrid

        public ObservableCollection<DataGridItem> Persons { get; }

        public MainWindowViewModel() {

            var persons = new List<DataGridItem> {
            new("Paul", "Kekir", "Azazazaza lol kek"),
            new("Rick", "e4kil", "Mmm kusok"),
            new("Neo", "azazLol", "Warning! Warning!"),
            new("Klara", "cxcx312", "Lol kotosvalka")
            };

            Persons = new ObservableCollection<DataGridItem>(persons);
        }


    }
}
