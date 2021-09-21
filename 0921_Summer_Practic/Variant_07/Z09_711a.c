#include <stdio.h>  // Подключение ввода-вывода.
#include <stdlib.h> // Random.

// Задача 711 (а)
// > Дана матрица А размера m x m;
//   Получить матрицу АA

static unsigned M = 3;

int main()
{	
	int a[M][M]; // Матрица.
	int r[M][M]; // Результат.

	// Заполняем матрицу случайными числами.
	for (int i = 0; i < M; i++)
		for (int j = 0; j < M; j++)
			a[i][j] = rand()%10;

	// Вывод матрицы на экран.
	for (int i = 0; i < M; i++)
	{
		for (int j = 0; j < M; j++)
			printf("%d ", a[j][i]);

		printf("\n");
	}

	printf("\nResult:\n");

	// Умножаем матрицы.
	for (int i = 0; i < M; i++)
		for (int j = 0; j < M; j++)
		{
			r[i][j] = 0;
			
			for (int g = 0; g < M; g++)
				r[i][j] += (a[i][g] * a[g][j]);
		}

	// Вывод матрицы на экран.
	for (int i = 0; i < M; i++)
	{
		for (int j = 0; j < M; j++)
			printf("%d ", r[j][i]);

		printf("\n");
	}

	getchar(); getchar(); // Ждём нажатие.
    return 0;  		      // Выходим.	
}