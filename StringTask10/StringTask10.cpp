#include <iostream>
#include <string>
using namespace std;
int main() {
    setlocale(LC_ALL, "RUS");
    string s{ "C:\\WINDOWS\\WORK\\my.txt" };
    int indx = 0;
    while (true) {
        int indx1 = s.find('\\', indx);
        if (indx1 == string::npos) {
            break;
        }
        else {
            cout << s.substr(indx, indx1) << endl;
            s.erase(indx, indx1 + 1);
        }
    }
    cout << s << endl;
    return 0;
}