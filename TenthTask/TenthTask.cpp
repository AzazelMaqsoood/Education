﻿
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "ru");
    cout << "Введите число от 0 до 16" << '\n';
    int x;
    cin >> x;
    int f{ 1 }, e{ 1 }, d{ 1 }, c{ 1 }, b{ 1 }, a{ 1 }; //Используем списковую инициализацию
    //int a, b, c, d, e, f = a = b = c = d = e = 1; эквивалентная запись
    //Все биты определил разными переменными со значением "1",
    //далее логической операцией "если" либо уменьшается число, 
    //либо заменяется соответствующий бит
    (x >= 32) ? x -= 32 : a = 0;
    (x >= 16) ? x -= 16 : b = 0;
    (x >= 8) ? x -= 8 : c = 0;
    (x >= 4) ? x -= 4 : d = 0;
    (x >= 2) ? x -= 2 : e = 0;
    (x == 1) ? e = 1 : f = 0;
    std::cout << a << b << c << d << e << f; '\n';
    return 0;

}