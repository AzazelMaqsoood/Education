#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    int a, b, c;
    cout << "Введите первое число: ";
    cin >> a;
    cout << "Введите второе число: ";
    cin >> b;
    cout << "Введите третье число: ";
    cin >> c;
    bool isNegative;
    isNegative = (a != abs(a) || b != abs(b) || c != abs(c)); //Comare nums with their modules
    cout << "Число отрицательное ? - " << boolalpha << isNegative;
}

