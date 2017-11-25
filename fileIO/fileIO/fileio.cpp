#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
int main()
{
	FILE *fpInput;
	FILE *fpOutput;
	int i;
	float f;
	char c;
	fpOutput=fopen("e:\\testfile.bat","w");
	fprintf(fpOutput,"%s","ping google.com -t");
	fclose(fpOutput);
	printf("press any key to run that batch file....\n");
	getch();
	system("type e:\\testfile.bat");
	getch();
	system("e:\\testfile.bat");
	getch();
}