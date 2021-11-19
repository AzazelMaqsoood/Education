
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    short int a, b, c;
    bool isLong;
    cout << "Введите длину первой веревки: ";
    cin >> a;
    cout << "Введите длину второй веревки: ";
    cin >> b;
    cout << "Введите длину третьей веревки: ";
    cin >> c;
    isLong = ((a + b > 30) || (a + c > 30) || (b + c > 30));
    cout << "Длина полученной веревки больше 30? - " << boolalpha << isLong;

}

