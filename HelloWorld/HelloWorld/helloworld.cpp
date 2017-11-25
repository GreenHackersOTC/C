#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
int genRandom(int n);


int main()
{
	int k;
	time_t t;
	srand((unsigned)time(&t));	
	for(k=0;k<100;k++)
	{
		printf("%d\n",genRandom(21));
	}
	
	getch();
}

int genRandom(int n)
{
	int i=0;	
	i=rand();
	i=(i%n)+1;
	return i;
}

