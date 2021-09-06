#include <stdio.h>  // Printf, Scanf.
#include <math.h>   // Математика.

int main()
{	
	double result = 0;

	for (int i = 1; i <= 100; i++)
		for (int j = 1; j <= 100; j++)
			result += sin(pow(i,3) + pow(j,4));

	printf("%f", result);

	getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}