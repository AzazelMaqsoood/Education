#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    
    int a;
    cout << "Введите четырехзначное число: ";
    cin >> a;
    int temp = a;
    int b = 0;

    if (a/1000<=0.1 || a/10000>=1)
    {
        cout << "Введено не четырехзначное число";
    }
    while (temp != 0)
    {
        b = b * 10 + temp % 10;
        temp /= 10;
    }
    string rez = (a == b) ? "Полиндром": "Не полиндром";

    cout << rez;
}

