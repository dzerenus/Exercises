#include <stdexcept>
#include <string>

#include "Piece.h"
#include "Cargo.h"
#include "Coordinates.h"

/* >>> by ShpriZZ <<< */

using namespace std;

const int Piece::Count() { return this->count; }
void Piece::Count(int c)
{
	if (c < 0) throw invalid_argument("Invalid Count!");
	this->count = c;
}

const Coordinates Piece::Size() { return this->size; }
void Piece::Size(const Coordinates& s)
{
	if (s.X <= 0) throw invalid_argument("Invalid X!");
	if (s.Y <= 0) throw invalid_argument("Invalid Y!");
	if (s.Z <= 0) throw invalid_argument("Invalid Z!");

	this->size = s;
}

const double Piece::GetPieceVolume() { return (size.X * size.Y * size.Z); }
const double Piece::GetPieceMass() { return this->Cargo::Mass() / count; }

const string Piece::to_string()
{
	string res = this->Cargo::to_string();
	res = "Piece. " + res + " ";
	res += "Sizes: (" + this->size.to_string() + ") ";
	res += "Count: " + std::to_string(this->count) + " ";
	res += "Piece Volume: " + std::to_string(GetPieceVolume()) + " ";
	res += "Piece Mass: " + std::to_string(GetPieceMass()) + " ";

	return res;
}

Piece::Piece(int c, const Coordinates& s, double m, int p, short d) : Cargo(m, p, d)
{
	Count(c);
	Size(s);
}
