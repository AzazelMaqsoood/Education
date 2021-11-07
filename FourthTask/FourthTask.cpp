#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    unsigned short int a = 4, b = 2; //Cos short weights 2 bytes

    cout << "А)" << "2+4=" << (a + b) << endl;
    cout << "Б)" << "Z(" << a << ")=" << "F(" << b << ")" << endl;
    cout << "В)" << "a=" << a << ';' << "b=" << b << ';' << endl;
    cout << "Г)" << "Ответ:(" << a << ';' << b << ')' << endl;
}
