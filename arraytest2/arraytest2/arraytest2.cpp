#include<stdio.h>
#include<conio.h>
int main()
{
	int a;
	int b[3]; //domain
	int e[3]; //co-domain
	int c[3]={1,3,6};
	int d[]={1,3,4,6,5,7,9,12,22,24,28};
	int k[3][4];
	int l[3][4];
	//matrix  matlab
	int j[3][4]={ 
						{1,2,3,4},
						{2,3,4,5},
						{3,4,5,6}
	};

	


	for(int r=0;r<3;r++)
	{
		for(int c=0;c<4;c++)
		{
			printf("please enter value of %d row %d column  of k ",r+1,c+1);
			scanf("%d",&k[r][c]);
		}
	}

	for(int r=0;r<3;r++)
	{
		for(int c=0;c<4;c++)
		{
			l[r][c]=2*k[r][c];
		}
	}

	for(int r=0;r<3;r++)
	{
		for(int c=0;c<4;c++)
		{
			printf("%d\t",l[r][c]);			
		}
		printf("\n");
	}
	//printf("please enter second value of b ");
	//scanf("%d",&b[1]);
	//printf("please enter third value of b ");
	//scanf("%d",&b[2]);

	//e=f(b)=2*b
	/*e[0]=2*b[0];
	e[1]=2*b[1];
	e[2]=2*b[2];*/

	for(int i=0;i<3;i++)
	{
		e[i]=2*b[i];
	}


	//printf("first value of e is %d \n",e[0]);
	//printf("second value of e is %d \n",e[1]);
	//printf("third value of e is %d \n",e[2]);
	for(int i=0;i<3;i++)
	{
			printf("%dth value of e is %d \n",i+1,e[i]);
	}
	getch();
	return 0;
}