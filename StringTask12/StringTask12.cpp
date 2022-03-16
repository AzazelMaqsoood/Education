
#include <iostream>
#include <string>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Ru");

	char buff[10];
	string fullInit = "Иванов Иван Иванович";
	string family = fullInit;
	string fatherName;
	string name = fullInit;
	int temp;

	family = family.erase(family.find(' '));

	while (true)
	{
		int index = name.find(' ');
		if (index == string::npos)
		{
			break;
		}

		name.insert(name.begin() + index + 2, '.');
		name.erase(index, 1);
		//name.insert(name.begin() + index, ' ');

		name.erase(0, index);
		name.erase(name.find('.') + 1);
		break;
	}

	temp = name.length() + family.length();

	for (int i = temp; i < fullInit.length(); i++)
	{
		if (fullInit[i] == ' ')
		{
			fullInit.insert(fullInit.begin() + i + 2, '.');
			fullInit.erase(i, 1);
			fullInit.erase(0, i);
			fatherName = fullInit.erase(fullInit.find('.') + 1);
		}
	}


	cout << fatherName << name << family;
}

