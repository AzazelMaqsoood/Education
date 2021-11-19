
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    short int x, y;
    bool isOpposite;
    bool isZero;

    cout << "Введите числа x и y: ";
    cin >> x >> y;
    isOpposite = (x * y != abs(x * y));
    cout << boolalpha << isOpposite << endl;
    isZero = (x == 0 || y == 0);
    cout << boolalpha << isZero << endl;
    isZero = (x*y == 0 && x+y != 0);
    cout << boolalpha << isZero << endl;
}

