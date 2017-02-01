#include<iostream>
#include<cmath>

using namespace std;

double function(double);

int main()
{
	long double a = -4, b = 0, r, x1, x2, f1, f2, tol = 0.01;
	int k, k_Max = 40;

	cout << "Input: a = " << a << "\n       b = " << b << "\n       k_Max = " << k_Max << endl;
	cout << "       f(x) =  x^3 + x^2 - 8 * x - 8\n" << endl;

	r = (sqrt(5.0) - 1) / 2;
	cout << "Step 1 r = (5^1/2 - 1) / 2 = " << r << "\n\n";
	
	x1 = a + (1 - r) * (b - a);
	cout << "Step 2 x1 = a + (1 - r) * (b - a) => x1 = " << a << " + (1 - " << r << ") * (" << b << " - " << a << ") = " << x1 << endl << endl;

	cout << "Step 3 f(x1) = ";
	f1 = function(x1);
	
	x2 = a + r * (b - a);
	cout << "Step 4 x2 = a + r * (b - a) => x2 = " << a << " + " << r << " * (" << b << " - " << a << ") = " << x2 << endl << endl;

	cout << "Step 5 f(x2) = ";
	f2 = function(x2);

	k = 0;
	cout << "Step 6 k = " << k << endl << endl;

	do
	{
		if (k > 0)cout << "true\n\n";
		// Step 1
		cout << "Iteration " << ++k << endl;
		cout << "\n Step 1 k = k + 1 = " << k << endl;
		// Step 2
		cout << "\n Step 2 f1 < f2 => " << f1 << " < " << f2 << " - ";
		if (f1 < f2)
		{
			cout << "true\n\n";

			cout << " Step 3 a = x1 => a = " << x1 << endl << endl;
			a = x1;

			cout << " Step 4 x1 = x2 => x1 = " << x2 << endl << endl;
			x1 = x2;

			cout << " Step 5 f1 = f2 => f1 = " << f2 << endl << endl;
			f1 = f2;

			x2 = a + r * (b - a);
			cout << " Step 6 x2 = a + r * (b - a) => x2 = " << a << " + " << r << " * (" << b << " - " << a << ") = " << x2 << endl << endl;
			f2 = function(x2);
			cout << " Step 7 k < k_Max - ";
		}
		else
		{
			cout << "false\n\n";

			cout << " Step 3 b = x2 => b = " << x2 << endl << endl;
			b = x2;

			cout << " Step 4 x2 = x1 => x2 = " << x1 << endl << endl;
			x2 = x1;
			
			cout << " Step 5 f2 = f1 => f2 = " << f1 << endl << endl;
			f2 = f1;

			x1 = a + (1 - r) * (b - a);
			cout << " Step 6 x1 = a + (1 - r) * (b - a) => x1 = " << a << " + (1 - " << r << ") * (" << b << " - " << a << ") = " << x1 << endl << endl;
			
			cout << " Step 7 f(x1) = ";
			f1 = function(x1);

			cout << " Step 8 k < k_Max - ";
		}
	} while (k < k_Max);// (abs((b - a)) >= tol);
	cout << " false\n\n";

	cout << "Output: ";
	cout << "x1 = " << x1 << endl;
	cout << "        f1 = " << f1 << endl;
	cout << "        k = " << k << endl;
	cout << "        abs(b - a) = " << abs(b - a) << "\n\n\n";

	system("pause");
	return 0;
}

double function(double x)
{
	cout << x << "^3 + " << x << "^2 - 8 * " << x << " - 8 = " << pow(x, 3) + pow(x, 2) - 8 * x - 8 << "\n\n";
	return ( pow(x, 3) + pow(x, 2) - 8 * (x) - 8);
}