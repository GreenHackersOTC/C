#include<stdio.h>
#include<conio.h>
#include<iostream>

#define BMW 0
#define HONDA 1
#define TOYOTA 2
#define brands 3

int mm[3];
int en[3];
int maths[3];
int result[3];
int arrySize(char *arr);
using namespace std;


int main()
{
	char a[20];
	char b[20];
	char c[20];
	char ch;
	int i=0;

	do{
		ch=getch();
		cout<<ch;
		if(ch!=13)
		{
			a[i]=ch;
			i++;
		}
	}while((ch!=13)&&(i<20));


	for(int i=0;i<arrySize(a);i++)
	{
		cout<<a[i]<<endl;
	}
	getch();
	return 0;
}


int arrySize(char *arr)
{
	int k=0;
	while(arr[k]>0)
	{
		k++;
	}
	return k;
}




int funMark()
{

	int Mark[3];
	
	for(int i=0;i<3;i++)
	{
		cout<<"enter mark for roll "<<i+1;
		cin>>Mark[i];
	}

	for(int i=0;i<3;i++)
	{
		if(Mark[i]<40)
		{
			cout<<"Roll "<<i+1<<" fail"<<endl;
		}
		else
		{
			cout<<"Roll "<<i+1<<" pass"<<endl;
		}
	}
	
	
	getch();
	return 0;
}


int funRollMarks()
{

	for(int i=0;i<3;i++)
	{
		cout<<"enter mm for roll no "<<i+1<<" ";
		cin>>mm[i];
		cout<<"enter en for roll no "<<i+1<<" ";
		cin>>en[i];
		cout<<"enter maths for roll no "<<i+1<<" ";
		cin>>maths[i];

		if((mm[i]>=40)&&(en[i]>=40)&&(maths[i]>=40))
		{
			result[i]=1;
		}
		else
		{
			result[i]=0;
		}
	}
	cout<<"Press any key to show results "<<endl;
	getch();
	for(int i=0;i<3;i++)
	{
		if(result[i]==1)
		{
			cout<<"roll no "<<i+1<< "is pass all subjs"<<endl;
		}
		else
		{
			cout<<"roll no "<<i+1<< "is fail"<<endl;
		}
	}

	getch();
	return 0;
}