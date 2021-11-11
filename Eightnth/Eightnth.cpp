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
    float S, l;
    int R;
    cout << "Введите радиус круга: ";
    cin >> R;
    S = M_PI * pow(R, 2);
    l = 2 * M_PI * R;
    cout << "Длина окружности: " << l << endl << "Площадь круга: " << S;

    return 0;
}
