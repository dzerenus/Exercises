#include <iostream>

#include "Cargo.h"
#include "Bulk.h"
#include "Piece.h"
#include "Coordinates.h"

/* >>> by ShpriZZ <<< */

using namespace std;

int main()
{
    // Создание общего класса.
    auto s = Cargo(12000, 1500000, 0);
    cout << s.to_string() << endl << endl;

    // Создание экземпляра класса жидкого/газообразного груза.
    auto b = Bulk(130, 7500, 1250000, 2);
    cout << b.to_string() << endl << endl;

    // Создание экземпляра класса штучного груза.
    auto p = Piece(300, Coordinates(0.5, 2, 0.5), 6000, 900000, 0);
    cout << p.to_string() << endl << endl;

    // Возможность засунуть в массив типа класса родителя экземпляров классов-наследников.
    Cargo arr[3];
    arr[0] = s;
    arr[1] = b;
    arr[2] = p;
}