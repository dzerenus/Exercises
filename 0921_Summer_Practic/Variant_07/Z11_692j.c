#include <stdio.h>  // Подключение ввода-вывода.
#include <stdlib.h> // Random.

// Задача 692 (ж)
// > Дана действительная квадратная матрица порядка n. 
//   Найти наибольшее из значений элементов, расположенных в заштрихованной части матрицы

static unsigned M = 7;

// Заполняем матрицу случайными числами.
void RandMatrix(int ar[M][M])
{
	for (int i = 0; i < M; i++)
		for (int j = 0; j < M; j++)
			ar[i][j] = rand()%100-50;
}

// Вывод матрицы на экран.
void PrintMatrix(int ar[M][M])
{
	for (int i = 0; i < M; i++)
	{
		for (int j = 0; j < M; j++)
			printf("%d ", ar[j][i]);

		printf("\n");
	}
}

// Получить все числа, которые участвуют в отборе.
int GetNums(int ar[M][M], int nums[])
{	
	// Чётная ли сторона матрицы.
	int isEven = 1;
	if (M % 2 == 1) isEven = 0;

	int max = M / 2; // Максимальная глубина.

	int count = 0;

	for (int i = 0; i < M/2; ++i)
		for (int j = 0; j <= i; ++j)
		{
			nums[count] = ar[j][i];
			count++;
		}

	if (!isEven)
		for (int j = 0; j <= max; ++j)
		{
			nums[count] = ar[j][max];
			count++;
		}

	for (int i = M-M/2; i < M; ++i)
		for (int j = 0; j < M-i; j++)
		{
			nums[count] = ar[j][i];
			count++;
		}

	return count;
}

int main()
{	
	int a[M][M]; // Матрица.
	RandMatrix(a); // Заполняем случайными числами.
	PrintMatrix(a); // Вывод матрицы на экран.

	int nums[(M*M)/2]; // Массив для отобранных чисел.
	int count = GetNums(a, nums); // Количество отобранных чисел.

	// Ищем и выводим самое маленькое число.
	int small = 9999;
	for (int i = 0; i < count; ++i)
		if (nums[i] < small) small = nums[i];

	printf("\nResult: %d", small);

	getchar(); getchar(); // Ждём нажатие.
    return 0;  		      // Выходим.	
}