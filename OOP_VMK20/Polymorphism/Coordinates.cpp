#include "Coordinates.h"
#include <string>

/* >>> by ShpriZZ <<< */

using namespace std;

const string Coordinates::to_string()
{
	string res = "";
	res += "X:" + std::to_string(X) + " ";
	res += "Y:" + std::to_string(Y) + " ";
	res += "Z:" + std::to_string(Z);
	return res;
}

Coordinates::Coordinates(double x, double y, double z)
{
	this->X = x;
	this->Y = y;
	this->Z = z;
}
