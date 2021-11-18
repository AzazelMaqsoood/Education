#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru"); //Setted rus locale
    short int a;
    cin >> a;
    cout << a % 100 /10;
}
