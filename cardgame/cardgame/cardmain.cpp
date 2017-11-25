#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<iostream>
int cards[52];
int cards2[52];
int s=1;

using namespace std;
void funSortCards();

int main()
{
	funSortCards();
	//cutcards();
	//sharecards();
	_getch();
	return 0;
}

void funSortCards()
{
	time_t t;
	srand((unsigned) time(&t));
	int card;
	int i;
	int j;
	int k;
	for(i=0;i<52;i++)
	{
		
		do{
			s=1;
			card = (rand()%52)+1;
			for(j=0;j<i;j++)
			{
					if(card==cards[j])
					{
							s=0;
					}
			}

		}while(s!=1);		
		cards[i]=card;
	
	}
	for(i=0;i<52;i++)
	{
		cout<<cards[i]<<endl;
	}

}