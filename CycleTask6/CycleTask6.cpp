
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    short int a, b, N, rnd;

    cout << "Введите первое число: ";
    cin >> a;
    cout << "Введите второе число: ";
    cin >> b;
    cout << "Введите третье число: ";
    cin >> N;

    srand(time(0));

    for (int i = 1; i <= N; i++)
    {
        rnd = a + rand() % (b-a);
        cout << rnd << ' ';
    }

}

