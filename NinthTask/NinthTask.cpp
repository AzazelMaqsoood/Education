﻿
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "ru");
    std::cout << "Введите число от 0 до 16" << '\n';
    int x;
    std::cin >> x;
    int e{ 1 }, d{ 1 }, c{ 1 }, b{ 1 }, a{ 1 };
    //Все биты определил разными переменными со значением "1",
    //далее логической операцией "если" либо уменьшается число, 
    //либо заменяется соответствующий бит
    (x >= 16) ? x -= 16 : a = 0;
    (x >= 8) ? x -= 8 : b = 0;
    (x >= 4) ? x -= 4 : c = 0;
    (x >= 2) ? x -= 2 : d = 0;
    (x == 1) ? e = 1 : e = 0;
    std::cout << a << b << c << d << e; '\n';
    return 0;

}