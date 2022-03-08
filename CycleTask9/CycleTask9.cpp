
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    int x, min = 1, max = 0;


    do
    {
        cin >> x;
        if (x == 0)
            min = min;
        if (max < x)
            max = x;
        if (min > x)
            min = x;
    } while (x != 0);
    cout << max << ' ' << min;
    return 0;
}

