#include<stdio.h>
#include<conio.h>
void setup();
void loop();
int b=0;
int f=5;
int main()
{
	setup();
	for(;;)
	{
		loop();
	}
}

void setup()
{
	printf("LED fading program\n");
}
void loop()
{
	b=b+f;
	if(b==0||b==255)
	{
		f=-f;
	}

}