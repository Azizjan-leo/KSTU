#include "Car.h"
#include "GL\glut.h"
Car::Car()
{
	x = 0.0f;
	y = 0.0f;
}
Car::Car(int _x, int _y):x(_x), y(_y)
{
}

void Car::Move(float delta_x, float delta_y)
{
	x += delta_x;
	y += delta_y;
}

void Car::Draw()
{
	//Center
	glBegin(GL_POLYGON);
	glVertex2f(x - 5, y + 5); //left top corn
	glVertex2f(x + 5, y + 5); //right top corn
	glVertex2f(x + 5, y - 5); //right button corn
	glVertex2f(x - 5, y - 5); //left button corn
	glEnd();
	//Center Top
	glBegin(GL_POLYGON);
	glVertex2f(x - 5, y + 16); //left top corn
	glVertex2f(x + 5, y + 16); //right top corn
	glVertex2f(x + 5, y + 6); //right button corn
	glVertex2f(x - 5, y + 6); //left button corn
	glEnd();
	//Center Bottom
	glBegin(GL_POLYGON);
	glVertex2f(x - 5, y - 6); //left top corn
	glVertex2f(x + 5, y - 6); //right top corn
	glVertex2f(x + 5, y - 16); //right button corn
	glVertex2f(x - 5, y - 16); //left button corn
	glEnd();
	//Center Left
	glBegin(GL_POLYGON);
	glVertex2f(x - 16, y + 5); //left top corn
	glVertex2f(x - 6, y + 5); //right top corn
	glVertex2f(x - 6, y - 5); //right button corn
	glVertex2f(x - 16, y - 5); //left button corn
	glEnd();
	//Center Right
	glBegin(GL_POLYGON);
	glVertex2f(x + 6, y + 5); //left top corn
	glVertex2f(x + 16, y + 5); //right top corn
	glVertex2f(x + 16, y - 5); //right button corn
	glVertex2f(x + 6, y - 5); //left button corn
	glEnd();
	//Bottom Right
	glBegin(GL_POLYGON);
	glVertex2f(x + 6, y - 17); //left top corn
	glVertex2f(x + 16, y - 17); //right top corn
	glVertex2f(x + 16, y - 27); //right button corn
	glVertex2f(x + 6, y - 27); //left button corn
	glEnd();
	//Bottom Left
	glBegin(GL_POLYGON);
	glVertex2f(x - 16, y - 17); //left top corn
	glVertex2f(x - 6, y - 17); //right top corn
	glVertex2f(x - 6, y - 27); //right button corn
	glVertex2f(x - 16, y - 27); //left button corn
	glEnd();
}

float Car::GetLocation(char *type)
{
	return type == "x" ? x : y;
}

Car::~Car()
{
}
