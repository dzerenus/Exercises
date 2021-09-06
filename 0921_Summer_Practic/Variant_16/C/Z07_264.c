#include <stdio.h>  // Printf, Scanf.
#include <string.h> // Strlen.

int main()
{	
	// Создаём и считываем строку.
	char str[256]; scanf("%s", str);

	// Переменные под номер скобок.
	int op = 999;
	int cl = 999;

	while (1)
	{
		int charCount = strlen(str);

		for (int i = 0; i < charCount; i++)
		{
			if (str[i] == '(')
				op = i;

			if (str[i] == ')' && op != 999)
				cl = i;
		}

		if (cl != 999)
		{
			int len = cl - op;

			for (int i = 0; i < 256-len; i++)
				if (i >= op) str[i] = str[i+len+1];

			op = 999;
			cl = 999;
		}

		else break;
	}

	printf("%s\n", str);

	getchar(); getchar(); // Пауза.
    return 0;  			  // Выход.
}