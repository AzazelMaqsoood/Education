
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    short int number, result = 0, i = 0;

    cin >> number;

    do
    {
        
        i += 1;
        result += i;
    } while (i < number);
    
    cout << result;
}

