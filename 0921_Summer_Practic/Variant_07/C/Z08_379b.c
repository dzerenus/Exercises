#include <stdio.h>  // Подключение ввода-вывода.
#include <stdlib.h> // Random.

// Задача 379 (б)
// > Дана действительная матрица размера n x m. Определить числа b1, ..., bm, равные соответственно:
//   произведениям элементов строк;

static unsigned NCOUNT = 5; // Столбцы.
static unsigned MCOUNT = 6; // Строки.

int main()
{	
	float m[NCOUNT][MCOUNT]; // Матрица.

	// Заполняем матрицу случайными числами.
	for (int i = 0; i < NCOUNT; i++)
		for (int j = 0; j < MCOUNT; j++)
			m[i][j] = rand()%100/10.0;

	// Вывод матрицы на экран.
	for (int i = 0; i < MCOUNT; i++)
	{
		for (int j = 0; j < NCOUNT; j++)
			printf("%.2f ", m[j][i]);

		printf("\n");
	}

	printf("\nResult:\n");

	// Рассчёт и вывод результата.
	for (int i = 0; i < MCOUNT; i++)
	{	
		float res = 1;

		for (int j = 0; j < NCOUNT; j++)
			res *= m[j][i];

		printf("%.2f ", res);
	}

	getchar(); getchar(); // Ждём нажатие.
    return 0;  		      // Выходим.	
}