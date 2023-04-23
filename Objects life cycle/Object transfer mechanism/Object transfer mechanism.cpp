#include <iostream>

class Base {
	int count = 0;
public:
	Base() {
		std::cout << "Base()\n";
		count++;
	}
	Base(Base* obj) {
		std::cout << "Base(Base* obj)\n";
		count++;
	}
	Base(Base& obj) {
		std::cout << "Base(Base& obj)\n";
		count++;
	}
	~Base() {
		std::cout << "~Base()\n";
		count--;
	}
	void print() {
		std::cout << count << "\n";
	}
};

class Desc : public Base{
public:
	Desc() {
		std::cout << "Desc()\n";
	}
	Desc(Desc* obj) {
		std::cout << "Desc(Desc* obj)\n";
	}
	Desc(Desc& obj) {
		std::cout << "Desc(Desc& obj)\n";
	}
	~Desc() {
		std::cout << "~Desc()\n";
	}
};

void in1(Base obj) {
	std::cout << "in1(Base obj)\n";
}
void in2(Base* obj) {
	std::cout << "\nin2(Base* obj)\n";
}
void in3(Base& obj) {
	std::cout << "\nin3(Base& obj)\n";
}

Base out1() {
	std::cout << "\nBase out1()\n";
	Base tmp;
	return tmp;
};
Base* out2() {
	std::cout << "\nBase* out2()\n";
	Base tmp;
	return &tmp;
};
Base& out3() {
	std::cout << "\nBase& out3()\n";
	Base tmp;
	return tmp;
};
Base out4() {
	std::cout << "\nBase out4()\n";
	Base* tmp = new Base();
	return *tmp;
};
Base* out5() {
	std::cout << "\nBase* out5()\n";
	Base* tmp = new Base();
	return tmp;
};
Base& out6() {
	std::cout << "\nBase& out6()\n";
	Base* tmp = new Base();
	return *tmp;
};

int main() {
	Base* b = new Base();
	Desc* d = new Desc();

	std::cout << "\nInput Base to functions:\n";
	in1(*b);
	in2(b);
	in3(*b);

	std::cout << "\nInput Desc to functions:\n";
	in1(*d);
	in2(d);
	in3(*d);

	delete d;
	delete b;
	/*
	std::cout << "\nOutput objects from functions:" << std::endl;
	//Base o1 = out1();
	//o1.print();
	Base* po2 = out2();
	po2->print();
	Base o3 = out3();
	o3.print();
	//Base o4 = out4();
	//o4.print();
	Base* po5 = out5();
	po5->print();
	Base o6 = out6();
	o6.print();


	//delete po2;
	//delete po5;
	*/
	Base o;
	Base* po;

	std::cout << "\nOutput objects from functions:" << std::endl;
	o = out1();
	o.print();
	po = out2();
	po->print();
	o = out3();
	o.print();
	o = out4();
	o.print();
	po = out5();
	po->print();
	o = out6();
	o.print();

	return 0;
}