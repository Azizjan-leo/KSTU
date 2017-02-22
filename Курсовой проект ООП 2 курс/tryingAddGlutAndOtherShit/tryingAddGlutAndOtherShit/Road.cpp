#include "Road.h"
#include <GL/glut.h>
Road::Road(int _position, int _wid) :position(_position), wid(_wid)
{
}
Road::~Road()
{
}
int Road::GetPosition()
{
	return position;
}
void Road::Move()
{
	position--;
}
void Road::Draw()
{
	glEnable(GL_LINE_SMOOTH);
	glBegin(GL_LINES);
	glVertex2f(-this->wid /2 + 3, this->position);
	glVertex2f(-this->wid /2 + 3, this->position + 10);
	glVertex2f(this->wid / 2 - 3, this->position);
	glVertex2f(this->wid / 2 - 3, this->position + 10);
	glEnd();
	glDisable(GL_LINE_SMOOTH);
}