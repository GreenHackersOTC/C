#include<stdio.h> //printf() scanf_s()
#include<conio.h> //_getch();
#include<stdlib.h>
void main(void)
{
	int ans;
	printf("  Menu\n");
	printf("========\n");
	printf("1-Area of Circle\n");
	printf("2-Gold Price Calculator\n");
	printf("3-Exit\n");
	printf("Choose your anser : ");
	scanf_s("%d", &ans);
	
	switch (ans){
	case 1:		printf("Area of Circle\n"); _getch(); break;			
	case 2:		printf("Gold Price Calculator \n"); _getch(); break;
	case 3:		printf("Exit \n"); _getch(); exit(0); break;
	default:	printf("Wrong input \n"); _getch(); exit(0); break;
	}



	
}