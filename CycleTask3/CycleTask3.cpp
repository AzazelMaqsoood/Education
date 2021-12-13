#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    short int number, result = 0;

    cin >> number;

    for (short i = 1; i <= number; i++)
    {

        result = i * 2;

        cout << result << ' ';
    }
}