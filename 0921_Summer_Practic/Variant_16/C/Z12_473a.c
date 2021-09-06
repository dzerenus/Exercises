#include <stdio.h> // Работа с файлами и PrintF.

const char NAME[] = "Z12_file.txt";  // Имя файла.

int main() {
	int count = 0; // Счётчик чётных чисел.

	FILE *fp;              // Создаем файловый поток. 
	fp = fopen(NAME, "r"); // Открываем файл для чтения.

	// Пока не достигнут конец файла.
	while(feof(fp) == 0) {
		char symb = fgetc(fp); // Читаем символ.
		int num = symb - '0';  // Переводим в int.

		// Если число чётное, увеличиваем счётчик.
		if (num % 2 == 0) count++;
	}

	printf("%d", count); // Выводим количество.

	fclose(fp);           // Закрываем поток.
	getchar(); getchar(); // Пауза.
	return 0;             // Выход.
}