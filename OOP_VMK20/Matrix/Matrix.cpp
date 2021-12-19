#include <iostream>
#include "TMatrix.h"

using namespace std;

int main()
{
	auto a = TMatrix<int>(4, 5);
	a.fill(3);

	cout << a;

}