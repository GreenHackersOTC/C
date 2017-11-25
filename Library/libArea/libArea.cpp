#include"greenhacker.h"

void funArea(void)
{
	float a;
	float r;

	printf("please enter r ");
	scanf("%f",&r);
	a=funArea(r);
	printf("area = %f",a);
}

float funArea(float r)
{
	float a;
	a=3.14*r*r;
	return a;
}