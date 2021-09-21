#include <stdio.h> 
#include <stdlib.h> 
#define BUF 11 

int main()
{

	int count = 0;

    char filename[] = "Z12_file.txt", temp[BUF]; 
    FILE * stream; 

    errno_t err = fopen_s(&stream, filename, "r"); 
    if (err != 0) printf("The file is not found!"); 

    else
    {  
        int number; 
        while (!feof(stream))
        {
            fscanf(stream, "%s", temp, BUF); 
            number = atoi(temp); 
            
            printf("%d\n", number);

            if (number % 2 == 0) count++;
        }  

        fclose(stream); 
    }  

    printf("%d", count);
    getchar(); getchar();
    return 0; 
 } 