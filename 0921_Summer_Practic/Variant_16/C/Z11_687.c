#include <stdio.h>  // Printf, Scanf
#include <math.h>   // Математика

const float x = 2;  // Число X.

// Генерация квадратной матрицы.
void GenerateMatrix(float array[][10], float xnum) {
	for (int i = 0; i < 10; i++)
		for (int j = 0; j < 10; j++) {
			if (i == 0)
				array[i][j] = pow(xnum, j);
			else if (i == 9)
				array[i][j] = pow(xnum, 9 - j);
			else {
				if (j == 0)
					array[i][j] = pow(xnum, i);	
				else if (j == 9)
					array[i][j] = pow(xnum, 9-i);
				else
					array[i][j] = 0;
			}
		}
}

// Вывод матрицы на экран.
void PrintMatrix(float ar[][10]) {
	for (int i = 0; i < 10; i++) {
		for (int j = 0; j < 10; j++)
			printf("%.1f ", ar[i][j]);
		printf("\n");
	}
}

int main() {
	float matrix[10][10];      // Матрица 10 порядка.
	GenerateMatrix(matrix, x); // Генерация матрицы.

	PrintMatrix(matrix);  // Вывод матрицы на экран.

    getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}

