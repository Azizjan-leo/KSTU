#pragma once
#include "Car.h"
#include <string>
class User :
	public Car
{
private: 
	int life;
public:
	User();
	User(int,int);
	short ChangeLife();
	short GetLife();
	float GetLocation(char*);
	void Move(float, float);
	void Draw();
	~User();
};

