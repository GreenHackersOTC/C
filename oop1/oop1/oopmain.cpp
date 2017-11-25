#include<stdio.h>
#include<conio.h>
#include<iostream>

using namespace std;
class classBook{
private:
	int price;
	int ISBN;
public:
	void setPrice(int p)
	{
		price=p;
	}
	int getPrice()
	{
		return price;
	}
};


int main()
{

	classBook b1,b2;
	b1.setPrice(100);
	cout<<b1.getPrice()<<endl;

	getch();
	return 0;
}