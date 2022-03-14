#include <iostream>
#include <string>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    string str;
    string temp;

    getline(cin, str);
   
    str.erase(remove(str.begin(), str.end(), ' '), str.end());
    
    temp = str;
    reverse(str.begin(), str.end());
    if (str.compare(temp) == 0)
        cout << "Yes";
    else
        cout << "No";
}