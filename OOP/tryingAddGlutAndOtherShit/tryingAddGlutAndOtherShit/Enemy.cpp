#include "Enemy.h"
#include "Enemies.h"
#include <cstdlib>
#include <iostream>

using namespace std;

Enemy::Enemy():Car(0,400)
{
}


Enemy::Enemy(short _x, float _y): Car(_x*-40.0, _y)
{	
}

short Enemy::Move(float delta_y, User *User)
{
	if (((y + delta_y) >= 0 && User->GetLocation("y") <= 0) || ((y + delta_y) <= 0 && User->GetLocation("y") >= 0)) // on different sides of x axis
	{ 
		if (abs(y + delta_y) + abs(User->GetLocation("y")) > 32)
		{
			y += delta_y; return 2;
		}
		else
		{ 
			if ((x > 0 && User->GetLocation("x") < 0) || (x < 0 && User->GetLocation("x") > 0)) //on different sides of the origin
			{
				y += delta_y; return 2;
			}
			else {
				if (abs(abs(x) - abs(User->GetLocation("x"))) > 30)
				{
					y += delta_y; return 2;
				}
				else
				{
					return User->ChangeLife();
				}
			}
		}
	}
	else {
		if (abs(abs(y + delta_y) - abs(User->GetLocation("y"))) > 32) // on same side of x axis
		{
			y += delta_y;
			return 2;
		}
		else
		{
			if (abs(abs(x) - abs(User->GetLocation("x"))) > 32)
			{
				y += delta_y;
				return 2;
			}
			else
			{
				if ((x > 0 && User->GetLocation("x") < 0) || (x < 0 && User->GetLocation("x") > 0)) //on different sides of the origin
				{
					y += delta_y; return 2;
				}
				else
				{
					return User->ChangeLife();
				}
			}
		}
	}
}

void Enemy::Draw()
{
	Car::Draw();
}

Enemy::~Enemy()
{
}
