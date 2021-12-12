#include <vector>
#include <stdexcept>
#include <cstdlib>
#include <iostream>
#include "TMatrix.h"

using namespace std;

template <typename T>
const size_t TMatrix<T>::ColCount() const { return this->content[0].size(); }

template <typename T>
const size_t TMatrix<T>::RowCount() const { return this->content.size(); }


template <typename T>
TMatrix<T>::TMatrix(int width, int height)
{
	if (width <= 0 && height <= 0)
		throw invalid_argument("Invalid matrix size!");

	if (!is_same<T, int>::value && !is_same<T, double>::value)
		throw invalid_argument("Wrong Matrix Type!");
	
	vector <vector<T>> c (height, vector<T>(width));
	this->content = c;
}

template <typename T>
void TMatrix<T>::resize(int width, int height)
{
	for (int i = 0; i < this->content.size(); i++)
		this->content[i].resize(width);
	this->content.resize(height);
}

template <typename T>
void TMatrix<T>::fill(T val)
{
	for (int i = 0; i < this->content.size(); i++)
		for (int j = 0; j < this->content[i].size(); j++)
			this->content[i][j] = val;
}

template <typename T>
void TMatrix<T>::fill_random(int low, int high)
{
	for (int i = 0; i < this->content.size(); i++)
		for (int j = 0; j < this->content[i].size(); j++)
			this->content[i][j] = (T)(low + rand() % (low + high + 1));
}

template <typename T>
void TMatrix<T>::tran()
{
	auto height = this->content.size();
	auto width = this->content[0].size();
	vector <vector<T>> c(width, vector<T>(height));

	for (int i = 0; i < this->content.size(); i++)
		for (int j = 0; j < this->content[i].size(); j++)
			c[j][i] = this->content[i][j];

	this->content = c;
}

template <typename T>
void TMatrix<T>::diagonal(T val)
{
	if (content.size() != content[0].size())
		throw invalid_argument("Matrix is not square!");

	for (int i = 0; i < this->content.size(); i++)
		content[i][i] = val;
}

template <typename T>
T& TMatrix<T>::operator[](int index) { return content[index]; }

template <typename T>
TMatrix<T> TMatrix<T>::operator + (const TMatrix<T>& mat)
{
	if (mat.ColCount() != this->ColCount() || mat.RowCount() != this->RowCount())
		throw invalid_argument("Error of matrix size!");

		TMatrix<T> n = TMatrix<T>(ColCount(), RowCount());

	for (int i = 0; i < this->content.size(); i++)
		for (int j = 0; j < this->content[i].size(); j++)
			n[i][j] = content[i][j] + mat[i][j];

	return n;
}

template <typename T>
TMatrix<T> TMatrix<T>::operator - (const TMatrix<T>& mat)
{
	if (mat.ColCount() != this->ColCount() || mat.RowCount() != this->RowCount())
		throw invalid_argument("Error of matrix size!");

		TMatrix<T> n = this;

	for (int i = 0; i < this->content.size(); i++)
		for (int j = 0; j < this->content[i].size(); j++)
			n[i][j] -= mat[i][j];

	return n;
}

template <typename T>
template <typename M>
TMatrix<T> TMatrix<T>::operator * (const M& multiplier)
{
	TMatrix<T> n = this;

	if (is_same<M, int>::value || is_same<M, double>::value)
		for (unsigned i = 0; i < n.RowCount(); i++)
			for (unsigned j = 0; j < n.ColCount(); j++)
				n[i][j] = (T)(multiplier * (M)n[i][j]);

	else if (is_same<M, TMatrix<T>>::value)
	{
		TMatrix<T> m = (TMatrix<T>)multiplier;
		
		if (m.RowCount() != this->ColCount())
			throw invalid_argument("Invalid Matrix Size!");

		for (unsigned i = 0; i < this->RowCount(); i++)
			for (unsigned j = 0; j < m.ColCount(); j++)
			{
				n[i][j] = 0;

				for (unsigned k = 0; k < this->ColCount(); k++)
					n[i][j] += this[i][k] * m[k][j];
			}
	}

	else throw invalid_argument("Invalid operand type!");

	return n;
}

template <typename T>
std::ostream& operator<< (std::ostream& out, const TMatrix<T>& m)
{
	unsigned short offset = 0;

	if (is_same<T, int>::value)
	{
		for (unsigned i = 0; i < this->RowCount(); i++)
			for (unsigned j = 0; j < this->ColCount(); j++)
			{
				auto nc = numbers_count(this->content[i][j]);
				if (nc > offset) offset = nc;
			}
		
		for (unsigned i = 0; i < this->RowCount(); i++)
			for (unsigned j = 0; j < this->ColCount(); j++)
			{
				unsigned lOffset = offset - numbers_count(this->content[i][j]) + 1;
				if (this->content[i][j] > 0) lOffset++;

				string sOffset(lOffset, ' ');
				cout << sOffset << this->Content[i][j];

				if (j == this->ColCount() - 1) cout << endl;
			}
	}
}

const int numbers_count(int num)
{
	unsigned result = 0;

	for (; num > 0; result++) { num /= 10; }

	return result;
}
