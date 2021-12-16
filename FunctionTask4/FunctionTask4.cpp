
#include <iostream>

using namespace std;

char CheckMax(int a ,int b ,int c) 
{
    if (a > b && a > c)
    {
        return 'a';
    }
    else if (b > a && b > c)
    {
        return 'b';
    }
    else
        return 'c';
}

int main()
{
    setlocale(LC_ALL, "Ru");

    short int a, b, c;
    cout << "Введите число а: ";
    cin >> a;
    cout << "Введите число b: ";
    cin >> b;
    cout << "Введите число c: ";
    cin >> c;

    cout << "Наибольшее число: " << CheckMax(a, b, c);
}

