//5)Ввести с клавиатуры три целых числа, найти их сумму, 
//  произведение и среднее арифметическое. 

#include <iostream>
#include <ctime>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");
    srand(time(NULL)); //init func srand by value of func time
    unsigned short int x = rand() % 1000; //gen random number
    cout << x << endl;
    cout << "x содержит: " << x / 100 << "сотен(ю)" << endl;
    cout << "x содержит: " << x / 10 << "десятков(а)" << endl;
    cout << "x содержит: " << x % 10 << "единиц(ы)" << endl;
}
