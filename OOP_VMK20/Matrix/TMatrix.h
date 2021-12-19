#pragma once
#include <vector>
#include <iostream>
#include <string>

using namespace std;

template <typename T>
class TMatrix
{
public:
	const size_t ColCount() const;                         // X1
	const size_t RowCount() const;                         // X2

	TMatrix(int width, int height);                     // X3

	/*template <typename M>
	friend TMatrix<T>& operator *= (T& a, const M& m);
	friend TMatrix<T>& operator += (T& a, const T& b);
	friend TMatrix<T>& operator -= (T& a, const T& b);*/
	
	//template <typename M>
	//TMatrix<T> operator * (const M& multiplier);      // X4
	//TMatrix<T> operator + (const TMatrix<T>& mat);    // X2
	//TMatrix<T> operator - (const TMatrix<T>& mat);    // X3
	std::vector<T> operator[](int index);                         // X1

	friend std::ostream& operator<< (std::ostream& out, const TMatrix<T>& m)
	{
		unsigned short offset = 0;

		if (is_same<T, int>::value)
		{
			for (unsigned i = 0; i < m.RowCount(); i++)
				for (unsigned j = 0; j < m.ColCount(); j++)
				{
					unsigned result = 0;
					auto val = m[i][j];
					for (; val > 0; result++) { val /= 10; }

					if (result > offset) offset = result;
				}
		
			for (unsigned i = 0; i < m.RowCount(); i++)
				for (unsigned j = 0; j < m.ColCount(); j++)
				{
					unsigned result = 0;
					auto val = m[i][j];
					for (; val > 0; result++) { val /= 10; }

					unsigned lOffset = offset - result + 1;
					if (m[i][j] > 0) lOffset++;

					string sOffset(lOffset, ' ');
					out << sOffset << m[i][j];

					if (j == m.ColCount() - 1) out << endl;
				}
		}
		return out;
	}
	
	//void fill_random(int low, int high);              // X3
	void fill(T val);                                 // X2
	//void tran();                                      // X4
	//void diagonal(T val);                             // X5
	//void resize(int width, int height);               // X1
	//const T determinant() const;
	//TMatrix<T> inverse();
	//std::vector<T> get_roots();

private:
	std::vector<std::vector<T>> content;
};