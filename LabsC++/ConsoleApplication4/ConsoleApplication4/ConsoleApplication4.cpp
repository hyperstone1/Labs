#include "pch.h"
#include <iostream>
#include <string>
using namespace std;

class Person {

public:
	Person() {
		cout << "name: ";
		cin >> name;
		cout << "surname: ";
		cin >> surname;
		cout << "address: ";
		cin >> address;
	}
	void coutAll() {
		cout << "name: " << name << endl;
		cout << "surname: " << surname << endl;
		cout << "address: " << address << endl;
	}
protected:
	string name, surname, address;
};
class Pupil {
protected:
	string numberSchool, average;
public:
	Pupil() {
		cout << "numberSchool: ";
		cin >> numberSchool;
		cout << "average: ";
		cin >> average;
	}
	void coutAll() {
		cout << "numberSchool: " << numberSchool << endl;
		cout << "average: " << average << endl;
	}
};
class Strudent : public Person, public Pupil {
protected:
	string nameInstitution, nameFacultet;
public:
	Strudent() : Person(), Pupil() {
		cout << "nameInstitution: ";
		cin >> nameInstitution;
		cout << "nameFacultet: ";
		cin >> nameFacultet;
	}
	void coutAll() {
		cout << "name: " << name << endl;
		cout << "surname: " << surname << endl;
		cout << "address: " << address << endl;
		cout << "numberSchool: " << numberSchool << endl;
		cout << "average: " << average << endl;
		cout << "nameInstitution: " << nameInstitution << endl;
		cout << "nameFacultet: " << nameFacultet << endl;
	}
};
class Aspirant : public Strudent {
protected:
	string nameDesertation;
public:
	
	Aspirant() : Strudent() {
		cout << "nameDesertation: ";
		cin >> nameDesertation;
	}
	void coutAll() {
		cout << "name: " << name << endl;
		cout << "surname: " << surname << endl;
		cout << "address: " << address << endl;
		cout << "numberSchool: " << numberSchool << endl;
		cout << "average: " << average << endl;
		cout << "nameInstitution: " << nameInstitution << endl;
		cout << "nameFacultet: " << nameFacultet << endl;
		cout << "nameInstitution: " << nameInstitution << endl;
		cout << "nameFacultet: " << nameFacultet << endl;
	}
};
class N_rabotnik : public  Aspirant {
protected:
	string placeJob, salary;
public:
	N_rabotnik() : Aspirant(){
		cout << "placeJob: ";
		cin >> placeJob;
		cout << "salary: ";
		cin >> salary;
	}
	void coutAll() {
		cout << "name: " << name << endl;
		cout << "surname: " << surname << endl;
		cout << "address: " << address << endl;
		cout << "numberSchool: " << numberSchool << endl;
		cout << "average: " << average << endl;
		cout << "nameInstitution: " << nameInstitution << endl;
		cout << "nameFacultet: " << nameFacultet << endl;
		cout << "nameInstitution: " << nameInstitution << endl;
		cout << "nameFacultet: " << nameFacultet << endl;
		cout << "placeJob: " << placeJob << endl;
		cout << "salary: " << salary << endl;
	}
};
int main()
{
	N_rabotnik n_rabotnik;
	n_rabotnik.coutAll();
}
