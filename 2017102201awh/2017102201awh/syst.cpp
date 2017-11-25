#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
int main()
{
	int iAns=0;
	//prompt menu
	//read user input
	//determine user wish and go do it
	//go to first step
	do{
		system("cls");
		printf("Green Hackers' Menu System\n");
		printf("1-Exit\n");
		printf("2-Play Game\n");
		printf("Please choose one ");
		scanf("%d",&iAns);
		if(iAns==1)
		{
			exit(0);
		}
		if(iAns==2)
		{
			system("cls");
			printf("you choose to play game\n");
			getch();
		}
	}while(iAns!=1);

	getch();
	return 0;
}