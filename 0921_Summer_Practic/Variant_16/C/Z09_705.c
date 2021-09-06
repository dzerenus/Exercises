#include <stdio.h>   // PrintF
#include <stdlib.h>  // Random

const int N = 3;  // Порядок матрицы.

// Заполнить матрицу случайными числами.
void RNDMatrix(double matrix[][N])
{
	for (int i = 0; i < N; i++)
		for (int j = 0; j < N; j++)
			matrix[i][j] = rand()%10;
}

// Вывод матрицы на экран.
void PrintMatrix(double matrix[][N])
{
	for (int i = 0; i < N; i++) 
	{
		for (int j = 0; j < N; j++)
			printf("%.2f ", matrix[i][j]);

		printf("\n");
	}
}

// Заполнить матрицу единицами.
void CreateEMatrix(double matrix[][N])
{
	for (int i = 0; i < N; i++)
		for (int j = 0; j < N; j++)
			matrix[i][j] = 1;
}

// Процедура рассчёта C матрицы.
void CreateCMatrix(double matrix[][N])
{
	for (int i = 0; i < N; i++)
		for (int j = 0; j < N; j++)
			matrix[i][j] = 1.0/(i+j+2);
}

// Сложение двух матриц в третью.
void Addition(double a[][N], double b[][N], double r[][N])
{
	for (int i = 0; i < N; i++)
		for (int j = 0; j < N; j++)
			r[i][j] = a[i][j] + b[i][j];
}

// Вычитание двух матриц в третью.
void Subtraction(double a[][N], double b[][N], double r[][N])
{
	for (int i = 0; i < N; i++)
		for (int j = 0; j < N; j++)
			r[i][j] = a[i][j] - b[i][j];
}

// Умножение двух матриц в третью.
void Multiplication(double a[][N], double b[][N], double r[][N])
{
	for (int i = 0; i < N; i++)
		for (int j = 0; j < N; j++)
		{
			r[i][j] = 0;
			
			for (int g = 0; g < N; g++)
				r[i][j] += (a[i][g] * b[g][j]);
		}
}

int main()
{	
	// Заготовки под матрицы.
	double aMat[N][N];  // А матрица.
	double bMat[N][N];  // B матрица.
	double eMat[N][N];  // Единичная.
	double cMat[N][N];  // C матрица.
	double tMat[N][N];  // Временная.
	double gMat[N][N];  // Временная.
	double rMat[N][N];  // Результат.

	// Грузим случайные числа в матрицы.
	RNDMatrix(aMat);
	RNDMatrix(bMat);

	// Грузим матрицу единицами.
	CreateEMatrix(eMat);

	// Рассчитываем C матрицу.
	CreateCMatrix(cMat);

	// Отнять от B матрицы E матрицу.
	Subtraction(bMat, eMat, tMat);

	// Умножить A матрицу на T матрицу.
	Multiplication(aMat, tMat, gMat);

	// Сложить и записать результат.
	Addition(gMat, cMat, rMat);

	// Выводим матрицы на экран. 
	printf("\n> A Matrix:\n");
	PrintMatrix(aMat);

	printf("\n> B Matrix:\n");
	PrintMatrix(bMat);

	printf("\n> E Matrix:\n");
	PrintMatrix(eMat);

	printf("\n> C Matrix:\n");
	PrintMatrix(cMat);

	printf("\n> Result:\n");
	PrintMatrix(rMat);

	getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}