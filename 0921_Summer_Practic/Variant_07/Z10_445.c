#include <stdio.h>  // Подключение ввода-вывода.
#include <stdlib.h> // Pause.

// Задача 445
// > Дано четное число n > 2; проверить для этого числа гипотезу Гольдбаха. 
//   Эта гипотеза заключается в том, что каждое четное n, большее двух,
//   представляется в виде суммы двух простых чисел.
//   (Определить процедуру, позволяющую распознавать простые числа).

// Верхний предел поиска простых чисел и максимальное вводимое число для проверки.
static unsigned N = 1000;

// Функция поиска числа в массиве.
// * elem - искомый элемент.
// * ar массив, в котором искать.
// * size - размер массива.
// Если элемент найдет, возвращает 1, иначе 0.
int FindElement(int elem, int ar[], int size)
{
	int result = 0;

	for (int i = 0; i < size; ++i)
		if (elem == ar[i])
		{
			result = 1;
			break;
		}

	return result;
}

// Функция поиска простых чисел методом решета Эратосфена.
// * ar - Массив, в который будут записаны простые числа.
// * maxNum - верхний предел поиска простых чисел.
// Возвращает количество найденных простых чисел.
int CheckFastNumbers(int ar[], int maxNum)
{	
	int count = 0; // Колчиество найденных простых чисел.

	int blackCount = 0; // Количество не простых чисел.
	int black[maxNum]; 	// Не простые числа.

	for (int i = 2; i < maxNum; i++)
	{	
		// Проверка числа на наличие его в чёрном списке.
		if (FindElement(i, black, blackCount)) continue;

		// Проверяем следующие числа на делимость текущим.
		// Есди делятся, добавляем их в чёрный список.
		for (int j = 2*i+1; j < maxNum; j++)
		{	
			// Если элемент уже есть в чёрном списке, пропускаем.
			if (FindElement(j, black, blackCount)) continue;

			// Если какое-то число делится без остатка, добавляем его
			// в чёрный список.
			if (j % i == 0)
			{	
				black[blackCount] = j;
				blackCount++;
			}
		}

		// Добавляем число в массив простых.
		ar[count] = i;
		count++;
	}

	return count; // Возвращаем количество простых.
}

// Процедура поиска простых подходящих чисел.
void CheckX(int x, int fn[], int size)
{	
	int isFound = 0; // Найдено ли число.

	// Ищем два подходящих числа.
	for (int i = 0; (i < size && !isFound); ++i)
		for (int j = 0; (j < size && !isFound); ++j)
			if (fn[i] + fn[j] == x)
			{
				isFound = 1;
				printf("True! %d + %d = %d\n", fn[i], fn[j], x);
			}

	if (!isFound)
		printf("False!\n");
}

int main()
{	
	// Ищем простые числа до числа N.
	int fn[N];
	int fnCount = CheckFastNumbers(fn, N);

	// Ввод числа.
	printf("Input X (X < %d): ", N);
	int x; scanf("%d", &x);

	// Если вводимое число больше N или чётное, выдаём ошибку.
	if (x > N || x % 2 == 1) printf("Input Error!\n");

	CheckX(x, fn, fnCount);

	system("pause");      // Пауза.
    return 0;  		      // Выходим.	
}