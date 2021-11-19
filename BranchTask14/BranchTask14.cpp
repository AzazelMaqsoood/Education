
#include <iostream>


using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    short int pointX, pointY, R = 2;
    bool isIncluded;
    cout << "Введите координаты точки: ";
    cin >> pointX >> pointY;
    isIncluded = (pow(pointX, 2) + pow(pointY, 2) <= pow(R, 2));
    cout << "Точка входит в область - " << boolalpha << isIncluded;
}

