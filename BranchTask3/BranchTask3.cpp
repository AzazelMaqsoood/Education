
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "ru");
    short int a;
    cout << "Введите число: ";
    cin >> a;
    if (a % 2 != 0) //Checking the remainder of the devision
    {
        cout << "Нечетное";
    }
    else cout << "Четное";
}
