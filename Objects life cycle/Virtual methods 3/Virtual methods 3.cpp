#include <iostream>

class Animal {
public:
	void voice() const {
		std::cout << "Nothing\n";
	}

	virtual ~Animal() {
		std::cout << "~Animal()\n";
	}
};

class Dog : public Animal {
public:
	void voice() const {
		std::cout << "Woof!\n";
	}

	~Dog() {
		std::cout << "~Dog()\n";
	}
};

class CorrectAnimal {
public:
	virtual void voice() const {
		std::cout << "Nothing\n";
	}

	virtual ~CorrectAnimal() {
		std::cout << "~CorrectAnimal()\n";
	}
};

class CorrectDog : public CorrectAnimal {
public:
	void voice() const {
		std::cout << "Woof!\n";
	}

	~CorrectDog() {
		std::cout << "~CorrectDog()\n";
	}
};

int main() {
	Animal* anim1 = new Dog();
	Dog* anim2 = new Dog();
	anim1->voice();
	anim2->voice();

	delete anim1;
	delete anim2;
	std::cout << '\n';

	CorrectAnimal* anim3 = new CorrectDog();
	CorrectDog* anim4 = new CorrectDog();
	anim3->voice();
	anim4->voice();

	delete anim3;
	delete anim4;
	return 0;
}