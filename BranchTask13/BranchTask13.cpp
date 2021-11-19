
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    short int pointX, pointY;
    bool isInlcuded;
    
    cout << "Введите координаты точки: ";
    cin >> pointX >> pointY;
    isInlcuded = (pointY <= -pointX);
    cout << "Входит в область - " << boolalpha << isInlcuded;
}

