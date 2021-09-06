#include <stdio.h> // PrintF и ScanF.

const int N = 5; // Количество узлов.

// Узел односвязного списка.
typedef struct Unit {
	float value;       // Значение узла.
	struct Unit *next; // Ссылка на следующий.
} Unit;

int main() {

	Unit head*;

	getchar(); getchar(); // Пауза.
	return 0;             // Выход.
}