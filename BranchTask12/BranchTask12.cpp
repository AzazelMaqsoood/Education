
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    short int pointX, pointY;
    bool isInclude;

    cout << "Введите координаты точки: ";
    cin >> pointX;
    cin >> pointY;
    isInclude = (pointY <= 2);
    cout << "Точка входи в область: " << boolalpha << isInclude;
}

