#include <iostream>
#include <ctime>

using namespace std;

int main()
{
    float a, b;
    srand(time(NULL));
    cin >> a;
    cin >> b;
    cout << (float)rand() / RAND_MAX * (b - a) << endl;
    cout << (float)rand() / RAND_MAX * (b - a) << endl;
    cout << (float)rand() / RAND_MAX * (b - a) << endl;

}
