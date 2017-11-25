#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
void delay(unsigned int mseconds);

int main( int argc, char *argv[])
{
	FILE *fin,*fo;
	if(argc!=3)
	{
		printf("error! correct arg no is 3 \n");
		getch();
		exit(1);
	}
	fin=fopen(argv[1],"r");
	fo=fopen(argv[2],"w");
	if(fin== (FILE *)0)
	{
		printf("file error!\n");
		exit(1);
	}
	int byte;
	int count=0;
	int i=0;
	do{
			byte=getc(fin);		
			if(byte!=EOF)
			{
				fputc(byte,fo);	
			}
			i++;
	}while(byte!=EOF);

	fclose(fo);
	fclose(fin);
	system("notepad e:\\path1.txt");

	return 0;
}

void delay(unsigned int mseconds)
{
    clock_t goal = mseconds + clock();
    while (goal > clock());
}