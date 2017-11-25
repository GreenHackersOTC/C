#include<stdio.h>
#include<conio.h>
#include<iostream>
using namespace std;
void writeSpace(int n);
void drawHline();
void drawSpace();
void drawUI(int x, int y , char ch);

int main()
{

	drawUI(1,1,'X');

	getch();
	return 0;
}

void writeSpace(int n,char ch=' ')
{
	if(n<=20)
	{
		for(int i=0;i<n;i++)
		{
			cout<<ch;
		}
	}
}

void drawHline()
{
	for(int i=0;i<20;i++)
	{
		cout<<"*";
	}
	cout<<endl;
}

void drawSpace()
{
	cout<<"*";
	for(int i=0;i<18;i++)
	{
		cout<<" ";
	}
	cout<<"*"<<endl;
}

void drawUI(int x, int y , char ch)
{
	drawHline();
	for(int i=1;i<y-1;i++)
	{
		drawSpace();
	}

	cout<<"*";
	writeSpace(x-1,' ');
	cout<<ch;
	writeSpace(18-x,' ');
	cout<<"*";
	cout<<endl;

	for(int i=y;i<19;i++)
	{
		drawSpace();
	}
	drawHline();
}