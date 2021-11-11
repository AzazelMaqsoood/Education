#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    srand(time(0));
    int students_count, first_student, second_student;
    cout << "Укажите количество студентов в группе: ";
    cin >> students_count;
    first_student = rand() % students_count + 2;
    second_student = rand() % students_count + 2;
    while (second_student == first_student) {
        second_student = rand() % students_count + 2;
    }
    cout << "Дежурные по группе: " << first_student << " и " << second_student << endl;

    return 0;
}

