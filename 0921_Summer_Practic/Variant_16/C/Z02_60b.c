#include <stdio.h>  // Printf, Scanf
#include <math.h>   // Математика

// Переменные для работы программы.
float x, y, result;

int main() {
	// Ввод переменной X.
    printf("Input X: ");
    scanf("%f", &x);

    // Ввод переменной Y.
    printf("Input Y: ");
    scanf("%f", &y);

    // Рабочий цикл программы.
    if ((pow(x, 2) + pow(y, 2) <= 1) && (y <= x/2))
    	result = -3;
    else
    	result = pow(y, 2);

    printf("Result: %f", result);

    getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}