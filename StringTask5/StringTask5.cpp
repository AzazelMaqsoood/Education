
#include <iostream>
#include <string>


using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    string str;
    short charIndex = 0;

    getline(cin, str);
    charIndex = str.find(' ');
    str.erase(0, charIndex+1);

    cout << str;
   
}

