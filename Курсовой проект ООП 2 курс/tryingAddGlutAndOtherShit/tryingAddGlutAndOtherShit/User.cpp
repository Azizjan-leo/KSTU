#include "User.h"
#include <iostream>
User::User()
{
}
User::User(int WinHei, int _life): Car(0, -WinHei / 2 + 28)
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
