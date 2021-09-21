#include <stdio.h>  // Подключение ввода-вывода.
#include <stdlib.h> // Random.

// Задача 711 (а)
// > Дана матрица А размера m x m;
//   Получить матрицу АA*

static unsigned M = 3;

void transpanent(int a[M][M], int r[M][M])
{
	for (int i = 0; i < M; i++)
		for (int j = 0; j < M; j++)
			r[i][j] = a[j][i];
}

int main()
{	
	int a[M][M]; // Матрица.
	int r[M][M]; // Результат.
	int t[M][M]; // Результат.

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

	// Транспонируем.
	transpanent(a, r);

	// Умножаем матрицы.
	for (int i = 0; i < M; i++)
		for (int j = 0; j < M; j++)
		{
			t[i][j] = 0;
			
			for (int g = 0; g < M; g++)
				t[i][j] += (r[i][g] * a[g][j]);
		}

	// Вывод матрицы на экран.
	for (int i = 0; i < M; i++)
	{
		for (int j = 0; j < M; j++)
			printf("%d ", t[j][i]);

		printf("\n");
	}

	getchar(); getchar(); // Ждём нажатие.
    return 0;  		      // Выходим.	
}