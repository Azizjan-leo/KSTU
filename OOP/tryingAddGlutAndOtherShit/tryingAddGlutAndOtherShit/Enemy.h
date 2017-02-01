#pragma once
#include "Car.h"
#include "User.h"
class Enemy :
	public Car
{
public:
	Enemy();
	Enemy(short, float);
	void Draw();
	short Move(float, User*);
	~Enemy();
	Enemy* next;
	short side;
};

