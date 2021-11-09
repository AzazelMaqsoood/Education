
#include <iostream>

using namespace std;

int main()
{

    setlocale(LC_ALL, "Ru");

    struct point
    {
        short int x, y;
    };

    short int p, s, ab, bc, ac;
    point a, b, c;
    cout << "Введите координаты первой вершины (x,y): ";
    cin >> a.x >> a.y;
    cout << "Введите координаты второй вершины (x,y): ";
    cin >> b.x >> b.y;
    cout << "Введите третьей вершины (x,y): ";
    cin >> c.x >> c.y;
    ac = sqrt(pow((a.x - c.x), 2) + pow((a.y - c.y),2));//Long AC
    ab = sqrt(pow((a.x - b.x), 2) + pow((a.y - b.y), 2));//Long AB
    bc = sqrt(pow((b.x - c.x), 2) + pow((b.y - c.y), 2));//Long BC

    p = (ac + ab + bc) / 2; //half-meter
    s = sqrt(abs(p * (p - ac) * (p - bc) * (p - ab))); //Using Heron`s formula
   
    cout << "Площадь треугольник: " << s;
}
