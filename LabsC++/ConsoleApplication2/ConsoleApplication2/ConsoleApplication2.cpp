
#include "pch.h"
#include <iostream>
#include <string>
using namespace std;

class FirstClass   
{
protected:
	string surname, name, address; double avr; double assessment;
public:
	FirstClass() {};
	FirstClass(string surnamein, string namein, string addressin, double avrin)
	{
		surname = surnamein;
		name = namein;
		address = addressin;
		avr = avrin;

	}

	void showStudentOne()
	{
		cout << "Enter average assessment:";
		cin >> assessment;
		cout << surname << " " << name << " " << address << " " << avr << " ";
		if (avr >= assessment) {
			cout << "Entered!" << endl;
		} else { cout << "Not entered!" << endl; }
	}
};

class SecondClass : public FirstClass   
{
protected:
	string institution;
public:
	SecondClass() : FirstClass() {};
	SecondClass(string institutionin, char debtin) {
		institution = institutionin;
	}
	SecondClass(string surnamein, string namein, string addressin, double avrin, string institutionin) : FirstClass(surnamein, namein, addressin, avrin)
	{
		institution = institutionin;
	}
	void showStudentOne()
	{
		cout << "Enter average assessment:";
		cin >> assessment;
		cout << surname << " " << name << " " << address << " " << avr << " " << institution << " ";
		if (avr >= assessment) {
			cout << "Entered!" << endl;
			cout << assessment << endl;
		}
		else { cout << "Not entered!" << endl; }
	}
};
class ThithClass : public SecondClass   // производный класс
{
protected:
	string faculty;
public:
	ThithClass() : SecondClass() {};
	ThithClass(string facultyin) {
		faculty = facultyin;
	}
	ThithClass(string surnamein, string namein, string addressin, double avrin, string institutionin, string facultyin) : SecondClass(surnamein, namein, addressin, avrin, institutionin)
	{
		faculty = facultyin;
	}
	void showStudentOne()
	{
		cout << "Enter average assessment:";
		cin >> assessment;
		cout << surname << " " << name << " " << address << " " << avr << " " << institution << " " << institution << " ";
		if (avr >= assessment) {
			cout << "Entered!" << endl;
		}
		else { cout << "Not entered!" << endl; }
	}
};

int main()
{
	ThithClass thithClass("Alexander", "Peretyatko", "address", 7, "nameOne", "nameTwo");
	thithClass.showStudentOne();
	ThithClass thithClass1("Alexander", "Peretyatko", "address", 6, "nameOne", "nameTwo");
	thithClass1.showStudentOne();

}