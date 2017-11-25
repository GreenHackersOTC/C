#include<stdio.h>
#include<conio.h>
#include<time.h>
#include<stdlib.h>
void delay(unsigned int mseconds);
int main()
{
	int i=0;
	int j=0;
	for(i=0;i<80;i++)
	{
		system("cls");
		for(j=0;j<i;j++)
		{
			printf(" ");
		}
		printf("A");
		delay(100);
		if(i==79) i=0;
	}
	getch();
	return 0;
}
void delay(unsigned int mseconds)
{
    clock_t goal = mseconds + clock();
    while (goal > clock())
	{
	}
}