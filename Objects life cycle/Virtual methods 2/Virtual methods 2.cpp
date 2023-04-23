#include <iostream>

class Animal {
public:
	void voice() {
		std::cout << getVoice() << '\n';
	}

	std::string getVoice() {
		return "Nothing";
	}

	virtual ~Animal() {
		std::cout << "~Animal()\n";
	}
};

class Dog : public Animal {
public:
	std::string getVoice() {
		return "Woof!";
	}

	~Dog() {
		std::cout << "~Dog()\n";
	}
};

class CorrectAnimal {
public:
	virtual void voice() const {
		std::cout << getVoice() << '\n';
	}

	virtual std::string getVoice() const {
		return "Nothing";
	}

	virtual ~CorrectAnimal() {
		std::cout << "~CorrectAnimal()\n";
	}
};

class CorrectDog : public CorrectAnimal {
public:
	std::string getVoice() const override {
		return "Woof!";
	}

	~CorrectDog() {
		std::cout << "~CorrectDog()\n";
	}
};

int main() {
	Dog* anim1 = new Dog();
	anim1->voice();

	CorrectDog* anim2 = new CorrectDog();
	anim2->voice();

	delete anim1;
	delete anim2;
	return 0;
}