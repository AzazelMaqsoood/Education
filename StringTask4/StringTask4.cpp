
#include <iostream>
#include <string.h>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    string str;
    short charIndex = 0;

    cin >> str;

    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] == ' ')
        {
            charIndex = str[i];
        }
        str.resize(str.length() - (str.length() - charIndex));
        break;
    }



    cout << str;

}

