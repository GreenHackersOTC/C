#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<string.h>

#define RECORD_LENGTH 60
int funArraySize(char *arr);
struct BUFFER splitTwoArray(char* arr, char ch);
struct DATA splitData(char* arr, char ch);
void copyArray(char *from, char* to);

struct DATA {
	char name[60];
	char age[60];
	char email[60];
	char ph[60];
};

struct BUFFER{
	char first[60];
	char second[60];
};

int main()
{
	struct DATA people[20];
	int i=0;
	FILE* fptr;
	char stock_price_shares[RECORD_LENGTH+1];

	fptr = fopen("e:\\cpp\\PORTFOLIO.DAT","r");

	if( fptr == NULL)
	{
		printf("\nCannot read file ");
		exit(1);
	}
	else{
		printf("\n%d - 12345\n ",funArraySize("12345"));
		while(fgets(stock_price_shares,RECORD_LENGTH+1,fptr)!=NULL)
		{
			printf("%d - ",funArraySize(stock_price_shares));
			printf("%s",stock_price_shares);		
			people[i]=splitData(stock_price_shares,'#');
			i++;
		}
		fclose(fptr);
	}

	for(int j=0;j<i;j++)
	{
		printf("name of roll %d is %s \n",j+1,people[j].name );
		printf("age of roll %d is %s \n",j+1,people[j].age );
		printf("emial of roll %d is %s \n",j+1,people[j].email );
		printf("phone of roll %d is %s \n\n",j+1,people[j].ph );
	}
	
	getch();
	return 0;
	
}

struct DATA splitData(char* arr, char ch)
{
	struct DATA result;
	struct BUFFER buf;
	buf=splitTwoArray(arr,ch);
	//strcpy(result.name,buf.first);
	copyArray(buf.first, result.name);
	buf=splitTwoArray(buf.second ,ch);
	strcpy(result.age,buf.first  );
	buf=splitTwoArray(buf.second ,ch);
	strcpy(result.email ,buf.first );
	strcpy(result.ph ,buf.second );
	return result;
}

struct BUFFER splitTwoArray(char* arr, char ch)
{
	struct BUFFER buffer;
	int size=0;
	int i=0;
	int location_of_sh=0;
	size = funArraySize(arr);
	for(i=0;i<size;i++)
	{
		if(arr[i]==ch)
		{
			location_of_sh=i;
			break;
		}
	}

	for(i=0;i<location_of_sh;i++)
	{
		buffer.first[i] =arr[i];
	}
	buffer.first[i]=0;
	for(i=location_of_sh+1;i<size;i++)
	{
		buffer.second[i-location_of_sh-1] =arr[i];
	}
	buffer.second[i-location_of_sh-1] =NULL;

	return buffer;
}




int funArraySize(char *arr)
{
	int count=0;
	while(arr[count]!=NULL) //NULL=0
	{		
				count++;	
	}
	return count-1;
}





int funArraySize(int *arr)
{
	return 0;
}

void copyArray(char *from, char* to)
{
	while(*from!=0)
	{
		*to++=*from++;
	}
	*to++=NULL;
}