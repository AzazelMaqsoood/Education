
#include <iostream>
#include <ctime>

using namespace std;

int main()
{
	short int x;
	cin >> x;
	srand(time(NULL));
	x = rand() % x + 1;
	cout << x;
}
