
#include "pch.h"
#include <iostream>
#include <string>
#include <Windows.h>
using namespace std;

class FirstClass
{
	friend void functionFriend(FirstClass &);
public:
	FirstClass() {
		cout << "Constructor" << endl;
	};
	~FirstClass() {
	cout << "Distructor" << endl;
	};
protected:
	string dateSpeak, codCity, nameCity, continueTimeSpeak, tarif, numberPhoneIn, numberPhoneAbonent; int number = 0;
};

void functionFriend(FirstClass &a) {
	cout << "Дата разговора: ";
	cin >> a.dateSpeak;
	cout << "Код страны: ";
	cin >> a.codCity;
	cout << "Название страны: ";
	cin >> a.nameCity;
	cout << "Продолжительность исходящего разговора: ";
	cin >> a.continueTimeSpeak;
	cout << "Тариф: ";
	cin >> a.tarif;
	cout << "Номер исходящего звонка: ";
	cin >> a.numberPhoneIn;
	cout << "Номер абонента: ";
	cin >> a.numberPhoneAbonent;
	
	cout << "Selection: " << endl;
	cout << "1. Дата разговора " << endl;
	cout << "2. Код страны " << endl;
	cout << "3. Название страны " << endl;
	cout << "4. Продолжительность исходящего разговора " << endl;
	cout << "5. Тариф " << endl;
	cout << "6. Номер исходящего звонка " << endl;
	cout << "7. Номер абонента " << endl;
	cout << "Enter number: ";
	cin >> a.number;
	switch (a.number)
	{
	case 1: cout << "Дата разговора: " << a.dateSpeak << endl;
		break;
	case 2: cout << "Код страны: " << a.codCity << endl;
		break;
	case 3: cout << "Название страны: " << a.nameCity << endl;
		break;
	case 4: cout << "Продолжительность исходящего разговора: " << a.continueTimeSpeak << endl;
		break;
	case 5: cout << "Тариф: " << a.tarif << endl;
		break;
	case 6: cout << "Номер исходящего звонка: " << a.numberPhoneIn << endl;
		break;
	case 7: cout << "Номер абонента: " << a.numberPhoneAbonent << endl;
		break;
	default: cout << "Wrong number." << endl;
		break;
	}
}

class SecondClass : public FirstClass
{
protected:
	string viewLgot, percentForLgot, surchargeTarif;
public:
	SecondClass(string viewLgotin, string percentForLgotin, string surchargeTarifin) : FirstClass()
	{
		viewLgot = viewLgotin;
		percentForLgot = percentForLgotin;
		surchargeTarif = surchargeTarifin;
		cout << "Вид льготы: " << viewLgot << endl;
		cout << "Процент для льготного тарифа: " << percentForLgot << "%" << endl;
		cout << "Набравка к тарифу за срочность вызова: " << surchargeTarif << " рублей" << endl;
	};


};

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	FirstClass firstClass1;
	functionFriend(firstClass1);
	SecondClass secondClass1("Обычная льгота", "15", "10");	
	
}