#include<GL\glut.h>
#include<ctime>
#include<vector>
#include<iostream>

#include"Road.h";
#include"Enemies.h"
#include"User.h";

using namespace std;

vector <Road> road;

float WinWid = 120.0f, WinHei = 350.0f, sensitivity = 5.1f, speed = 10.0f;
User* user = new User(WinHei,2);
Enemies enemies(30);

void Keyboard(unsigned char key, int x, int y);
void SKeyboard(int key, int x, int y);
void Initialize();
void Draw();
void Timer(int);
void DrawGameOver();

int main(int argc, char** argv)
{
	srand(time(NULL));
	
	for (int i = WinHei/2; i >= -WinHei/2; i -= 20)
	{
		Road curb(i, WinWid);
		road.push_back(curb);
	}
	
	//Initialization
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutInitWindowSize(WinWid, WinHei);
	glutInitWindowPosition(450, 130);
	glutCreateWindow("Race");

	//Registration
	glutDisplayFunc(Draw);//Drawing
	glutTimerFunc(speed, Timer, 1); // animation func registration
	
	glutKeyboardFunc(Keyboard);
	glutSpecialFunc(SKeyboard);

	Initialize();
	glutMainLoop();
		
	system("pause");
	return 0;
}

void DrawGameOver()
{
	glClear(GL_COLOR_BUFFER_BIT);
	
	glRasterPos2f(-54.0f, 40.0f);
	for (char *c = "Game over"; *c != '\0'; c++) {
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
	}
	glRasterPos2f(-54.0f, 0.0f);
	for (char *c = "Your score"; *c != '\0'; c++) {
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
	}
	glRasterPos2f(-7.0f, -30.0f);
	for (char *c = "is"; *c != '\0'; c++) {
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
	}
	std::string s = std::to_string(enemies.GetScore());
	char const *pchar = s.c_str();  //use char const* as target type
	float num = s.length() * 7 / 2;
	glRasterPos2f(-num, -60.0f);
	while (*pchar != '\0')
	{
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *pchar);
		pchar++;
	}
	
	glutSwapBuffers();
}

void Timer(int value)
{
	cout << enemies.GetScore() << endl;
	for (vector<Road>::iterator i = road.begin(); i != road.end(); i++)
	{
		i->position--;
	}
	short cond;
	switch (enemies.Timer(user))
	{
	case 1:
		enemies.Clean();
		enemies.Fill(20);
		cond = user->GetLife();
		user->~User();
		user = new User(WinHei, cond);
		glutPostRedisplay();
		glutTimerFunc(speed = 10, Timer, 10);
		break;
	case 2:
		glutPostRedisplay();
		glutTimerFunc(speed -= 0.001, Timer, value);
		break;
	case 0:
		DrawGameOver();
		break;
	}
}


void Draw()
{
	glClear(GL_COLOR_BUFFER_BIT);
	vector <Road>::iterator i = road.begin();
	while (i != road.end())
	{
		i->Draw();
		if (i->position <= -WinHei / 2 - 5) {
			Road r(WinHei / 2 + 5, WinWid);
			road.push_back(r);
			i = road.erase(i);
		}
		else
			++i;
	}

	enemies.Draw(WinHei);

	user->Draw();

	glutSwapBuffers(); // for GLUT_DOUBLE 
}

void SKeyboard(int key, int x, int y)
{
	switch (key)
	{
	case GLUT_KEY_LEFT:
		if (user->GetLocation("x") >= -WinWid / 2 + 19.5 + sensitivity)
			user->Move(-sensitivity, 0);
		break;
	case GLUT_KEY_RIGHT:
		if (user->GetLocation("x") <= WinWid / 2 - 19.5 - sensitivity)
			user->Move(sensitivity, 0);
		break;
	case GLUT_KEY_UP:
		if (user->GetLocation("y") <= WinHei / 2 - 17 - sensitivity)
			user->Move(0, sensitivity);
		break;
	case GLUT_KEY_DOWN:
		if (user->GetLocation("y") >= -WinHei / 2 + 30)
			user->Move(0, -sensitivity);
		break;
	}
}

void Keyboard(unsigned char key, int x, int y)
{

	switch (key)
	{
	case 'a':
		if (user->GetLocation("x") >= -WinWid / 2 + 19.5 + sensitivity)
			user->Move(-sensitivity, 0);
		break;
	case 'd':
		if (user->GetLocation("x") <= WinWid / 2 - 19.5 - sensitivity)
			user->Move(sensitivity, 0);
		break;
	case 'w':
		if (user->GetLocation("y") <= WinHei / 2 - 17 - sensitivity)
			user->Move(0, sensitivity);
		break;
	case 's':
		if (user->GetLocation("y") >= -WinHei / 2 + 30)
			user->Move(0, -sensitivity + 1);
		break;
	}
}

void Initialize()
{
	glClearColor(0.0, 0.0, 0.0, 1.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(-WinWid / 2, WinWid / 2, -WinHei / 2, WinHei / 2, -200.0, 200);
	glMatrixMode(GL_MODELVIEW);
}