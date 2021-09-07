#include <stdio.h> // Работа с файлами и PrintF.

// Задача 477
// > Даны символьные файлы f 1 и f 2. Переписать с сохранением порядка следования компоненты файла f 1 в файл f 2, 
//   а компоненты файла f 2 - в файл f 1. Использовать вспомогательный файл h.

const char F1NAME[] = "Z12_f1.txt";  // Имя файла.
const char F2NAME[] = "Z12_f2.txt";  // Имя файла.
const char HNAME[] = "Z12_h.txt";  // Имя файла.

int main() 
{	
	FILE *f1p, *f2p, *hp;      // Создаем файловый поток. 
	f1p = fopen(F1NAME, "r+"); // Открываем файл для записи.
	hp = fopen(HNAME, "w");    // Перезаписываем файл.

	// Пока не достигнут конец файла.
	while(feof(f1p) == 0) {
		char symb = fgetc(f1p); // Читаем символ.
		fputc(symb, hp);        // Записываем во вспомогательный.
	}

	// Переоткрываем файл, чтобы всё стереть из него.
	fclose(f1p);
	fclose(hp);

	f1p = fopen(F1NAME, "w");
	f2p = fopen(F2NAME, "r+"); // Открываем файл для записи.

	// Пока не достигнут конец файла.
	while(feof(f2p) == 0) {
		char symb = fgetc(f2p);  // Читаем символ.
		fputc(symb, f1p);        // Записываем в первый файл.
	}

	// Переоткрываем файл, чтобы всё стереть из него.
	fclose(f2p);
	fclose(f1p);

	f2p = fopen(F2NAME, "w");
	hp = fopen(HNAME, "r+");    // Перезаписываем файл.

	// Пока не достигнут конец файла.
	while(feof(hp) == 0) {
		char symb = fgetc(hp);   // Читаем символ.
		fputc(symb, f2p);        // Записываем во второй файл.
	}

	// Закрываем потоки.
	fclose(f1p);       
	fclose(f2p);
	fclose(hp);

	printf("OK!\n");

	getchar(); getchar(); // Пауза.
	return 0;             // Выход.
}