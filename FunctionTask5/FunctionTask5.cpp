#include <iostream>
using namespace std;

void ReverseNumber(int number) {
    int reverse = 0, rem;
    while (number > 0) {
        rem = number % 10;
        reverse = reverse * 10 + rem;
        number /= 10; 
    }
    cout << "Введенное число в обратном порядке цифр: " << reverse << endl;
}

int main() {

    setlocale(LC_ALL, "Ru");

    int number;
    cout << "Введите целое число: ";
    cin >> number;
    ReverseNumber(number);
    return 0;
}