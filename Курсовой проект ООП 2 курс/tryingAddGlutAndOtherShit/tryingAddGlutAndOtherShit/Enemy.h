#pragma once
#include "Car.h"
#include "User.h"
class Enemy :
	public Car
{
public:
	Enemy* next;

	Enemy();
	Enemy(short, float);
	void Draw();
	short Move(float, User*);
	~Enemy();
};

