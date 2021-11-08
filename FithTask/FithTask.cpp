//5)Ввести с клавиатуры три целых числа, найти их сумму, 
//  произведение и среднее арифметическое. 

#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ru");

    short int num1, num2, num3;
    cout << "Введите первое число: ";
    cin >> num1;
    cout << "Введите второе число: ";
    cin >> num2;
    cout << "Введите третье число: ";
    cin >> num3;

    short int sum = num1 + num2 + num3;

    cout << "Сумма введеных чисел = " << sum <<endl;
    cout << "Произведение введеных чисел = " << num1 * num2 * num3 << endl;

    //float  sra = (round((float)sum / 3 * 10)) / 10;//Init SRA in float
    float  sra = (float)sum / 3;//Init SRA in float

    cout << "Ср. арифметическое введеных чисел = " << sra;
     
}
