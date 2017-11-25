#include<stdio.h>
#include<conio.h>

int main()
{
	char string[10]="aungwinht";
	char **pp,*p;
	p=string;
	pp = &p;

	printf("%s",*pp);
	


	getch();
	return 0;
}