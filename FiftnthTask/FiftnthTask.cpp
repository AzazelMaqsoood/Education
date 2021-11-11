#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    int a, b, c;
    cout << "Введите число А: ";
    cin >> a;
    cout << "Введите число B, которое меньше чем А: ";
    cin >> b;
    if (a < b) {
        srand(a * b);
        for (int i = 1; i <= 3; i++) {
            c = rand() % (b - a) + a;
            cout << "Число " << i << " в пределах интервала [" << a << "," << b << "]: " << c << endl;
        }
    }
    else {
        cout << "Ошибка: не выполнено условие";
    }

    return 0;
}