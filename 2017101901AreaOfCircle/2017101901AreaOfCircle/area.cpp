#include<stdio.h>
#include<conio.h>

int main()
{
	float Kyat=0;
	float Pae=0;
	float Yway =0;
	float goldPricePerKyat=0;
	float goldPrice=0.0;
	int iGoldPrice=0;
	float temp =0.0;
	printf("Please Enter gold price per kyat ");
	scanf("%f",&goldPricePerKyat);
	printf("Please Enter Kyat ");
	scanf("%f",&Kyat);
	printf("jPlease Enter Pae ");
	scanf("%f",&Pae);
	printf("Please Enter Yway ");
	scanf("%f",&Yway);
	temp = (Kyat + (Pae/18)+(Yway/72));
	goldPrice = goldPricePerKyat * temp;
	iGoldPrice = goldPrice;

	printf("%f %d",goldPrice,iGoldPrice);
	getch();
	return 0;
}