// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;

int sumNum(int a, int b)
{
    int c;
    c = a + b;
    return c;
}
float Average(int a[], int n)
{
	int b, i;
	float result;
	b = 0;
	for (i = 0; i < n; i++)
	{
		b += a[i];
	}
	result = (float)b / n;
	return result;
}
int main()
{
	int a[5];
	int i;
	int n = sizeof(a) / 4;
	for (i = 0; i < n; i++)
	{
		cout << "a[" << i << "] = ";
		cin >> a[i];
	}
	cout << "The average of this array is: " << Average(a, n) << endl;
	if ((Average(a, n) > 10) || (Average(a, n) == 10))
		cout << " Double digits\n";
	else
		cout << "Single Digits\n";
	system("pause");
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
