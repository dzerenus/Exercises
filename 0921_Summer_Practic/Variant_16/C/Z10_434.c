#include <stdio.h>  // Printf, Scanf
#include <stdlib.h> // Генератор случайных чисел.
 
const int N = 10; // Кол-во элементов в массиве A.
const int M = 15; // Кол-во элементов в массиве B.

// Процедура генерации массива.
void GenerateArray(float array[], int count) {
	for (int i = 0; i < count; i++)
		array[i] = ((rand() % 100) - 50) / 10.0;
}

// Процедура вывода массива на экран.
void PrintArray(float array[], int count) {
	for (int i = 0; i < count; i++)
		printf("%.1f ", array[i]);

	printf("\n");	
}

// Функция получения максимального числа из массива.
float GetMax(float array[], int count) {
	float max = array[0];

	for (int i = 1; i < count; i++)
		if (max < array[i])
			max = array[i];

	return max;
}

// Замена чисел в массиве после числа.
void ReplaceArray(float array[], int count, float max, float newNum) {
	char isIt = 0;

	for (int i = 0; i < count; i++) {
		if (isIt == 1)
			array[i] = newNum;

		if ((isIt == 0) && (array[i] == max)) 
			isIt = 1;
	}
}

int main() {
	// Генерация массивов.
	float a[N], b[M];
	GenerateArray(a, N);
	GenerateArray(b, M);

	// Вывод массивов на экран.
	PrintArray(a, N);
	PrintArray(b, M);

	// Получаем максимальные числа.
	float aMax = GetMax(a, N);
	float bMax = GetMax(b, M);

	// Замена чисел в массивах.
	ReplaceArray(a, N, aMax, 0.5);
	ReplaceArray(b, M, bMax, 0.5);

	// Вывод массивов на экран.
	PrintArray(a, N);
	PrintArray(b, M);

    getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}

