#include <iostream>  // Ну ввод-вывод.
#include <string>    // Ну строки.
#include <vector>    // Ну векторы.
#include <algorithm> // Ну сортировка.

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

int main()
{   
    // Блок ввода данных.
    string i1, i2, i3;
    getline(cin, i1);
    getline(cin, i2);
    getline(cin, i3);

    vector<int> nums = SplitStringToInts(i2);
    sort(nums.begin(), nums.end());

    for (int i = 0; i < stoi(i3); i++)
    {
        string input;
        getline(cin, input);
        vector<int> cmds = SplitStringToInts(input);

        int sindex = 0;
        int eindex = 0;

        if (cmds[1] < nums[0] || cmds[0] > nums[nums.size() - 1])
        {
            cout << 0 << endl;
            continue;
        }

        while (sindex < nums.size() && nums[sindex] < cmds[0]) sindex++;
        eindex = sindex;
        while (eindex < nums.size() && nums[eindex] <= cmds[1]) eindex++;

        cout << eindex - sindex << endl;
    }
}