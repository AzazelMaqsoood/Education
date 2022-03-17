#include <iostream>
#include <string>
#include <clocale>
using namespace std;

int main()
{
    setlocale(LC_ALL, "");

    string str;
    string toReplace;
    string replaceWith;

    getline(cin, str);
    getline(cin, toReplace);
    getline(cin, replaceWith);

    short pos = 0, cnt = 0;

    while ((pos = str.find(toReplace, pos)) != string::npos)
    {
        str.replace(pos, toReplace.size(), replaceWith);
        pos += replaceWith.size();
        cnt++;
    }
    cout << str << endl << "Количество замен: " << cnt;
}