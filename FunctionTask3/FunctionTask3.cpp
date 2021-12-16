
#include <iostream>

using namespace std;

string CheckSimple(short int N) 
{
	for (short int i = 2; i < N; i++)
	{
		N %= i;
		if (N % i == 0)
		{
			return "Составное";
		}
		else {
			return "Простое";
		}
	}
}

int main()
{
    setlocale(LC_ALL, "Ru");

    short int N;

	cin >> N;
	cout << CheckSimple(N);
}

