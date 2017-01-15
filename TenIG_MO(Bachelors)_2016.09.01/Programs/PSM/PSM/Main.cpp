#include<iostream>
#include<cmath>

using namespace std;

double Func(double);

int main()
{
	double x0 = -3, x1, Epsilon = 0.01, H0 = 0.2, H1, R = 2, fx0, fx1, yf0, yf1;	// 
	int k, k_Max = 6;																// Input
	cout << "Input: x0 = " << x0 << "\n       Epsilon = " << Epsilon << "\n       H0 = " << H0 << "\n       R = " << R << "\n       k_Max = " << k_Max << endl;
	cout << "       f(x) =  x^3 + x^2 - 8 * x - 8\n" << endl;
	
	// Step 1
	cout << "Step 1 Function(x0) = ";
	yf0 = fx0 = Func(x0);

	// Step 2
	cout << "Step 2 H1 = H0 => H1 = " << H0 << endl << endl;
	H1 = H0;
	
	// Step 3
	cout << "Step 3 x1 = x0 + H1 => x1 = " << x0 << " + " << H1 << " = " << x0 + H1 << endl << endl;
	x1 = x0 + H1;

	// Step 4
	cout << "Step 4 Function(x1) = ";
	yf1 = fx1 = Func(x1);

	// Step 5
	cout << "Step 5 k = 0\n\n";
	k = 0;

	// Iterations
	do
	{
		if (k > 0)cout << "true\n\n";
		// Step 1
		cout << "Iteration " << ++k << endl;
		cout << "\n Step 1 k = k + 1 = " << k << endl;
		// Step 2
		cout << "\n Step 2 yf1 <= yf0 => " << yf1 << " <= " << yf0 << " - ";
		if (yf1 <= yf0)
		{
			cout << "true\n\n";
			cout << " Step 3 ABS(H0) < Epsilon/R => " << abs(H0) << " < " << Epsilon << "/" << R << " - ";
			if (abs(H0) < (Epsilon / R))
			{
				cout << "true\n\n";

				cout << " Step 4 H1 = H0 => H1 = " << H0 << endl << endl;
				H1 = H0;

				cout << " Step 5 x1 = x0 => x1 = " << x0 << endl << endl;
				x1 = x0;

				cout << " Step 6 yf1 = yf0 => yf1 = " << yf0 << endl << endl;
				yf1 = yf0;
				system("pause");
			}
			else
			{
				cout << "false\n\n";

				cout << " Step 4 H1 = -H0 / R => H1 = " << -H0 << " / " << R << " = " << -H0/R << endl << endl;
				H1 = -H0 / R;

				cout << " Step 5 H0 = H1 => H0 = " << H1 << endl << endl;
				H0 = H1;

				cout << " Step 6 x0 = x1 => x0 = " << x1 << ";\t yf0 = yf1 => yf0 = " << yf1 << endl << endl;
				x0 = x1;	yf0 = yf1;

				cout << " Step 7 x1 = x0 + H1 => x1 = " << x0 << " + " << H1 << " = " << x0 + H1 << endl << endl;
				x1 = x0 + H1;

				cout << " Step 8 Function(x1) = ";
				yf1 = fx1 = Func(x1);

				cout << " Step 9 "; //if(k < k_Max)
			}
		}
		else
		{
			cout << "false\n\n";

			cout << " Step 3 H1 = H0 => H1 = " << H0 << endl << endl;
			H1 = H0;

			cout << " Step 4 x0 = x1 => x0 = " << x1 << ";\t";			x0 = x1;
			cout << " yf0 = yf1 => yf0 = " << yf1 << endl << endl;			yf0 = yf1;
			
			cout << " Step 5 x1 = x0 + H1 => x1 = " << x0 << " + " << H1 << " = " << x0 + H1 << endl << endl;
			x1 = x0 + H1;

			cout << " Step 6 Function(x1) = ";
			yf1 = fx1 = Func(x1);

			cout << " Step 7 ";
		}
		cout << "k < k_max => " << k << " < " << k_Max << " - ";
	} while (k < k_Max);
	cout << "false\n\n";

	cout << "Output: ";
	cout << "x1 = " << x1 << endl;
	cout << "        yf1 = " << yf1 << endl;
	cout << "        k = " << k << endl;
	cout << "        abs(H0) = " << abs(H0) << "\n\n\n";

	system("pause");
	return 0;
}

double Func(double x)
{
	cout << x << "^3 + " << x << "^2 - 8 * " << x << " - 8 = " << pow(x, 3) + pow(x, 2) - 8 * x - 8 << "\n\n";
	return pow(x, 3) + pow(x, 2) - 8 * x - 8;
}