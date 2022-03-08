#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    string str;
    short num = 0;

    cout << "Введите строку: ";
    cin >> str;
    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] == 'c') {
            str[i] = 'v';
            num += 1;
        }
        else if (str[i] == 'C') {
            str[i] = 'V';
            num += 1;
        }
        else if (str[i] == 'V') {
            str[i] = 'C';
            num += 1;
        }
        else if (str[i] == 'v') {
            str[i] = 'c';
            num += 1;
        }
        
        
    }
    cout << "Новая строка: " << str << endl << "Количество замен: " << num;
}


