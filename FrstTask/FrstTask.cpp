//1.Вывести на экран фразу лесенкой:
//Студент,
//        давайте
//               зачётку
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru"); //Setted rus locale
    cout << "Студент," << endl << setw(15) << "давайте" << endl << setw(22) << "зачетку";
}
