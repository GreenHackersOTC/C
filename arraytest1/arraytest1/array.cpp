#include<stdio.h>
#include<conio.h>
#define pi 3.1415
#define NEWLINE printf("\n")


int main()
{
	int i=0;
	int k[3]={4,5,6};
	int g[10]={2,1,4,2,1,5,6,7,7,8};
	int *ifirst, *second,*third;
	
	
	printf("%x",&i);
	NEWLINE;
	printf("%x",k);
	NEWLINE;
	printf("%x - %x - %x",&k[0],&k[1],&k[2]);
	NEWLINE;
	ifirst=k;

	second = ifirst + 1;
	printf("%x",second);
	NEWLINE;
	third=  ifirst + 2;
	printf("%x",third);
	NEWLINE;
	printf("%d",*(ifirst+0));
	NEWLINE;
	printf("%d",*(ifirst+1));
	NEWLINE;
	printf("%d",*(ifirst+2));
	NEWLINE;
	for(int d=0;d<10;d++)
	{
		printf("%d",*(g+d));
	}
	NEWLINE;
	for(int d=0;d<10;d++)
	{
		printf("%d",(g[d]));
	}
	getch();

	return 0;
}