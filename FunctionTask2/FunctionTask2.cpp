
#include <iostream>

using namespace std;

void ShowDeviders(short int N) {
    for (short int i = 1; i <= N; i++)
    {
        if (N % i == 0)
        {
            cout << i << ' ';
        }
    }
}

int main()
{
    setlocale(LC_ALL, "Ru");

    short int N;

    cin >> N;

    ShowDeviders(N);
    
}

