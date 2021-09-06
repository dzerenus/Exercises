#include <stdio.h> // Работа с файлами и PrintF.

// Имена сравняемых файлов.
static char FNAME[] = "Z13_f.txt";
static char GNAME[] = "Z13_g.txt";

int main() {
	// Номера текущего символа и строки.
	int coluNum = 1;
	int lineNum = 1;

	// Создаём потоки и открываем файлы.
	FILE *ffile, *gfile;
	ffile = fopen(FNAME, "r");
	gfile = fopen(GNAME, "r");

	printf("Concurence: ");

	while (1){
		// Если оба файла закончены, совпадение произошло.
		if (feof(ffile) && feof(gfile)) {
			printf("True!\n");
			break;
		}

		// Если оба файла не закончены, продолжаем анализ.
		else if (!feof(ffile) && !feof(gfile)) {
			// Получаем символы из файлов.
			char fsym = fgetc(ffile);
			char gsym = fgetc(gfile);

			// Если символы схожи.
			if (fsym == gsym) {
				// Если символ - перенос строки.
				if (fsym == '\n') {
					coluNum = 1;
					lineNum++;
				}
				else coluNum++;
			}

			else 
			{
				printf("False!\nLines: %d\nColumns: %d\n", lineNum, coluNum);
				break;
			}
		}
	}

	// Закрываем файловые потоки.
	fclose(ffile);
	fclose(gfile);

	getchar(); getchar(); // Пауза.
	return 0;             // Выход.
}