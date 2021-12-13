
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    short int a, b, qrt = 0;

	cin >> a;
	cin >> b;

	do
	{
		qrt = pow(a, 2);
		cout << a << " ^ 2 = " << qrt << endl;
		a++;
	} while (a <= b);
}

