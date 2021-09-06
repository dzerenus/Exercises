#include <stdio.h>  // Printf, Scanf
#include <math.h>   // Математика

int main() {
	int n;            // Кол-во проходов.
	float result = 0; // Результат.

	// Ввод входных данных.
    printf("Input N: ");
    scanf("%d", &n);

    // Рабочий ход программы.
    while (n > 0) {
    	result = sqrt(2 + result);
    	n--;
    }

    printf("Result: %f", result);

    getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}