#include <stdio.h>  // Подключение ввода-вывода.
#include <math.h>   // Подключаем округление.
 
// Задача 210
// > Даны натуральное число n, действительные числа a1,...,an.
//   Получить все натуральные j (2 ≤ j ≤ n-1), для которых aj-1 < aj > aj+1.

const unsigned int N = 5; // Количество a.

int main()
{	
	float a[N]; // Массив A.
	int j[N-1]; // Массив итоговых J.

	// Цикл ввода данных в массив A.
	for (int i = 0; i < N; i++)
	{
		printf("A%d = ", i);
		scanf("%f", &a[i]);
	}

	printf("Result:\n");

	// Ищем все натуральные числа, которые могут быть
	// между A(n) и A(n+1)
	for (int i = 0; i < N-1; i++)
	{	
		int a1 = ceil(a[i]);
		int a2 = floor(a[i+1]);

		for (int g = a1; g < a2; g++)
			printf("%d\n", g);
	}
 
	getchar(); getchar(); // Ждём нажатие.
    return 0;  			  // Выходим.	
}