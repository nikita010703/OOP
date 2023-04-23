#include <iostream>
#include <vector>

class Animal {
public:
	virtual std::string classname() const {
		return "Animal";
	}

	virtual bool isA(std::string name) const {
		return "Animal" == name;
	}

	virtual ~Animal() {}
};

class Dog : public Animal {
public:
	virtual std::string classname() const override {
		return "Dog";
	}

	virtual bool isA(std::string name) const override {
		return ("Dog" == name) || Animal::isA(name);
	}

	virtual void chaseCat() {
		std::cout << "Chasing a cat (" << classname() << ")\n";
	}

	virtual ~Dog() {
		std::cout << "~Dog()\n";
	}
};

class Shepherd : public Dog {
public:
	std::string classname() const override {
		return "Shepherd";
	}

	bool isA(std::string name) const override {
		return ("Shepherd" == name) || Dog::isA(name);
	}

	~Shepherd() {
		std::cout << "~Shepherd()\n";
	}
};

class Cat : public Animal {
public:
	virtual std::string classname() const override {
		return "Cat";
	}

	virtual bool isA(std::string name) const override {
		return ("Cat" == name) || Animal::isA(name);
	}

	virtual void catchMouse() {
		std::cout << "Catch a mouse (" << classname() << ")\n";
	}

	virtual ~Cat() {
		std::cout << "~Cat()\n";
	}
};

class Sphinx : public Cat {
public:
	std::string classname() const override {
		return "Sphinx";
	}

	bool isA(std::string name) const override {
		return ("Sphinx" == name) || Cat::isA(name);
	}

	~Sphinx() {
		std::cout << "~Sphinx()\n";
	}
};

int main() {
	srand(time(0));

	std::vector<Animal*> animals(10);
	for (int i = 0; i < animals.size(); i++) {
		int random = rand() % 4;
		switch (random) {
		case 0: animals[i] = new Dog(); break;
		case 1: animals[i] = new Shepherd(); break;
		case 2: animals[i] = new Cat(); break;
		case 3: animals[i] = new Sphinx(); break;
		}
	}

	std::cout << "Check classname():\n";
	for (auto anim : animals) {
		if (anim->classname() == "Dog" || anim->classname() == "Shepherd")
			static_cast<Dog*>(anim)->chaseCat();
		else if (anim->classname() == "Cat" || anim->classname() == "Sphinx")
			static_cast<Cat*>(anim)->catchMouse();
	}

	std::cout << "\nCheck isA():\n";
	for (auto anim : animals) {
		if (anim->isA("Dog"))
			static_cast<Dog*>(anim)->chaseCat();
		else if (anim->isA("Cat"))
			static_cast<Cat*>(anim)->catchMouse();
	}

	std::cout << "\nCheck dynamic_cast<>:\n";
	for (auto anim : animals) {
		Dog* potentialDog = dynamic_cast<Dog*>(anim);
		Cat* potentialCat = dynamic_cast<Cat*>(anim);
		if (potentialDog != nullptr)
			potentialDog->chaseCat();
		if (potentialCat != nullptr)
			potentialCat->catchMouse();
	}
	return 0;
}