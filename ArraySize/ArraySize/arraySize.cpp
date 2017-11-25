#include<stdio.h>
#include<conio.h>
#define ExitWithoutError 0
#define ExitWithError -1
int funArraySize(char *arr);


int main()
{
	char a[6]="12345";
	a[5]=0;
	printf("%d",funArraySize(a));
	getch();
	return ExitWithoutError;
}


int funArraySize(char *arr)
{
	int count=0;
	while(arr[count]!=NULL) //NULL=0
	{
		count++;
	}
	return count;
}