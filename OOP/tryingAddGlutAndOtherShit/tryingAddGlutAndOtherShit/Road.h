#pragma once
class Road
{
private:
	float wid, hei;
public:
	float position;
	Road(float _position, float _wid);
	void Draw();
	~Road();
};

