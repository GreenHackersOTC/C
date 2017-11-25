#include<stdio.h>
#include<conio.h>
#include<iostream>
int strlen2(char * arr);
using namespace std;

int main()
{
	cout<<strlen("i am aung win htut")<<endl;
	cout<<strlen2("i am aung win htut");
	getch();
	return 0;
}

int strlen2(char * arr)
{
	int i=0;
	while(arr[i]!=0)
	{
		i++;
	}
	return i;
}
//char a[]; char *a; 