
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    int x, sum = 0, pro = 1;
    while (true)
    {
        cin >> x;
        if (x == 0) break;
        sum += x;
        pro *= x;
    }
    cout << sum << " " << pro;
    return 0;
}

