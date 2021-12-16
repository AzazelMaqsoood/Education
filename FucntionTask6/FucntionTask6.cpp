
#include <iostream>

using namespace std;

long Factorial(int N)
{
    long f = 1;
    for (int i = 1; i <= N; i++)
    {
        f *= i;
    }
    return f;
}

int main()
{
    setlocale(LC_ALL, "Ru");
    long N;
    cin >> N;
    cout << "Факториал введенного числа: " << Factorial(N);
}

