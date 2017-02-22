#include<GL\glut.h>
#include<ctime>
#include<vector>
#include<iostream>
#include <fstream>
#include"Road.h"
#include"Enemies.h"
#include"User.h"
#include <algorithm>

using namespace std;
vector <Road> road;
float sensitivity = 5.1f, speed, complexity = 0;
int WinWid = 120, WinHei = 350, WinScroll = 0;
User* user;
Enemies enemies(30);
bool game = true, list = false;
string name;
bool isChamp = true; // if in the champions file is no same scores user well put his name in the list

struct  Champions
{
	string name;
	int score;
	Champions(int k, const std::string& s) : score(k), name(s) {}
};
struct less_than_key // to sort vector.
{
	inline bool operator() (const Champions struct1, const Champions struct2)
	{
		return (struct1.score > struct2.score);
	}
};

vector <Champions> Champs;

void Keyboard(unsigned char key, int x, int y);
void SKeyboard(int key, int x, int y);
void Initialize();
void Draw();
void Timer(int);
void Timer2(int);

void MousePressed(int, int, int, int);

void ComplexityTimer(int);
void ComplexityDraw();
void ComplexityMouse(int, int, int, int);
void ComplexityKeyboard(unsigned char key, int x, int y);

void GameOverDraw();
void GameOverTyping(unsigned char key, int x, int y);
void GameOverTimer(int);

int main(int argc, char** argv)
{
	srand(time(NULL));
	for (int i = WinHei / 2; i >= -WinHei / 2; i -= 20)
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
	
	glutDisplayFunc(ComplexityDraw);
	glutTimerFunc(10, ComplexityTimer, 10);

	Initialize();
	glutMainLoop();
	system("pause");
	return 0;
}

void ComplexityTimer(int value)
{
	if (complexity)
	{
		enemies.Clean();
		enemies.Fill(20);
		if (complexity == 1)
			user = new User(WinHei, 5);
		else if (complexity > 1 && complexity < 2)
			user = new User(WinHei, 3);
		else
			user = new User(WinHei, 1);
		glutKeyboardFunc(Keyboard);
		glutSpecialFunc(SKeyboard);
		glutDisplayFunc(Draw);//Drawing
		glutPostRedisplay();
		glutTimerFunc(speed = 20 / complexity, Timer, 1);
	}
	else
	{
		glutKeyboardFunc(ComplexityKeyboard);
		glutDisplayFunc(ComplexityDraw);
		glutPostRedisplay();
		glutTimerFunc(10, ComplexityTimer, 10);
	}
}
void ComplexityDraw()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glRasterPos2f(-30.0f, 35.0f);
	for (char *c = "EASY"; *c != '\0'; c++) {
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
	}
	glRasterPos2f(-51.0f, 5.0f);
	for (char *c = "NORMAL"; *c != '\0'; c++) {
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
	}
	glRasterPos2f(-31.0f, -25.0f);
	for (char *c = "HARD"; *c != '\0'; c++) {
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
	}
	glutMouseFunc(ComplexityMouse);
	glutSwapBuffers();
}
void ComplexityMouse(int button, int state, int x, int y)
{
	y = -(y - (WinHei / 2));
	x = x - (WinWid / 2);

	if (x > -30 && x < 30 && y > 36 && y < 52 && state == GLUT_DOWN)
	{
		complexity = 1;
	}
	if (x > -51 && x < 53 && y > 5 && y < 22 && state == GLUT_DOWN)
	{
		complexity = 1.9;
	}
	if (x > -31 && x < 33 && y > -25 && y < -8 && state == GLUT_DOWN)
	{
		complexity = 2.6;
	}
}
void ComplexityKeyboard(unsigned char key, int x, int y)
{
	switch ((char)key)
	{
	case 'e': complexity = 1; break;
	case 'E': complexity = 1; break;
	case 'n': complexity = 1.9; break;
	case 'N': complexity = 1.9; break;
	case 'h': complexity = 2.6; break;
	case 'H': complexity = 2.6; break;
	}
}
void MousePressed(int button, int state, int x, int y)
{
	if ((button == 3) || (button == 4)) // It's a wheel event
	{
		// Each wheel event reports like a button click, GLUT_DOWN then GLUT_UP
		if (state == GLUT_UP) return; // Disregard redundant GLUT_UP events
		WinScroll += (button == 3) ? (WinScroll > 0) ? -1 : 0 : 1;
	}

	y = -(y - (WinHei / 2));
	x = x - (WinWid / 2);
	
	if (!isChamp && x > -55 && x < 56 && y > -25 && y < -13 && state == GLUT_DOWN)
	{
		game = true;
		complexity = 0;
		enemies.SetScore(0);
		isChamp = true;
		WinScroll = 0;
	}
}
void Timer(int value)
{
	for (vector<Road>::iterator i = road.begin(); i != road.end(); i++)
		i->Move();

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
		glutTimerFunc(speed = 20/complexity, Timer, speed);
		break;
	case 2:
		glutPostRedisplay();
		glutTimerFunc(speed -= speed * 0.001 / 100, Timer, speed);
		break;
	case 0:
		user->~User();
		game = false;
				
		ifstream scores;
		scores.open("Top.txt");
		int num;
		

		int sc = round(complexity) * enemies.GetScore();

		while (scores >> num)
		{
			if (num == sc)
				isChamp = false;
		}
		//complexity = 0;
		scores.close();
		glutDisplayFunc(GameOverDraw);
		glutKeyboardFunc(GameOverTyping);
		glutPostRedisplay();
		glutTimerFunc(10, GameOverTimer, 1);

		break;
	}
}

void GameOverDraw()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glRasterPos2f(-54.0f, 100.0f);
	for (char *c = "Game over"; *c != '\0'; c++) {
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
	}
	glRasterPos2f(-54.0f, 65.0f);
	for (char *c = "Your score"; *c != '\0'; c++) {
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
	}
	glRasterPos2f(-6.0f, 30.0f);
	for (char *c = "is"; *c != '\0'; c++) {
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
	}

	int sc = round(complexity) * enemies.GetScore();
	std::string s = std::to_string(sc);
	char const *pchar = s.c_str();
	float num = s.length() * 7.5 / 2;
	glRasterPos2f(-num, 0.0f);
	while (*pchar != '\0')
	{
		glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *pchar);
		pchar++;
	}

	if (name.length() && isChamp) {
		glRasterPos2f(-50, -25);
		char const *pcharr = name.c_str();
		while (*pcharr != '\0')
		{
			glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *pcharr);
			pcharr++;
		}

		
	}
	else
	{
		if (isChamp) {
			glRasterPos2f(-52, -25);
			for (char *c = "Type ur name"; *c != '\0'; c++) {
				glutBitmapCharacter(GLUT_BITMAP_9_BY_15, *c);
			}
		}
		else
		{
			glRasterPos2f(-55, -25);
			for (char *c = "New Game"; *c != '\0'; c++) {
				glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *c);
			}

			glutMouseFunc(MousePressed);
		}

	}
	ifstream names, scores;
	names.open("Top2.txt", ios::in);
	scores.open("Top.txt", ios::in);
	int i = -55, scr;
	while (scores >> scr) {
		string ss;
		getline(names, ss);
		std::string sss = std::to_string(scr);
		float n = sss.length() * 14 / 2;
		if (i + WinScroll < -45) {
			glRasterPos2f(-n, i + WinScroll);
			
			char const *ppchar = sss.c_str();
			while (*ppchar != '\0') {
				glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *ppchar);
				ppchar++;
			}
		}
		i -= 20;
		if (i + WinScroll < -45) {
			float numm = ss.length() * 13 / 2;
			glRasterPos2f(-numm, i + WinScroll);
			char const *har = ss.c_str();
			while (*har != '\0') {
				glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *har);
				har++;
			}
		}
		i -= 18;
		if (i + WinScroll < -45) {
			glRasterPos2f(-WinWid / 2 + 5, i + WinScroll);
			for (const char *ar = "---------------"; *ar != '\0'; *ar++) {
				glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, *ar);
				ar++;
			}
		}
		i -= 25;
	}
	names.close(); scores.close();
	glutSwapBuffers();
}
void GameOverTimer(int value)
{
	if (game && !complexity)
	{
		glutDisplayFunc(ComplexityDraw);
		glutPostRedisplay();
		glutMouseFunc(ComplexityMouse);
		glutTimerFunc(10, ComplexityTimer, 1);
	}
	else
	{
		glutDisplayFunc(GameOverDraw);
		if (isChamp)
			glutKeyboardFunc(GameOverTyping);
		glutPostRedisplay();
		glutTimerFunc(10, GameOverTimer, 1);
	}
}
void GameOverTyping(unsigned char key, int x, int y)
{
	if (key == 13) // Enter key
	{
		fstream names, scores;
		names.open("Top2.txt", ios::in | ios::out);
		scores.open("Top.txt", ios::in | ios::out);
		int num;
		while (scores >> num)
		{
			string n; getline(names, n);
			Champs.push_back(Champions(num, n));
		}
		Champs.push_back(Champions(enemies.GetScore() * round(complexity), name)); // to add current user
		name = ""; // to empty the name field so it will not appear in new game
		names.close(); scores.close();

		std::ofstream ofs, ofs2; // to empty file
		ofs.open("Top.txt", std::ofstream::out | std::ofstream::trunc); ofs2.open("Top2.txt", std::ofstream::out | std::ofstream::trunc);
		ofs.close(); ofs2.close();
		
		names.open("Top2.txt", ios::in | ios::out);
		scores.open("Top.txt", ios::in | ios::out);

		std::sort(Champs.begin(), Champs.end(), less_than_key());

		for (vector<Champions>::iterator i = Champs.begin(); i != Champs.end(); i++)
		{
			names << i->name << "\n";
			scores << i->score << "\n";
		}
		Champs.clear();
		names.close(); scores.close();
		glutKeyboardFunc(Keyboard);
		isChamp = false;
	}
	else if (key == 8)	// backspace
	{
		if (name.length())
			name.erase(name.length() - 1, 1);
	}
	else 	// regular text
	{
		if (name.length() < 9) {
			string l;
			l = (char)key;
			name.append(l);
		}
	}
}

void Timer2(int value)
{
	if (game)
	{
		glutKeyboardFunc(ComplexityKeyboard);
		glutDisplayFunc(ComplexityDraw);
		glutPostRedisplay();
		glutTimerFunc(1, ComplexityTimer, 1);
	}
	else
	{
		ifstream scores;
		scores.open("Top.txt");

		int num; float flag = true; // if we need to insert the user to the champions list

		while (scores >> num)
		{
			if (num == enemies.GetScore())
				flag = false;	//exit if there is the same result
		}

		scores.close();

		if (flag)
		{
			glutKeyboardFunc(GameOverTyping);
			glutDisplayFunc(GameOverDraw);
			glutPostRedisplay();
			glutTimerFunc(10, GameOverTimer, 1);
		}
	}
}

void Draw()
{
	glClear(GL_COLOR_BUFFER_BIT);
	vector <Road>::iterator i = road.begin();
	while (i != road.end())
	{
		i->Draw();
		if (i->GetPosition() <= -WinHei / 2 - 5) {
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