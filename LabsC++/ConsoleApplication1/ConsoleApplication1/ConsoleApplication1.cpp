
#include "pch.h"
#include <iostream>
#include <string>
using namespace std;

class FirstClass    // базовый класс
{
protected:
	string surname, name, patronymic, numberPhone;
public:
	FirstClass(){};
	FirstClass(string surnamein, string namein, string patronymicin, string numberPhonein)
	{
		surname = surnamein;
		name = namein;
		patronymic = patronymicin;
		numberPhone = numberPhonein;
	}

	void showStudentOne()
	{
		cout << surname << " " << name << " " << patronymic << " " << numberPhone << endl;
	}
};

class SecondClass : public FirstClass   // производный класс
{
protected:
	string payment; char debt = '-'; double avr = 0;
public:
	SecondClass() : FirstClass(){};
	SecondClass(string paymentin, char debtin) {
		payment = paymentin;
		debt = debtin;
	}
	SecondClass(string surnamein, string namein, string patronymicin, string numberPhonein, string paymentin, char debtin, double avrin) : FirstClass(surnamein, namein, patronymicin, numberPhonein)
	{
		payment = paymentin;
		debt = debtin;
		avr = avrin;
	}
	void showStudentOne()
	{
		cout << surname << " " << name << " " << patronymic << " " << numberPhone << " " << payment << " " << debt << " " << avr << " ";
		if (avr >= 7 && debt == '-') {
			cout << "Grateful letter!" << endl;
		}
		else { cout << "Not grateful letter!" << endl; };
	}
};
class ThithClass : public SecondClass   // производный класс
{
protected:
	string surnameParent, nameParent, patronymicParent, profession;
public:
	ThithClass(string surnameParentin, string nameParentin, string patronymicParentin, string professionin) {
		surnameParent = surnameParentin;
		nameParent = nameParentin;
		patronymicParent = patronymicParentin;
		profession = professionin;
	}
	ThithClass(string surnamein, string namein, string patronymicin, string numberPhonein, string paymentin, char debtin, double avrin, string surnameParentin, string nameParentin, string patronymicParentin, string professionin) : SecondClass(surnamein, namein, patronymicin, numberPhonein, paymentin, debtin, avrin)
	{
		surnameParent = surnameParentin;
		nameParent = nameParentin;
		patronymicParent = patronymicParentin;
		profession = professionin;
	}
	void showStudentOne()
	{
		cout << surname << " " << name << " " << patronymic << " " << numberPhone << " " << payment << " " << debt << " " << avr << " " << surnameParent << " " << nameParent << " " << patronymicParent << " " << profession << " - ";
		if (avr >= 7 && debt == '-') {
			cout << "Grateful letter!" << endl;
		} else { cout << "Not grateful letter!" << endl; };
	}
};

int main()
{
	FirstClass firstClass("Nikolay", "Parfenchik", "Alexandrovich", "+375259020996");
	firstClass.showStudentOne();
	SecondClass secondClass("Nikolay", "Parfenchik", "Alexandrovich", "+375259020996", "22", '-', 7);
	secondClass.showStudentOne();
	ThithClass thithClass("Nikolay", "Parfenchik", "Alexandrovich", "+375259020996", "22", '-', 6, "Nikolay1", "Parfenchik1", "Alexandrovich1", "programm");
	thithClass.showStudentOne();
	ThithClass thithClass1("Nikolay", "Parfenchik", "Alexandrovich", "+375259020996", "22", '+', 8, "Nikolay1", "Parfenchik1", "Alexandrovich1", "programm");
	thithClass1.showStudentOne();

}
