#include <iostream>
#include <string>
#include <clocale>
using namespace std;

int main()
{
    setlocale(LC_ALL, "");

    string str;
    string substr;

    getline(cin, str);
    getline(cin, substr);


    short pos = 0, cnt = 0;

    while ((pos = str.find(substr, pos)) != string::npos)
    {
        pos += substr.size();
        cnt++;
    }
    cout << "Количество вхождений: " << cnt;
}