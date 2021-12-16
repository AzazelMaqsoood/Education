
#include <iostream>

using namespace std;

void ReverseNumber(int number)
{
    number = (number % 10) * 10 + number / 10;
    cout << number;
}

int main()
{
    setlocale(LC_ALL, "Ru");
    int number;

    cout << "Введите двузначное число: ";
    cin >> number;

    ReverseNumber(number);
}

