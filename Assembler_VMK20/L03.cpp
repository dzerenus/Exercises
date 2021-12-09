#include <iostream>

int main()
{
    /*
    * Лабораторная работа #3
    * 
    * Задание: 
    * Разработать программу на встроенном Ассемблере в соответствии с заданием по вариантам.
    * 
    * Условие:
    * На высокором уровне осуществляется только создание переменных, а так же ввод и вывод
    * из значений через консоль. Все остальные действия додны выполняться на ассемблере.
    * 
    * Вариант 17:
    * Даны целые числа k, m, x, y, z.
    * При k < m^2 — заменить значение X его модулем, а от Y и Z отнять по единице.
    * При k = m^2 — заменить значение Y его модулем, а от X и Z отнять по единице.
    * При k > m^2 — заменить значение Z его модулем, а от X и Y отнять по единице.
    */

    long k = 4;
    short m = 1;
    short x = -12;
    short y = -2;
    short z = -3;

    short xa = 0;
    short ya = 0;
    short za = 0;

    __asm
    {
        mov ebx, k;
        mov ax, m;
        mul ax;

        cmp ax, bx;
        jl First;
        je Second;
        jg Third;

    First:
        mov cx, y;
        add cx, -1;
        mov ya, cx;

        mov cx, z;
        add cx, -1;
        mov za, cx;

        mov cx, x;
        mov xa, cx;
        cmp cx, 0;
        jl NegativeFirst;
        jmp EndIF;

    NegativeFirst:
        neg cx;
        mov xa, cx;
        jmp EndIF;

    Second:
        mov cx, x;
        add cx, -1;
        mov xa, cx;

        mov cx, z;
        add cx, -1;
        mov za, cx;

        mov cx, y;
        mov ya, cx;
        cmp cx, 0;
        jl NegativeSecond;
        jmp EndIF;

    NegativeSecond:
        neg cx;
        mov ya, cx;
        jmp EndIF;

    Third:
        mov cx, x;
        add cx, -1;
        mov xa, cx;

        mov cx, y;
        add cx, -1;
        mov ya, cx;

        mov cx, z;
        mov za, cx;
        cmp cx, 0;
        jl NegativeThird;
        jmp EndIF;

    NegativeThird:
        neg cx;
        mov za, cx;
        jmp EndIF;

    EndIF:
    }

    std::cout << "x: " << xa << std::endl;
    std::cout << "y: " << ya << std::endl;
    std::cout << "z: " << za << std::endl;
}