//system() - process.h  
#include<process.h>
#include<conio.h>
void main(void)
{
	system("gcc -o d:\\hello.exe d:\\hello.c"); // "\"C:\\Program Files (x86)\\Arduino\\arduino.exe \""
	system("dir d:\\hello.exe");
	system("d:\\hello.exe");
	_getch();
}