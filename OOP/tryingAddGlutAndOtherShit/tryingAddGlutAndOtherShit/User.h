#pragma once
#include "Car.h"
#include <string>
class User :
	public Car
{
private: 
	int life;
	std::string color;
public:
	User();
	User(float,int);
	void SetLifeLimit();
	short ChangeLife();
	short GetLife();
	float GetLocation(char*);
	void Move(float, float);
	void Draw();
	~User();
};

