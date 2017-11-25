#include<stdio.h>
#include<conio.h>
void main(void)
{
	int i, j;
	float k, l;
	char c, d;
	int sum = 0;
	float result = 0.0;
	char ans;

	i = 1;
	j = 2;
	k = 3.4;
	l = 5.6;
	c = 'A';
	d = '3';

	sum = i + j;
	printf("i + j = %d\n", sum);

	sum = j - i;
	printf("i - j = %d\n", sum);

	result = k*l;
	printf("k*l = %f\n", result);
	printf("k*l = %f\n", k*l);
	printf("k/l = %f\n", k/l);

	printf("10mod4 = %d\n", 10 % 4);

	printf("i=%d\n", --i);
	printf("i=%d\n", i);

	i = 0;
	j = 5;
	if (!i)
	{
	
	}

	_getch();
}

