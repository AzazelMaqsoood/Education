
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    int x, sum = 0, pro = 1;
    do
    {
        cin >> x;
        sum += x;
        pro *= x;
    } while (x != 0);

    cout << sum << " " << pro;
    return 0;
}

























































