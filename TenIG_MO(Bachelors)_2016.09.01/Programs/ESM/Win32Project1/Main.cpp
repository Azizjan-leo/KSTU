#include <iostream>
#include <cmath>

using namespace std;

double Func(double);

int main()
{
	double x1, x0, Tolerance, H, fx0, fx1, yfx0, yfx1;

	int k, k_max = 100;
	cout << "k_max = " << k_max << endl;

	Tolerance = H = 0.01;
	cout << "Tolerance = H = 0.01" << endl;
	
	x0 = -2.05;
	cout << "x0 = " << x0 << endl;

	cout << "\nFirst  approximation: " << endl << "f(x0) = ";
	yfx0 = fx0 = Func(x0);
	
	

	x1 = x0 + H;
	cout << "x1 = x0 + H => " << x0 << " + " << "H = " << x1 << endl;

	cout << "\nyf(x1) = f(x1) = ";
	yfx1 = fx1 = Func(x1);

	cout << "k = 0\n\n";
	k = 0;
	do
	{
		if (k > 0)cout << " true\n\n";
		cout << "Iteration " << ++k << endl;
		cout << "\n Step1 k = k + 1 = " << k << endl;
		cout << "\n Step2 yf(x1)[" << yfx1 << "] <= yf(x0)[" << yfx0 << "] - ";
		if (yfx1 <= yfx0)
		{
			cout << "true" << endl;

			x1 = x0;
			cout << "\n Step3 x1 = x0 => x1 = " << x0 << endl << endl;
			yfx1 = yfx0;
			cout << " Step4 k < k_max - false";
			system("pause");
		}
		else
		{
			cout << "false" << endl;
			cout << "\n Step3 x0 = x1 => " << x1 << "   & ";
			x0 = x1;
			cout << "  yf(x0) = yf(x1) = " << yfx1 << endl;
			yfx0 = yfx1;
			cout << "\n Step4 x1 = x1 + H => " << x1 << " + " << H << " = " << x1 + H << endl;
			x1 = x1 + H;
			cout << "\n Step5 f(x1) = ";
			yfx1 = fx1 = Func(x1);
			cout << " Step6 k < k_max - ";
		}
	} while (k < k_max);

	cout << endl << "\nOUTPUT: " << endl;
	cout << "\tx1 = " << x1 << endl;
	cout << "\tyf(x1) = " << yfx1 << endl;
	cout << "\tk = " << k << endl;
	cout << "\tabs(H) = " << abs(H) << endl << endl;

	system("pause");
}

double Func(double x)
{
	cout << x << "^3 + " << x << "^2 - 8 * " << x << " - 8 = " << pow(x, 3) + pow(x, 2) - 8 * x - 8 << endl << endl;
	return pow(x, 3) + pow(x, 2) - 8 * x - 8;
}