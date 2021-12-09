#include <iostream>

int main()
{
    char a = 2;
    char b = 3;
    char c = 4;

    short res;

    __asm 
    {
        sqrtsd 3
    }

    std::cout << res;


}