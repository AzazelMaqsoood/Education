
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    int x, sum = 0, pro = 1;
    while (true)
    {
        cin >> x;
        while (x != 0)
        {
            sum += x;
            pro *= x;
        }
        if (x == 0) break;
        
    }
    cout << sum << " " << pro;
    return 0;
}

