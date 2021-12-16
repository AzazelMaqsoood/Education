
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
	long N, f = 1;
	cin >> N;
	for (int i = 1; i <= N; i++)
	{
		f *= i;
	}
	cout << f;
}

