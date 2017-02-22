#pragma once
class Car
{
protected:
	float x,
		  y;
public:
	Car();
	Car(int,int);
	void Move(float, float);
	float GetLocation(char*);
	void Draw();
	~Car();
};

