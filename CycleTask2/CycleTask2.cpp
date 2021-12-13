
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    short int number, result = 0;

    cin >> number;

    for (short i = 0; i <= number; i++)
    {
        result += i;
    }
    
    cout << result;
}

