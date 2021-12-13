
#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Ru");

	short int a, b, sum = 0;

	cin >> a;
	cin >> b;

	do
	{
		sum += pow(a, 2);
		a++;
	} while (a <= b);

	cout << sum;
}

