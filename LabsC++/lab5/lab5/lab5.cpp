#include "pch.h"
#include <iostream>
#include <string>

#include <sstream>


#include <ctime>
#pragma warning(disable : 4996)

using namespace std;

class MyDate {
	friend void convertTime(MyDate &);
public:

	void CurrentDate() {
		time_t rawtime;
		struct tm *timeinfo;
		time(&rawtime);
		timeinfo = localtime(&rawtime);

		MyData = asctime(timeinfo);
		seconds = timeinfo->tm_sec;
		minut = timeinfo->tm_min;
		hours = timeinfo->tm_hour;
	}

private :

	string MyData;
	int seconds;
	int minut;
	int hours;

};

void convertTime(MyDate &d) {
	cout << d.MyData << endl;
	cout <<"Convert to seconds: "<< d.seconds + d.minut*60 + d.hours*3600 << endl;

}

class Example1 {
	friend class Example2;
public:

	Example1(string n , string s , int a ) {
		name = n;
		surname = s;
		age = a;
	}
private:
	string name;
	string surname;
	int age;
};

class Example2 {
public:
	void ShowItems (Example1 &a){
		cout << a.name << "\t" << a.surname << "\t" << a.age << endl;
	}
};







int main()
{
	setlocale(LC_ALL, "rus");
	//1

	/*MyDate check;
	check.CurrentDate();
	convertTime(check);*/


	//2

	Example1 exp1("Nikolay","Parfenchik",20);
	Example2 exp2;
	exp2.ShowItems(exp1);





	system("pause");
}


