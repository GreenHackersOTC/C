#include<stdio.h>			//printf() scanf()
#include<conio.h>		//getch()

void main()
{
	int total_gold_price;
	int gold_price_per_kyat;
	float kyat;
	float pae;
	float yway;
	
	printf("Please enter gold price per kyat  :  ");
	scanf_s("%d", &gold_price_per_kyat);
	printf("Please enter kyat :  ");
	scanf_s("%f", &kyat);
	printf("Please enter pae :  ");
	scanf_s("%f", &pae);
	printf("Please enter yway  :  ");
	scanf_s("%f", &yway);

	total_gold_price = gold_price_per_kyat * (kyat +( pae / 16 )+( yway / (8 * 16)));

	printf("total gold price is %d ", total_gold_price);
	_getch();

}