#include <stdio.h>  // Printf, Scanf
#include <math.h>   // Математика

const int N = 30; // Кол-во проходов.

int main() {
	float a[N], b[N]; // Пустые массивы.
	float result = 0; // Результат.

	// Рабочий ход программы.
	for (int i = 1; i <= 30; i++) {
		if (i % 2 == 0) {         // Чётное
			a[i-1] = i/2.0;
			b[i-1] = pow(i, 3);
		}
		else {                    // Нечётное
			a[i-1] = i;
			b[i-1] = pow(i, 2);
		}

		// Автосумма.
		result += pow(a[i-1] - b[i-1], 2);
	}

    printf("Result: %f", result);

    getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}