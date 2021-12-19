#include "Coordinates.h"
#include <string>
#include <stdexcept>

/* >>> by ShpriZZ <<< */

using namespace std;

const string Coordinates::to_string()
{
	string res = "";
	res += "X:" + std::to_string(X()) + " ";
	res += "Y:" + std::to_string(Y()) + " ";
	res += "Z:" + std::to_string(Z());
	return res;
}

const double Coordinates::X() { return x; };
void Coordinates::X(double x)
{
	if (x < 0) throw invalid_argument("Error X!");
	this->x = x;
}

const double Coordinates::Y() { return y; };
void Coordinates::Y(double y)
{
	if (y < 0) throw invalid_argument("Error Y!");
	this->y = y;
}

const double Coordinates::Z() { return z; };
void Coordinates::Z(double z)
{
	if (z < 0) throw invalid_argument("Error Z!");
	this->z = z;
}

Coordinates::Coordinates(double x, double y, double z)
{
	X(x);
	Y(y);
	Z(z);
}
