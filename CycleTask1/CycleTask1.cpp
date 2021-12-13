
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    short int firstNumber, secondNumber, result = 0;

	cin >> firstNumber;
	cin >> secondNumber;

	for (short i = 1; i < secondNumber; i ++)
	{
		 result = firstNumber += firstNumber;
	}

	cout << result;
}

