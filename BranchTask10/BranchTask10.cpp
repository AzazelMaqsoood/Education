
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    short int month;

    cout << "Введите номер месяца: ";
    cin >> month;
    if (month == 12 || month == 1 || month == 2)
    {
        cout << "Бррр... Зима";
    }
    else if (month == 3 || month == 4 || month == 5)
    {
        cout << "Весна, весна! Как воздух чист! Как ясен небосклон!";
    }
    else if (month == 6 || month == 7 || month == 8)
    {
        cout << "Лето пахнет земляникой, Тёплым дождиком, клубникой";
    }
    else if (month == 9 || month == 10 || month == 11)
    {
        cout << "Мдее...Осень";
    }
    else {
        cout << "Ошибочка. В году всего 12 месяцев";
    }
}

