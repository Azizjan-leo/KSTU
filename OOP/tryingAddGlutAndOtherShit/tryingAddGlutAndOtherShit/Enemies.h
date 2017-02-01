#pragma once
#include "Enemy.h"
#include "User.h"

class Enemies :	protected Enemy
{
private:
	int count;
	Enemy
		*first,
		*it, // iterator
		*last;
public:
	Enemies();
	Enemies(unsigned short); // with spesific number of enemies (max 3200)
	void Fill(unsigned short);
	short Timer(User*);
	void Draw(float);
	int GetScore();
	void AddScore(int);
	void Clean();
	~Enemies();
};

