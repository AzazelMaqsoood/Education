Code, Compile, Runand Debug C++ program online.
Write your code in this editorand press "Run" button to compile and execute it.

* ******************************************************************************/

#include <iostream> 
#include <iomanip> 
#include <cmath> 

using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    float s, l, r;
    cout << "Введите радиус круга: ";
    cin >> r;
    s = M_PI * pow(r, 2);
    l = 2 * M_PI * r;
    cout << "Длина окружности: " << l << endl << "Площадь круга: " << s;

    return 0;
}
