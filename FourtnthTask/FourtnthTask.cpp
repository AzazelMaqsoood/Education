
#include <iostream>
#include <ctime>

using namespace std;

int main()
{
	int a, b;

	setlocale(LC_ALL, "Ru");

	cin >> a;
	cin >> b;
	srand(time(NULL));

	cout << (rand() % (a - b) + b) << endl;
	cout << rand() % (a - b) + b << endl;
	cout << rand() % (a - b) + b << endl;
}