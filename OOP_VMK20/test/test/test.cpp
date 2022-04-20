#include <iostream>

int get1(int a, int b)
{
    while (a != b)
    {
        if (a > b)
        {
            unsigned t = a;
            a = b;
            b = t;
        }

        b = b - a;
    }

    return a;
}

int get2(int a, int b)
{
    for (size_t i = 2; i <= 9; i++)
    {

    }
}

int main()
{
    unsigned a; std::cin >> a;
    unsigned b; std::cin >> b;

    long res = a * b / get1(a, b);
    std::cout << res;
}
