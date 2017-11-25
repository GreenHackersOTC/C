#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
void UI(int x,int y,int e, int t,int trap, int found);
int main()
{
	UI(1,3,100,0,0,0);
	getch();
	UI(1,4,80,0,2,0);
	getch();
	return 0;
}

void UI(int x,int y,int e, int t,int trap, int found)
{
	system("cls");
	int i=0;
	printf("energy: ");
	for(i=0;i<(e/10);i++)
	{
		printf("*");
	}
	printf("%d",e);

}