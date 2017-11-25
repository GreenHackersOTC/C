//Programmer: Dr. Aung Win Htut
//Start:				2017101201
//SnakeGame.cpp
//Single Player Only Snake and Ladder Game

//Header Files 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>

//sh - snake head , st - snake tail   
#define sh1 99 
#define st1 78
#define sh2 95 
#define st2 75
#define sh3 93
#define st3 73
#define sh4 87
#define st4 24
#define sh5 62 
#define st5 19
#define sh6 64 
#define st6 60
#define sh7 54 
#define st7 34
#define sh8 17 
#define st8 7

//lb - ladder bottom , lt - ladder top
#define lb1 4 
#define lt1 14
#define lb2 9 
#define lt2 31
#define lb3 20 
#define lt3 38
#define lb4 28 
#define lt4 84
#define lb5 40 
#define lt5 59
#define lb6 51 
#define lt6 67
#define lb7 63 
#define lt7 81
#define lb8 71 
#define lt8 91

//function prototype declarations
int genRandom(int n);


//main function starts here
int main()
{
	int u1=1;
	int u2=1;
	int u3=1;
	int dice=0;
	int count=0;
	time_t t;
	srand((unsigned)time(&t));	
	
	while(u1!=100)
	{
		printf("Please press ANY key to dice \n");
		getch();
		dice=genRandom(6);
		count++;
		u1=u1+dice; //u1+=dice;
		printf("\n"); 		
		printf("dice! = %d",dice);
		printf("\n");
		printf("Now user moves to %d",u1);
		printf("\n");
		if(u1>100) {u1=200-u1; printf("Over 100!!! So,Now user moves to %d",u1);}
		printf("\n");
		if(u1==sh1){ u1=st1; printf("Ohhhh.... Snake1 !!!! you moved to its tail %d",u1); }
		if(u1==sh2){ u1=st2;printf("Ohhhh.... Snake2 !!!! you moved to its tail %d",u1); }
		if(u1==sh3){ u1=st3;printf("Ohhhh.... Snake3 !!!! you moved to its tail %d",u1); }
		if(u1==sh4){ u1=st4;printf("Ohhhh.... Snake4 !!!! you moved to its tail %d",u1); }
		if(u1==sh5){ u1=st5;printf("Ohhhh.... Snake5 !!!! you moved to its tail %d",u1); }
		if(u1==sh6){ u1=st6;printf("Ohhhh.... Snake6 !!!! you moved to its tail %d",u1); }
		if(u1==sh7){ u1=st7;printf("Ohhhh.... Snake7 !!!! you moved to its tail %d",u1); }
		if(u1==sh8){ u1=st8;printf("Ohhhh.... Snake8 !!!! you moved to its tail %d",u1); }
		printf("\n");
		switch(u1)
		{
			case lb1: u1=lt1;printf("Yayyyy.... Ladder1 !!!! you moved to its TOP %d",u1);break;
			case lb2: u1=lt2;printf("Yayyyy.... Ladder2 !!!! you moved to its TOP %d",u1);break;
			case lb3: u1=lt3;printf("Yayyyy.... Ladder3 !!!! you moved to its TOP %d",u1);break;
			case lb4: u1=lt4;printf("Yayyyy.... Ladder4 !!!! you moved to its TOP %d",u1);break;
			case lb5: u1=lt5;printf("Yayyyy.... Ladder5 !!!! you moved to its TOP %d",u1);break;
			case lb6: u1=lt6;printf("Yayyyy.... Ladder6 !!!! you moved to its TOP %d",u1);break;
			case lb7: u1=lt7;printf("Yayyyy.... Ladder7 !!!! you moved to its TOP %d",u1);break;
			case lb8: u1=lt8;printf("Yayyyy.... Ladder8 !!!! you moved to its TOP %d",u1);break;
		}
			printf("\n");
	}
	printf("game over! total dice %d times",count);
	
	getch();
}
// main function ends here

//random number generator for 1 to n
int genRandom(int n)
{
	int i=0;	
	i=rand();
	i=(i%n)+1;
	return i;
}
//fun genRandom ends here

