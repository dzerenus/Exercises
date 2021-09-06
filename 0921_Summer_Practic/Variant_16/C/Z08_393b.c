#include <stdio.h>  // Printf, Scanf
#include <stdlib.h> // Генератор случайных чисел.
 
const int N = 5; // Кол-во проходов.

int main() {
	int a[N][N];

	// Генерация и вывод матрицы.
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			a[i][j] = (rand() % 100) - 50;

			printf("%d ", a[i][j]); // Вывод строки матрицы.
		}
		printf("\n"); // Перенос строки.
	}

	for (int i = 0; i < N; i++) {
		int bi = 1;

		for (int j = 0; j < N; j++)
			if (a[i][j] > 0) {
				bi = a[i][j];
				break;
			}

		printf("\nB%d = %d", i, bi);
	}

    getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}