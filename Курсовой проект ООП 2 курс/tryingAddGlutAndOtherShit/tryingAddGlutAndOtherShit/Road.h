#pragma once
class Road
{
private:
	int wid, position;
public:
	Road(int _position, int _wid);
	int GetPosition();
	void Move();
	void Draw();
	~Road();
};