#include <iostream>  // Ну ввод-вывод.
#include <string>    // Ну строки.
#include <vector>    // Ну векторы.

using namespace std;

/// <summary>
/// Перевод string в vector состоящий из int.
/// Иначе говоря, разделение строки на массив, состоящий из целых чисел.
/// </summary>
/// <param name="a">Строка из чисел.</param>
/// <returns>vector заполненный int.</returns>
vector<int> SplitStringToInts(const string& a)
{
    vector<int> nums;

    unsigned index = 0;

    for (int i = 0; i < a.length(); i++)
        if (a[i] == ' ')
        {
            string sub = a.substr(index, i - index);
            nums.push_back(stoi(sub));

            index = i+1;
        }

    string sub = a.substr(index, a.length() - index);
    nums.push_back(stoi(sub));

    return nums;
}

string BinaryFind(int n, vector<int>& nums)
{   
    int size = nums.size();
    int sIndex = 0;
    int eIndex = size - 1;

    while (1)
    {
        if (n == nums[sIndex]) return "YES";
        if (n == nums[eIndex]) return "YES";

        if (n < nums[sIndex]) return "NO";
        if (n > nums[eIndex]) return "NO";

        int c = (sIndex + eIndex) / 2;
        
        if (n < nums[c]) eIndex = c-1;
        else if (n > nums[c]) sIndex = c+1;
        else return "YES";

        if (sIndex > eIndex) return "NO";
    }
}

int main()
{   
    // Блок ввода данных.
    string i1, i2, i3;
    getline(cin, i1);
    getline(cin, i2);
    getline(cin, i3);

    vector<int> numsA = SplitStringToInts(i2);
    vector<int> numsB = SplitStringToInts(i3);

    for (int i = 0; i < numsB.size(); i++)
    {
        string res = BinaryFind(numsB[i], numsA);
        cout << res << endl;
    }

    return 0;
}