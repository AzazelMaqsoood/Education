
#include <iostream>
#include <string>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    string str;
    short charIndex = 0;

    getline(cin, str);

    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] == ' ')
        {
            charIndex = str[i];
            str.erase(i);
        }
    }



    cout << str;

}

