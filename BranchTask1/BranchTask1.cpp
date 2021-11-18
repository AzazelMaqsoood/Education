
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    short int a, b;
    cout << "Введите первое число: ";
    cin >> a;
    cout << "Введите второе число: ";
    cin >> b;

    if (a < b)
    {
        cout << "Наименьшее число: " << a;
    }
    else if (b < a)
    {
        cout << "Наименьшее число: " << b;
    }
    else {
        cout << "Введены равные числа";
    }

}
