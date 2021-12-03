#include <iostream>

int main()
{
    static const int BASE = 10000;
    const short ARSIZE = 10;

    short tmp = 0;

    int digits[ARSIZE];
    
    __asm
    {
        mov ax, ARSIZE;
        mov bx, 0;

        cmp bx, ax;
        jl Less;

    Less:
        mov digits[tmp], 0;
    }

    std::cout << digits[0];
}