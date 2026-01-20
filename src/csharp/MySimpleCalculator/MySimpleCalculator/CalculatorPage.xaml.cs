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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MySimpleCalculator; 

public partial class CalculatorPage : Page {
    public CalculatorPage() {
        InitializeComponent();

    }

    /// <summary>
    /// Переменная для хранения промежуточного результата до знака
    /// </summary>
    string bufferVariable = "";

    /// <summary>
    /// Для хранения цифр после знака
    /// </summary>
    string bufferAfterSign = "";

    /// <summary>
    /// Переменная для хранения результата
    /// </summary>
    double resultVariable = 0;

    /// <summary>
    /// Для хранениния текущей операции при вводе новых цифр.
    /// </summary>
    char bufferOperation = ' ';

    /// <summary>
    /// Переменная чисто для демонстрации в превью
    /// </summary>
    string previewBuffer = "";


    private void ACButton_Click(object sender, RoutedEventArgs e) {
        PreviewText.Clear();
        ResultText.Clear();

        bufferAfterSign = "";
        bufferVariable = "";
        resultVariable = 0;
        bufferOperation = ' ';
        previewBuffer = "";
    }

    private void Button_Click(object sender, RoutedEventArgs e) {

    }

    private void PercentButton_Click(object sender, RoutedEventArgs e) {
        bufferOperation = '%';

        previewBuffer += "%";

        PreviewText.Text = previewBuffer;
    }

    private void DivisionButton_Click(object sender, RoutedEventArgs e) {
        bufferOperation = '/';

        previewBuffer += "/";

        PreviewText.Text = previewBuffer;
    }

    private void Button7_Click(object sender, RoutedEventArgs e) {
        
        if (bufferOperation == ' ') {
            bufferVariable += "7";
        }
        else {
            bufferAfterSign += "7";
        }

        previewBuffer += "7";

        PreviewText.Text = previewBuffer;

        // Если в буффере есть операция //////////////////
        if (bufferOperation != ' ' && bufferVariable != "") {
            switch (bufferOperation) {
                case '%': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = (numberBefore * numberAfter) / 100;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '/': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            if (numberAfter != 0)
                                resultVariable = numberBefore / numberAfter;
                            else
                                ResultText.Text = "ERROR!";
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '*': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore * numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '-': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore - numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '+': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore + numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
            }

            ResultText.Text = resultVariable.ToString();

        }
        // /////////////////////////////

    }

    private void Button8_Click(object sender, RoutedEventArgs e) {
        
        if (bufferOperation == ' ') {
            bufferVariable += "8";
        }
        else {
            bufferAfterSign += "8";
        }

        previewBuffer += "8";
        PreviewText.Text = previewBuffer;

        // Если в буффере есть операция //////////////////
        if (bufferOperation != ' ' && bufferVariable != "") {
            switch (bufferOperation) {
                case '%': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = (numberBefore * numberAfter) / 100;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '/': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            if (numberAfter != 0)
                                resultVariable = numberBefore / numberAfter;
                            else
                                ResultText.Text = "ERROR!";
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '*': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore * numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '-': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore - numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '+': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore + numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
            }

            ResultText.Text = resultVariable.ToString();

        }
        // /////////////////////////////

    }

    private void Button9_Click(object sender, RoutedEventArgs e) {
        
        if (bufferOperation == ' ') {
            bufferVariable += "9";
        }
        else {
            bufferAfterSign += "9";
        }

        previewBuffer += "9";
        PreviewText.Text = previewBuffer;

        // Если в буффере есть операция //////////////////
        if (bufferOperation != ' ' && bufferVariable != "") {
            switch (bufferOperation) {
                case '%': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = (numberBefore * numberAfter) / 100;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '/': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            if (numberAfter != 0)
                                resultVariable = numberBefore / numberAfter;
                            else
                                ResultText.Text = "ERROR!";
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '*': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore * numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '-': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore - numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '+': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore + numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
            }

            ResultText.Text = resultVariable.ToString();

        }
        // /////////////////////////////
    }

    private void MultiplicationButton_Click(object sender, RoutedEventArgs e) {
        bufferOperation = '*';
        previewBuffer += '*';

        PreviewText.Text = previewBuffer;
    }

    private void Button4_Click(object sender, RoutedEventArgs e) {

        if (bufferOperation == ' ') {
            bufferVariable += "4";
        }
        else {
            bufferAfterSign += "4";
        }

        previewBuffer += "4";
        PreviewText.Text = previewBuffer;

        // Если в буффере есть операция //////////////////
        if (bufferOperation != ' ' && bufferVariable != "") {
            switch (bufferOperation) {
                case '%': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = (numberBefore * numberAfter) / 100;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '/': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            if (numberAfter != 0)
                                resultVariable = numberBefore / numberAfter;
                            else
                                ResultText.Text = "ERROR!";
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '*': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore * numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '-': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore - numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '+': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore + numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
            }

            ResultText.Text = resultVariable.ToString();

        }
        // /////////////////////////////
    }

    private void Button5_Click(object sender, RoutedEventArgs e) {

        if (bufferOperation == ' ') {
            bufferVariable += "5";
        }
        else {
            bufferAfterSign += "5";
        }

        previewBuffer += "5";
        PreviewText.Text = previewBuffer;

        // Если в буффере есть операция //////////////////
        if (bufferOperation != ' ' && bufferVariable != "") {
            switch (bufferOperation) {
                case '%': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = (numberBefore * numberAfter) / 100;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '/': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            if (numberAfter != 0)
                                resultVariable = numberBefore / numberAfter;
                            else
                                ResultText.Text = "ERROR!";
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '*': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore * numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '-': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore - numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '+': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore + numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
            }

            ResultText.Text = resultVariable.ToString();

        }
        // /////////////////////////////
    }

    private void Button6_Click(object sender, RoutedEventArgs e) {

        if (bufferOperation == ' ') {
            bufferVariable += "6";
        }
        else {
            bufferAfterSign += "6";
        }

        previewBuffer += "6";
        PreviewText.Text = previewBuffer;

        // Если в буффере есть операция //////////////////
        if (bufferOperation != ' ' && bufferVariable != "") {
            switch (bufferOperation) {
                case '%': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = (numberBefore * numberAfter) / 100;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '/': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            if (numberAfter != 0)
                                resultVariable = numberBefore / numberAfter;
                            else
                                ResultText.Text = "ERROR!";
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '*': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore * numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '-': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore - numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '+': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore + numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
            }

            ResultText.Text = resultVariable.ToString();

        }
        // /////////////////////////////
    }

    private void SubtractionButton_Click(object sender, RoutedEventArgs e) {
        bufferOperation = '-';
        previewBuffer += "-";

        PreviewText.Text = previewBuffer;
    }

    private void Button1_Click(object sender, RoutedEventArgs e) {

        if (bufferOperation == ' ') {
            bufferVariable += "1";
        }
        else {
            bufferAfterSign += "1";
        }

        previewBuffer += "1";
        PreviewText.Text = previewBuffer;

        // Если в буффере есть операция //////////////////
        if (bufferOperation != ' ' && bufferVariable != "") {
            switch (bufferOperation) {
                case '%': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = (numberBefore * numberAfter) / 100;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '/': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            if (numberAfter != 0)
                                resultVariable = numberBefore / numberAfter;
                            else
                                ResultText.Text = "ERROR!";
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '*': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore * numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '-': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore - numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '+': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore + numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
            }

            ResultText.Text = resultVariable.ToString();

        }
        // /////////////////////////////
    }

    private void Button2_Click(object sender, RoutedEventArgs e) {

        if (bufferOperation == ' ') {
            bufferVariable += "2";
        }
        else {
            bufferAfterSign += "2";
        }

        previewBuffer += "2";
        PreviewText.Text = previewBuffer;

        // Если в буффере есть операция //////////////////
        if (bufferOperation != ' ' && bufferVariable != "") {
            switch (bufferOperation) {
                case '%': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = (numberBefore * numberAfter) / 100;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '/': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            if (numberAfter != 0)
                                resultVariable = numberBefore / numberAfter;
                            else
                                ResultText.Text = "ERROR!";
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '*': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore * numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '-': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore - numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '+': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore + numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
            }

            ResultText.Text = resultVariable.ToString();

        }
        // /////////////////////////////
    }

    private void Button3_Click(object sender, RoutedEventArgs e) {

        if (bufferOperation == ' ') {
            bufferVariable += "3";
        }
        else {
            bufferAfterSign += "3";
        }

        previewBuffer += "3";
        PreviewText.Text = previewBuffer;

        // Если в буффере есть операция //////////////////
        if (bufferOperation != ' ' && bufferVariable != "") {
            switch (bufferOperation) {
                case '%': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = (numberBefore * numberAfter) / 100;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '/': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            if (numberAfter != 0)
                                resultVariable = numberBefore / numberAfter;
                            else
                                ResultText.Text = "ERROR!";
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '*': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore * numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '-': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore - numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '+': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore + numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
            }

            ResultText.Text = resultVariable.ToString();

        }
        // /////////////////////////////
    }

    private void AdditionButton_Click(object sender, RoutedEventArgs e) {
        
        bufferOperation = '+';
        previewBuffer += "+";

        PreviewText.Text = previewBuffer;
    }

    private void SeparatorButton_Click(object sender, RoutedEventArgs e) {
        
        previewBuffer += ",";

        if (bufferOperation == ' ') {
            bufferVariable += ",";
        }
        else {
            bufferAfterSign += ",";
        }

        PreviewText.Text = previewBuffer;
    }

    private void Button0_Click(object sender, RoutedEventArgs e) {

        if (bufferOperation == ' ') {
            bufferVariable += "0";
        }
        else {
            bufferAfterSign += "0";
        }

        previewBuffer += "0";
        PreviewText.Text = previewBuffer;

        // Если в буффере есть операция //////////////////
        if (bufferOperation != ' ' && bufferVariable != "") {
            switch (bufferOperation) {
                case '%': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = (numberBefore * numberAfter) / 100;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '/': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            if (numberAfter != 0)
                                resultVariable = numberBefore / numberAfter;
                            else
                                ResultText.Text = "ERROR!";
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '*': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore * numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '-': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore - numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
                case '+': {
                        if ((double.TryParse(bufferVariable, out var numberBefore)) && (double.TryParse(bufferAfterSign, out var numberAfter))) {
                            resultVariable = numberBefore + numberAfter;
                        }
                        else {
                            ResultText.Text = "ERROR!";
                        }
                    }
                    break;
            }

            ResultText.Text = resultVariable.ToString();

        }
        // /////////////////////////////
    }

    private void ClearOneButton_Click(object sender, RoutedEventArgs e) {

        if(bufferVariable != "")
            bufferVariable = bufferVariable.Remove(bufferVariable.Length - 1, 1);

        if (previewBuffer != "")
            previewBuffer = previewBuffer.Remove(previewBuffer.Length - 1, 1);

        PreviewText.Text = bufferVariable;
    }

    private void EqualsButton_Click(object sender, RoutedEventArgs e) {
        // Сброс буффера операции
        bufferOperation = ' ';

        ResultText.Text = resultVariable.ToString();

        bufferVariable = resultVariable.ToString();

        previewBuffer = resultVariable.ToString();

        bufferAfterSign = "";

        resultVariable = 0;

        PreviewText.Text = previewBuffer;
    }
}
