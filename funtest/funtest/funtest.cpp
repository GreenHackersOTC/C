#include<stdio.h>
#include<conio.h>
void funHello(int n);// fun declaration, fun prototype
float funY(float x);
float funAreaOfRectangle(float b, float h);
struct strRectangle funAreaOfRectangle(struct strRectangle d);
struct strRectangle{
	float l;
	float w;
	float A;
};

//y=f(x)=2x
void main(void)
{
	struct strRectangle green;
	green.l=12.5;
	green.w=78.9;
	green.A=0.0;
	float k;
	float g;
	strRectangle  blue;
	//funHello(2);
	//funHello(6);
	k=funY(23.4);
	g=funAreaOfRectangle(22.4,55.6);
	blue=funAreaOfRectangle(green);
	
}


void funHello(int n) //fun definition
{
	int i=0;
	for(i=0;i<n;i++)
	{
	printf("hello world\n");
	}
	getch();
}

float funY(float x)
{
	float y;
	y=2*x;
	return y;
}

float funAreaOfRectangle(float b, float h)
{
	float Area;
	Area = b*h;
	return Area;
}

strRectangle funAreaOfRectangle(struct strRectangle d)
{
	strRectangle Area;
	Area.A = d.l*d.w;
	Area.l=d.l;
	Area.w=d.w;
	return Area;
}
