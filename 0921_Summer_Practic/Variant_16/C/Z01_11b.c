#include <stdio.h>  // Printf, Scanf
#include <math.h>   // Математика

// Переменные для работы программы.
float x, y, z, a, b;

int main() {
	// Ввод переменной X.
    printf("Input X: ");
    scanf("%f", &x);

    // Ввод переменной Y.
    printf("Input Y: ");
    scanf("%f", &y);

    // Ввод переменной Z.
    printf("Input Z: ");
    scanf("%f", &z);

    // Рассчёт и вывод числа A.
    a = (3 + expf(y-1))/(1+pow(x, 2)*abs(y-tan(z)));
    printf("a=%f\n", a);

    // Рассчёт и вывод числа B.
    b = 1 + abs(y-x) + pow(y-x, 2)/2 + abs(pow(y-x, 3)) / 3;
    printf("b=%f", b);

    getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}