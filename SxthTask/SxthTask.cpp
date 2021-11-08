#include <iostream>
#include <cmath>

using namespace std;

int main()
{

	setlocale(LC_ALL, "Ru");

	struct point	//Struct to hold coordinates
	{
		double x, y;
	};

	point a, b;

	cout << "Введите координаты точки А по Х:";
	cin >> a.x;
	cout << "Введите координаты точки А по Y:";
	cin >> a.y;
	cout << "Введите координаты точки Б по Х:";
	cin >> b.x;
	cout << "Введите координаты точки Б по Y:";
	cin >> b.y;

	cout << "Длина отрезка AБ:";
	cout << sqrt(abs((a.x - b.x) + (a.y - b.y))); //Print long equivalent 
	//the square root of the modules of the coordinate difference
}