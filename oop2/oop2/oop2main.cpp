#include<stdio.h>
#include<conio.h>
#include<iostream>
using namespace std;

class CIRCLE {
protected:
	float A;
private:
	float r;
	
public:
	float pi;
	void setR(float rr)
	{
		r=rr;
	}
	float getR()
	{
		return r;
	}
	float calculateArea()
	{
		A=3.14*r*r;
		return A;
	}
	float getArea();
	CIRCLE()
	{
		r=0;
		A=0;
	}
	CIRCLE(float rr, float AA)
	{
		r=rr;
		A=AA;
	}
};

float CIRCLE::getArea()
{
	return A;
}

class newCIRCLE:CIRCLE{
public:
	void setA(float aa)
	{
		A=aa;
	}
};



int main()
{
	float a;
	CIRCLE c1;
	CIRCLE c2(0.0,2.4);

	newCIRCLE cn1;
	cn1.setA(12.4);
	

	c1.pi=3.14;
	c1.setR (22.3);
	a=c1.calculateArea ();
	cout<<a<<endl;

	cout<<c2.getArea ();

	getch();
	return 0;
}