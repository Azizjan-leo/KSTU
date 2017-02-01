#include "User.h"
#include <iostream>
User::User()
{
}
User::User(float WinHei, int _life): Car(0.0f, -WinHei / 2 + 28)
{
	life = _life;
}
float User::GetLocation(char* _type)
{
	return Car::GetLocation(_type);
}
void User::Move(float _x, float _y)
{
	Car::Move(_x, _y);
}
void User::Draw()
{
	Car::Draw();
}
void User::SetLifeLimit()
{
	std::cout << "Enter life limit: ";
	int l = 0;
	while (true)
	{
		std::cin >> l;

		if (l < 11 && l > 0)
		{
			this->life = l;
			break;
		}
		else
			std::cout << "Invalid value\n";
	}
}
short User::ChangeLife()
{
	if (!--life)
		return 0;
	else return 1;
}
short User::GetLife()
{
	return life;
}
User::~User()
{
}
