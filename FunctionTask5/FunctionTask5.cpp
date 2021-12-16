#include <iostream>

using namespace std;

int CountDigits(int N)
{
	int cnt = 0;
	for (int i = 0; i <= N; i++)
	{
		N %= 10;
		cnt = i;
	}
	return cnt;	
}

int main()
{
    setlocale(LC_ALL, "Ru");

    short int N;
	cin >> N;

	cout << "Число имеет - " << CountDigits(N) << " знака(ов)";

}

