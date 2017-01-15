#include<iostream>
#include<cmath>
#include<iomanip>
using namespace std;

long double function(double);
long double diff_func(double);
long double double_diff_func(double);
long double ddiff_func(double);
long double ddouble_diff_func(double);

template <typename T> int sign(T val) {
	return (T(0) < val) - (val < T(0));
}

int main()
{
	long double H, r, x0 = -8, x1, dfx0, dfx1, ddfx0, ddfx1, RelError, Delta = 0.001, yfx0, yfx1, DP, DDP, Epsilon = 0.01, DPO, R = 4;
	int k, k_Max = 6, cond, step = 0, d = 0;
	/*
	//cout << "F(x0) = " << function(-8) << endl;
	//cout << "F'(x0) = " << diff_func(-8) << endl;
	//cout << "F_numdif(x0) = " << num_diff_func(-8) << endl;
	cout << "F''(x0) = " << double_diff_func(-8) << endl;
	cout << "F_num_double_diff_func = " << num_double_diff_func(-8) << endl;
	*/
	cout << "Input: x0 = " << x0 << "\n       Epsilon = " << Epsilon << "\n       Delta = " << Delta << "\n       R = " << R << "\n       k_Max = " << k_Max << endl;
	cout << "       f(x) =  x^3 + x^2 - 8 * x - 8\n" << endl;

	cout << "Step 1 cond = 0\n\n";
	cond = 0;

	cout << "Step 2 yfx0 = f(x0) = ";
	yfx0 = function(x0);

	cout << "Step 3 dfx0 = f'(x0) = ";
	dfx0 = diff_func(x0);

	cout << "Step 4 ddfx0 = f''(x0) = ";
	ddfx0 = double_diff_func(x0);

	k = 0;

	do
	{
		if (k > 0) cout << "true\n\n";

		cout << "Iteration " << k + 1 << "\n\n";

		cout << " Step " << ++step << " k = k + 1 => k = " << k << " + 1 = " << ++k << endl << endl;

		cout << " Step 2 abs(ddfx0) <= Epsilon => " << fixed << setprecision(7) << abs(ddfx0) << " <= " << fixed << setprecision(7) << Epsilon << " - ";
		if (abs(ddfx0) <= Epsilon)
		{
			cout << "true\n\n";

			cout << " Step 3 cond = 1\n\n";
			cond = 1;
		}
		else
		{
			cout << "false\n\n";
			DP = dfx0 / ddfx0;
			cout << " Step 3 DP = dfx0 / ddfx0 => DP = " << fixed << setprecision(7) << dfx0 << " / " << fixed << setprecision(7) << ddfx0 << " = " << DP << "\n\n";
		}
		cout << " Step 4 k == 1 => " << k << " = 1 - ";
		if (k == 1)
		{
			cout << "true\n\n";
			d = 1;

			cout << " Step 5 DPO = DP => DPO = " << fixed << setprecision(7) << DP << endl << endl;
			DPO = DP;
		}
		else
		{
			cout << "false\n\n";
		}
		cout << " Step " << 4 + d << " sign(DPO) == sign(DP) => sign(" << fixed << setprecision(7) << DPO << ") == sign(" << fixed << setprecision(7) << DP << ") - ";
		
		if (sign(DPO) == sign(DP))
		{
			cout << "true\n\n";

			x1 = x0 - DP;
			cout << " Step " << 5 + d << " x1 = x0 - DP => " << "x1 = " << x0 << " - " << fixed << setprecision(7) << DP << " = " << x1 << endl << endl;
		}
		else
		{
			cout << "false\n\n";

			x1 = x0 - DP / R;
			cout << " Step " << 6 + d << " x1 = x0 - DP / R => " << "x1 = " << x0 << " - " << fixed << setprecision(7) << DP << " / " << R << " = " << x1;
		}

		cout << " Step " << 7 + d << " DPO = DP => DPO = " << fixed << setprecision(7) << DP << endl << endl;
		DPO = DP;

		cout << " Step " << 8 + d << " yf1 = f(x1) = ";
		yfx1 = function(x1);

		cout << " Step " << 9 + d << " dfx1 = f'(x1) = ";
		dfx1 = diff_func(x1);

		cout << " Step " << 10 + d << " ddfx1 = f''(x1) = ";
		ddfx1 = double_diff_func(x1);

		RelError = 2 * abs(DP) / (abs(x1) + Epsilon);
		cout << " Step " << 11 + d << " RelError = 2 * abs(DP) / (abs(x1) + Epsilon) => RelError = 2 * abs(" << DP << ") / (abs(" << x1 << ") + " << Epsilon << ") = " << RelError << endl << endl;

		cout << " Step " << 12 + d << " RelError < Delta => " << RelError << " < " << Delta << " - ";
		if (RelError < Delta)
		{
			cout << "true\n\n";
			d++;

			cout << " Step " << 12 + d << " cond <> 1 => " << cond << " <> 1 - ";
			if (cond != 1)
			{
				cout << "true\n\n";
				d++;

				cout << " Step " << 12 + d << " cond = 2\n\n";
				cond = 2;
			}
			else
			{
				cout << "false\n\n";
			}
		}
		else
		{
			cout << "false\n\n";
		}
		
		cout << " Step " << 13 + d << " x0 = x1 => x0 = " << x1 << "; dfx0 = dfx1 => dfx0 = " << fixed << setprecision(7) << dfx1 << "; ddfx0 = ddfx1 => ddfx0 = " << fixed << setprecision(7) << ddfx1 << ";\n\n";
		x0 = x1; dfx0 = dfx1; ddfx0 = ddfx1;

		cout << " Step " << 14 + d << " k < k_Max & cond == 0 => " << k << " < " << k_Max << " & " << cond << " == 0 - ";
		
	} while (k < k_Max & cond == 0);

	cout << "false\n\n";

	cout << "Output: ";
	cout << "x1 = " << x1 << endl;
	cout << "        yf1 = " << yfx1 << endl;
	cout << "        k = " << k << endl;
	cout << "        RelError = " << fixed << setprecision(7) << RelError << "\n";
	cout << "        cond = " << cond << "\n\n\n";
	
	system("pause");
	return 0;
}
long double diff_func(double x)
{
	return(function(x + 0.001 / 2) - function(x - 0.001 / 2)) / 0.001;
}
long double double_diff_func(double x)
{
	return(diff_func(x + 0.001 / 2) - diff_func(x - 0.001 / 2)) / 0.001;
}

long double ddouble_diff_func(double x)
{
	cout << "6 * " << x << " + 2 = " << 6 * x + 2 << "\n\n";
	return (6 * x + 2);
}
long double ddiff_func(double x)
{
	cout << "3 * " << x << "^2 + 2 * " << x << " - 8 = " <<  3 * pow(x, 2) + 2 * x - 8 << "\n\n";
	return (3 * pow(x, 2) + 2 * x - 8);
}
long double function( double x)
{
	cout << x << "^3 + " << x << "^2 - 8 * " << x << " - 8 = " << pow(x, 3) + pow(x, 2) - 8 * x - 8 << "\n\n";
	return (pow(x, 3) + pow(x, 2) - 8 * (x)-8);
}