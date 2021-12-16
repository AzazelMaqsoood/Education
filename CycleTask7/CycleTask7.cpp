
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    short int number, rez = 0;

    cin >> number;

    while (number > 0)
    {
        rez += number % 10;
        number /= 10;
    }
    cout << rez;
}

