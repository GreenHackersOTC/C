#include<stdio.h>
#include<conio.h>
#include<iostream>
#include<stdlib.h>
#include<time.h>
using namespace std;
void delay(unsigned int mseconds);
int main()
{
	int status=0; //1-won 2-lost
	char ch;
	FILE *fo;
	int u1e=100;
	int u1t=0;
	int u1x=0;
	int u1y=0;

	int d1x=3;
	int d1y=5;
	int d1e=10;

	int d2x=4;
	int d2y=3;
	int d2e=20;

	int t1x=2;
	int t1y=9;
	int t1g=12;

	int homex=9;
	int homey=4;




	do{
			ch=getch();
			switch(ch)
			{
			case 75:   u1x=(u1x==0)?20:u1x-1; break; //left
			case 77:    if(u1x==20){ u1x=0;} else {u1x++;} break; //right
			case 72:   u1y=(u1y==0)?20:u1y-1; break; //up
			case 80:   u1y=(u1y==20)?0:u1y+1; break; //down
			}
			if((ch==75)||(ch==77)||(ch==72)||(ch==80))
			{
			cout<<"u1x= "<<u1x<<","<<"u1y= "<<u1y<<endl;
			delay(1000);
			printf("u1x=%d,u1y=%d\n",u1x,u1y);
			fo = fopen("e:\\user1.txt","a");
			fprintf(fo,"%d-%d\n",u1x,u1y);
			fclose(fo);
			}
	}while((status!=1)&&(status!=2));
	return 0;
}


void delay(unsigned int mseconds)
{
    clock_t goal = mseconds + clock();
    while (goal > clock());
}