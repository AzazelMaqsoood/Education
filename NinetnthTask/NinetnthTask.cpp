
#include <iostream>

using namespace std;

int main()
{
	double firstMass, secondMass;
	short int days;

	cout << "Введите количество фруктов: ";
	cin >> firstMass;
	cout << "Введите количество дней: ";
	cin >> days;
	secondMass = firstMass - (days * 0.99); //By condition to loss 1% per day
	cout << "Масса после хранения: " << secondMass;
}
