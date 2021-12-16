
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    int x, min = 1, max = 0;
    while (true)
    {
        cin >> x;
        if (x == 0) break;
        if (max < x)
            max = x;
        if (min > x)
            min = x;
    }
    cout << max << ' ' << min;
    return 0;
}

