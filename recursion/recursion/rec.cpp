#include<stdio.h>
#include<conio.h>
int fibonacci(int i) ;



int  main() {

   int i;
	
   for (i = 0; i < 1000; i++) {
      printf("%d\t\n", fibonacci(i));
   }
	getch();
   return 0;
}

int fibonacci(int i) {

   if(i == 0) {
      return 0;
   }
	
   if(i == 1) {
      return 1;
   }
   return fibonacci(i-1) + fibonacci(i-2);
}