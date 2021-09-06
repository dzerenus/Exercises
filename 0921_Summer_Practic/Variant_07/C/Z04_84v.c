#include <stdio.h>  // Подключение ввода-вывода.
#include <math.h>   // Подключение синуса.

// Задача 84 (в)
// > Даны натуральное n, действительное х. Вычислить:
//  sin х + sin sin x + ... + sin sin ...sin x;

unsigned int n;   // Количество проходов.
float x;          // Число X.

int main()
{	
	// Ввод N.
    printf("N = ");
    scanf("%d", &n);

    // Ввод X.
    printf("X = ");
    scanf("%f", &x);

 	// Переменная под результат.
    float result = 0;

  	// Рассчёт числа.  
    for (int i = 0; i < n; i++)
    {	
    	float temp = x; // Временная.

    	for (int j = 0; j <= i; j++)
    		temp = sin(temp);

    	result += temp; // Увеличиваем результат.
    }

    printf("Result: %f", result); // Вывод.

	getchar(); getchar(); // Ждём нажатие.
    return 0;  			  // Выходим.	
}