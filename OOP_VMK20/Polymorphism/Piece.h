#pragma once
#include "Cargo.h"
#include "Coordinates.h"
#include <string>

/* >>> by ShpriZZ <<< */

class Piece : public Cargo
{
	/// <summary>
	/// Груз, который можно измерить количеством.
	/// </summary>

	int count;        // Количество.
	Coordinates size; // Размеры груза.

public:
	// GET SET количество.
	const int Count();
	void Count(int c);

	// GET SET Размеры.
	const Coordinates Size();
	void Size(const Coordinates& s);

	// GET объем одного элемента груза.
	const double GetPieceVolume();

	// GET массу одного элемента груза.
	const double GetPieceMass();

	std::string to_string();

	// Конструктор
	Piece(int c, const Coordinates& s, double m, int p, short d);
};

