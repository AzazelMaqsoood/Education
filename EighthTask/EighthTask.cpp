
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "ru");

    short int x, y, z;

    cout << "Введите x:";
    cin >> x;
    cout << "Введите y:";
    cin >> y;
    
    z = y;
    y = x;
    x = z;

    cout << "x = " << x << endl;
    cout << "y = " << y << endl;

}