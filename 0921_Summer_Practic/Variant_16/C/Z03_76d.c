#include <stdio.h>  // Printf, Scanf
#include <math.h>   // Математика


// Переменные для работы программы.
int x, y, k, l, m, n;

int main() {
    // Ввод входных данных.
    printf("Input width: ");
    scanf("%d", &x);

    printf("Input height: ");
    scanf("%d", &y);

    printf("Input figure X: ");
    scanf("%d", &k);

    printf("Input figure Y: ");
    scanf("%d", &l);

    printf("Input target X: ");
    scanf("%d", &m);

    printf("Input target Y: ");
    scanf("%d", &n);

    if (x < 1 || y < 1 || k < 0 || l < 0 || m < 0 || n < 0 ||
        k > x || l > y || m > x || n > y) {
        printf("WRONG!");
    }

    else {
        if (k == m || l == n || (abs(n-l) == abs(m-k))) {
            printf("One Move!");
        }

        else {
            int hor = m - k;
            int ver = n - l;

            printf("Two Move!");
            printf("\nFirst: Go X on %d cells", hor);
            printf("\nSecond: Go Y on %d cells", ver);
        }
    }
    

    getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}