
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    int number, rez = 0;

    cout << "Введите число: ";
    cin >> number;

    while (number > 0)
    {
        rez += number % 10;
        number /= 10;
    }
    cout <<"Сумма цифр введенного числа = " << rez;
}

