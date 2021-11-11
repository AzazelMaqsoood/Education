
#include <iostream>
#include <ctime>

using namespace std;

int main()
{
	setlocale(LC_ALL, "ru");
	srand(time(NULL)); // инициализация функции rand значением функции time
	unsigned short int x = rand() %1000; // сгенерировать секретное число
	cout << x << endl;
	cout << "х содержит: " << x / 100 << " ед. 3-го разряда" << endl;
	cout << "х содержит: " << x / 10 << " ед. 2-го разряда" << endl;
	cout << "х содержит: " << x % 10  << " ед. 1-го разряда" << endl;
}
