
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    double pointX, pointY;
    short int R = 2;
    bool isIncluded;
    
    cout << "Введите координаты точки: ";
    cin >> pointX >> pointY;
    isIncluded = (pointX <= 2 && pointY <= pointX && pow(pointX, 2)+ pow(pointY, 2) >= pow(R, 2));
    cout << "Точка входит в область - " << boolalpha << isIncluded;
}

