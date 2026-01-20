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

namespace WorkingWithText;


public partial class TextAnalysisPage : Page {
    public TextAnalysisPage() {
        InitializeComponent();
    }

    private void TextAnalysis_Click(object sender, RoutedEventArgs e) {
        // Получение текста из поля ввода
        string enteredText = EntryTextBox.Text;

        // Резервирование данных
        int totalNumberOfCharacters = 0;    // Общее количество символов
        int numberOfSpaces = 0;             // Количество пробелов
        int numberOfWords = 0;              // Количество слов
        int numberOfVowels = 0;             // Количество гласных       ! ДЛЯ НЕКОТОРЫХ ЯЗЫКОВ !
        int numberOfConsonants = 0;         // Количество согласных     ! ДЛЯ НЕКОТОРЫХ ЯЗЫКОВ !

        // Определение массива глассных
        char[] allVowels = new char[] { 'a', 'o', 'e', 'u', 'i', 'у', 'ы', 'э', 'я', 'и'};

        // Подсчет количества символов
        for (int i = 0; i < enteredText.Length; i++) {
            totalNumberOfCharacters++;

            if (enteredText[i] == ' ') {
                numberOfSpaces++;
            }

            // Подсчет глассных и согласных
            if (Char.IsLetter(enteredText[i])) {
                if (allVowels.Contains(enteredText[i])) {
                    numberOfVowels++;
                } else {
                    numberOfConsonants++;
                }
            }
        }

        int charactersForAWord = 0; // Переменная для хранения количества последовательности символов, для определения еще является словом или нет

        // Подсчет количества слов
        for (int i = 0; i < enteredText.Length; i++) {

            if (Char.IsLetter(enteredText[i])) {
                charactersForAWord++;
            }

            if (!Char.IsLetter(enteredText[i]) && charactersForAWord != 0) {
                charactersForAWord = 0;

                numberOfWords++;
            }

            // Определение последнего слова, так как не работает метод определения последнего слова с \0
            if (i == (enteredText.Length - 1) && charactersForAWord != 0) {
                charactersForAWord = 0;

                numberOfWords++;
            }
        }


        // Подготовка к выводу информации
        string resultText = string.Empty;
        resultText += $"Общее количество символов: {totalNumberOfCharacters} \n";
        resultText += $"Количество пробелов: {numberOfSpaces} \n";
        resultText += $"Количество слов: {numberOfWords} \n";
        resultText += $"Количество гласных (НЕ ДЛЯ ВСЕХ ЯЗЫКОВ): {numberOfVowels} \n";
        resultText += $"Количество согласных (НЕ ДЛЯ ВСЕХ ЯЗЫКОВ): {numberOfConsonants} \n";

        // Вывод результирующей информации
        ResultTextBox.Text = resultText;
    }

    private void TextReverseTranslit_Click(object sender, RoutedEventArgs e) {
        // Получение текста из поля ввода
        string enteredText = EntryTextBox.Text;

        // Определение сравнение букв раскладки клавиатуры для реверсирования
        var reverseDictionary = new Dictionary<char, char>() {
            ['q'] = 'й',
            ['w'] = 'ц',
            ['e'] = 'у',
            ['r'] = 'к',
            ['t'] = 'е',
            ['y'] = 'н',
            ['u'] = 'г',
            ['i'] = 'ш',
            ['o'] = 'щ',
            ['p'] = 'з',
            ['['] = 'х',
            [']'] = 'ъ',
            ['a'] = 'ф',
            ['s'] = 'ы',
            ['d'] = 'в',
            ['f'] = 'а',
            ['g'] = 'п',
            ['h'] = 'р',
            ['j'] = 'о',
            ['k'] = 'л',
            ['l'] = 'д',
            [';'] = 'ж',
            ['\''] = 'э',
            ['z'] = 'я',
            ['x'] = 'ч',
            ['c'] = 'с',
            ['v'] = 'м',
            ['b'] = 'и',
            ['n'] = 'т',
            ['m'] = 'ь',
            [','] = 'б',
            ['.'] = 'ю',

            ['Q'] = 'Й',
            ['W'] = 'Ц',
            ['E'] = 'У',
            ['R'] = 'К',
            ['T'] = 'Е',
            ['Y'] = 'Н',
            ['U'] = 'Г',
            ['I'] = 'Ш',
            ['O'] = 'Щ',
            ['P'] = 'З',
            ['{'] = 'Х',
            ['}'] = 'Ъ',
            ['A'] = 'Ф',
            ['S'] = 'Ы',
            ['D'] = 'В',
            ['F'] = 'А',
            ['G'] = 'П',
            ['H'] = 'Р',
            ['J'] = 'О',
            ['K'] = 'Л',
            ['L'] = 'Д',
            [':'] = 'Ж',
            ['\"'] = 'Э',
            ['Z'] = 'Я',
            ['X'] = 'Ч',
            ['C'] = 'С',
            ['V'] = 'М',
            ['B'] = 'И',
            ['N'] = 'Т',
            ['M'] = 'Ь',
            ['<'] = 'Б',
            ['>'] = 'Ю',
            ['/'] = '?',
            ['&'] = '?'
        };

        // Переменная для храненения результирующего текста
        string resultText = "";

        // Реверсирование транслита
        foreach (char letter in enteredText) {
            foreach (var KeyValue in reverseDictionary) {

                if (letter == KeyValue.Key) {
                    resultText += KeyValue.Value;
                }
            }
            if (!reverseDictionary.ContainsKey(letter)) {
                resultText += letter;
            }
        }

        // Вывод результирующей информации
        ResultTextBox.Text = resultText;
    }

}
