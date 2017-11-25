#include<stdio.h>
#include<conio.h>
#include<iostream>

using namespace std;
int main()
{

	int i=0;
	int j=0;
	while(1)
	{
		system("cls");
		printf("\nenter i ");
		scanf("%d",&i);

		j=(i<100)?1:2;
		
		getch();
	}

	return 0;
}