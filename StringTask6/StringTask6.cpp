
#include <iostream>
#include <string>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    short spaceIndex = 0;
    short maxString = 0;
    string str;
    string *arrayR;     //указатель на тип string
    getline(cin, str);

    // Проверка на корректность ввода
    if (str.length() <= 0)
    {
        cout << "Wrong value of chars" << endl;
        return 0;
    }

    arrayR = new string[str.length()];  //Динамическое выделение памяти для массива

    // Заполнение массива 
    for (short i = 0; i < str.length(); i++) {
        arrayR[i] = (str[i]);
        if (str[i] == ' ')
            spaceIndex = i;
        if (spaceIndex > maxString)
            maxString = spaceIndex;
    }

    if (maxString < str.length() - maxString)
    {
        cout << "\nСамое длинное слово:" << ::endl;
        for (short i = maxString+1; i < str.length(); i++)
            cout << arrayR[i];
        cout << endl << str.length() - maxString - 1;
    }
    else
    {
        // Вывод массива 
        cout << "\nСамое длинное слово:" << ::endl;
        for (short i = 0; i < maxString; i++)
            cout << arrayR[i];
        cout << endl << maxString;
        // После завершения работы с массивом 
        // Освобождаем выделенную память
        delete[] arrayR;
    }
   
}


