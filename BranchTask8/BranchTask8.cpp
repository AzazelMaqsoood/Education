
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    short int a, b, x, y;
    bool isBelong, isPositive, isSameSign;
    cout << "Введите a и b";
    cin >> a >> b;
    cout << "Введите x и y";
    cin >> x >> y;

    isBelong = (x >= a && x <= b);
    cout << "x принадлежит отрезку a b -" << boolalpha << isBelong << endl;
    isBelong = (y >= a && y <= b);
    cout << "y принадлежит отрезку a b -" << boolalpha << isBelong << endl;
    isPositive = (x > 0 && y > 0);
    cout << "x и y положительные -" << boolalpha << isPositive << endl;
    isSameSign = (x * y == abs(x * y));
    cout << "x и y имеют одинаковый знак -" << boolalpha << isPositive << endl;
}

