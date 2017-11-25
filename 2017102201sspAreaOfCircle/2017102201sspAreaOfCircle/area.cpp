#include<stdio.h>
#include<conio.h>
int main()
{
	float A=0.0;
	float R=0.0;

	printf("Please Enter Radius ");
	scanf("%f",&R);

	A = 3.14 * R * R ;
	printf("Area = %f",A);
	getch();
	return 0;
}