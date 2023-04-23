#include <iostream>

class Animal {
public:
	Animal() {};
	void voice() {
		std::cout << "Nothing\n";
	}

	~Animal() {
		std::cout << "~Animal()\n";
	}
};

class Dog : public Animal {
public:
	Dog() {};
	void voice() {
		std::cout << "Woof!\n";
	}

	~Dog() {
		std::cout << "~Dog()\n";
	}
};

class CorrectAnimal {
public:
	virtual void voice() {
		std::cout << "Nothing\n";
	}

	virtual ~CorrectAnimal() {
		std::cout << "~CorrectAnimal()\n";
	}
};

class CorrectDog : public CorrectAnimal {
public:
	void voice() override {
		std::cout << "Woof!\n";
	}

	~CorrectDog() {
		std::cout << "~CorrectDog()\n";
	}
};

int main() {
	Animal* anim1 = new Dog();
	anim1->voice();

	CorrectAnimal* anim2 = new CorrectDog();
	anim2->voice();

	delete anim1;
	delete anim2;
	return 0;
}