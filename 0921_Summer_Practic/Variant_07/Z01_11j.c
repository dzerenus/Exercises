#include <stdio.h>  // Подключение ввода-вывода.
#include <math.h>   // Подключение математики.

// Задача 11 (ж)
// > Даны X, Y, Z - вычислить A, B.

// Объявляем переменные.
float x, y, z, a, b;

int main() {
	// Ввод X.
    printf("X = ");
    scanf("%f", &x);

    // Ввод Y.
    printf("Y = ");
    scanf("%f", &y);

    // Ввод Z.
    printf("Z = ");
    scanf("%f", &z);

    // Считаем A.
    a = log(abs((y-sqrt(abs(x)))*(x-(y/(z+pow(x,2)/4)))));
    printf("a=%f\n", a);

    // Считаем B.
    b = x - (pow(x, 2)/(3*2)) + (pow(x, 5)/(5*4*3*2));
    printf("b=%f", b);

    getchar(); getchar(); // Ждём нажатие.
    return 0;             // Выходим.
}