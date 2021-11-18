#include <iostream>

using namespace std;

int main()
{

	setlocale(LC_ALL, "Ru");

    short int a;
	cout << "Введите число: ";
    cin >> a;
	if (a > 0)
		cout << "число положительное";
	else if (a < 0)
		cout << "число отрицательное";
	else if (a = 0)
		cout << '0';
	else cout << "Введено не число";
}
