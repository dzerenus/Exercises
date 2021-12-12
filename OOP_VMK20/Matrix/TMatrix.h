#pragma once
#include <vector>

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
	
	template <typename M>
	TMatrix<T> operator * (const M& multiplier);      // X4
	TMatrix<T> operator + (const TMatrix<T>& mat);    // X2
	TMatrix<T> operator - (const TMatrix<T>& mat);    // X3
	T& operator[](int index);                         // X1

	//friend std::ostream& operator<< (std::ostream& out, const TMatrix<T>& m); // X1
	
	void fill_random(int low, int high);              // X3
	void fill(T val);                                 // X2
	void tran();                                      // X4
	void diagonal(T val);                             // X5
	void resize(int width, int height);               // X1
	//const T determinant() const;
	//TMatrix<T> inverse();
	//std::vector<T> get_roots();

private:
	std::vector<std::vector<T>> content;
};

const int numbers_count(int num);