#include <iostream>
#include <string>
#include <vector>

using namespace std;

string strWord(int index, string line)
{
    int count = 0; // number of read words
    string word; // the resulting word
    for (int i = 0 ; i < line.length(); i++) { // iterate over all characters in 'line'
        if (line[i] == ' ') { // if this character is a space we might be done reading a word from 'line'
            if (line[i+1] != ' ') { // next character is not a space, so we are done reading a word
                count++; // increase number of read words
                if (count == index) { // was this the word we were looking for?
                    return word; // yes it was, so return it
                }
                word =""; // nope it wasn't .. so reset word and start over with the next one in 'line'
            }
        }
        else { // not a space .. so append the character to 'word'
           word += line[i];
        }       
    }
}

int main() 
{
	int d; cin >> d;

	vector<int> cash = {};

	for (int i = 0; i < d; ++i)
	{
		string command; cin >> command;

		if (command == "pop" && cash.size() > 0)
			cash.pop_back();

		else if (command == "max")
		{
			int max = 0;
			for (int j = 0; j < cash.size(); ++j)
			{
				int cupure = cash[j];
				if (cupure > max)
					max = cupure;
			}
			cout << max << endl;
		}

		else
		{
			cout << command.substr(1, command.length()-1);
			
		}
	}

	return 0;
}