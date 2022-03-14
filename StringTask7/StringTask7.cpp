#include <iostream>
#include <string>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    string str;
    short quantity = 0;

    getline(cin, str);

    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] == ' ')
        {
            quantity += 1;
        }
    }

    quantity += 1;

    cout << quantity;

}