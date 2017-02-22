#include "Enemies.h"
#include "Enemy.h"
#include "User.h"
#include <iostream>
#include <ctime>
#include <fstream>
#include <GL/glut.h>

using namespace std;

Enemies::Enemies() : first(NULL), it(NULL), last(NULL), count(0)
{
}
Enemies::Enemies(unsigned short _num) : first(NULL), it(NULL), last(NULL), count(0)
{
	srand(time(NULL));
	last = it = first = new Enemy(rand() % 3 + -1, 500);
	unsigned short num = 50 * _num - 50;
	for (unsigned short i = 0; i < num; i += 50)
	{
		Enemy* tmp = new Enemy(rand() % 3 + -1, last->GetLocation("y") + rand() % 300 + 40);
		last->next = tmp;
		last = tmp;
	}
}

int Enemies::GetScore()
{
	return count;
}
void Enemies::SetScore(int _newScore)
{
	count = _newScore;
}
void Enemies::Fill(unsigned short _num)
{
	srand(time(NULL));
	last = it = first = new Enemy(1, 500);
	unsigned short num = 50 * _num - 50;
	for (unsigned short i = 0; i < num; i += 50)
	{
		Enemy* tmp = new Enemy(rand() % 3 + -1, last->GetLocation("y") + rand() % 300 + 40);
		last->next = tmp;
		last = tmp;
	}
}
void Enemies::Draw(float _WinHei)
{
	if (first)
	{
		while (it)
		{
			it->Draw();
			it = it->next;
		}
		if (first->GetLocation("y") < -_WinHei / 2 - 20)
		{
			count++;
			Enemy* tmp = first->next;
			first->~Enemy();
			it = first = tmp;
			Enemy* newEnemy = new Enemy(rand() % 3 + -1, last->GetLocation("y") + 50 + rand() % 100);
			last->next = newEnemy;
			last = newEnemy;
		}
		it = first;
	}
}

short Enemies::Timer(User *user)
{
	if (first)
	{
		
		short cond = 0;
		while (it)
		{
			cond = it->Move(-1.5f, user);
			if (cond < 2)
			{
				it = first;
				return cond;
			}
			it = it->next;
		}
		it = first;
		return 2;
	}
}

void Enemies::Clean()
{
	while (it != NULL) {
		it = it->next;
		first->~Enemy();
		first = it;
	}
	last = NULL;
}
Enemies::~Enemies()
{
}
