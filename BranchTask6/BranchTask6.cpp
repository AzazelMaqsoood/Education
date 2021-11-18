
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    int a, b, c;
    bool isDoubleDigit;
    cout << "Введите первое число: ";
    cin >> a;
    cout << "Введите второе число: ";
    cin >> b;
    cout << "Введите третье число: ";
    cin >> c;
    isDoubleDigit = (a / 10.0 >= 1 && b / 10.0 >= 1 && c / 10.0 >= 1);
    cout << "Все числа двузначные? - " << boolalpha << isDoubleDigit;
}

