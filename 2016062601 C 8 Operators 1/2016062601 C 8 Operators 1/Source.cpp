#include<conio.h>
#include<stdio.h>
#include<stdlib.h>
int main()
{
	int i=4, a = 314;
	int b = 22;
	int c = 3;
	char ch = 'A';
	char bh = '0';
	char buffer[33];

	printf("%c = %d  =  0x%x\n", ch,ch,ch);
	printf("%c = %d  = 0x%x\n", bh, bh,bh);

	_itoa_s(a, buffer, 2);
	printf("binary value of %d is %16s\n", a, buffer);
	_itoa_s(b, buffer, 2);
	printf("binary  value of %d is %16s\n", b, buffer);
	_itoa_s(a^b, buffer, 2);
	printf("binary  value of %d is %16s\n", b, buffer);

	


	_getch();
	return 0;
}