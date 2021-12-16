
#include <iostream>

using namespace std;

int ReverseNumber(int number)
{
    number = (number % 10) * 10 + number / 10;
    return number;
}

int main()
{
    setlocale(LC_ALL, "Ru");
    int number;

    cout << "Введите двузначное число: ";
    cin >> number;

    cout << ReverseNumber(number);
}

