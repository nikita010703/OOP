#include <cstdlib>
#include <iostream>
#include <ctime>
#include "Container.h"


// Абстрактный класс и два его наследника для примера использования контейнера
class Animal {
protected:
	std::string name;
public:
	Animal(std::string _name) : name(_name) {};

	virtual void say() = 0;
};

class Cat : public Animal {
public:
	Cat() : Animal("Cat") {};

	void say() override {
		std::cout << "Meow\n";
	}
};

class Dog : public Animal {
public:
	Dog() : Animal("Dog") {};

	void say() override {
		std::cout << "Bark\n";
	}
};


int main() {
	srand(time(nullptr));

	// Ввод количества команд
	int numOfCommands;
	std::cin >> numOfCommands;

	// Создание контейнера
	Container<Animal*> c;

	// Фиксация времени на момент начала тестов
	clock_t start = clock();

	// 4 команды для вставки элементов. Заполнение контейнера.
	int command;
	Animal* newAnim;
	for (int i = 0; i < numOfCommands / 10; i++) {
		if (rand() % 2 == 0)
			newAnim = new Cat();
		else
			newAnim = new Dog();

		command = rand() % 4;
		switch (command) {
			case 0: {
				c.pushFront(newAnim);
				break;
			}
			case 1: {
				c.pushBack(newAnim);
				break;
			}
			case 2: {
				c.insert(newAnim);
				break;
			}
			case 3: {
				int pos = rand() % (c.size() + 1);
				c.insert(newAnim, pos);
				break;
			}
			default:
				continue;
		}
	}

	// Всего 18 команд. 13 основных команд. Работа с контейнером
	for (int i = numOfCommands / 10; i < numOfCommands; i++) {
		command = rand() % 13;
		switch (command) {
			case 0: {
				if (rand() % 2 == 0)
					newAnim = new Cat();
				else
					newAnim = new Dog();

				c.pushFront(newAnim);
				break;
			}
			case 1: {
				if (rand() % 2 == 0)
					newAnim = new Cat();
				else
					newAnim = new Dog();

				c.pushBack(newAnim);
				break;
			}
			case 2: {
				if (rand() % 2 == 0)
					newAnim = new Cat();
				else
					newAnim = new Dog();

				c.insert(newAnim);
				break;
			}
			case 3: {
				if (rand() % 2 == 0)
					newAnim = new Cat();
				else
					newAnim = new Dog();

				int pos = rand() % (c.size() + 1);
				c.insert(newAnim, pos);
				break;
			}
			case 4: {
				c.remove();
				break;
			}
			case 5: {
				int pos = rand() % (c.size() + 1);
				c.remove(pos);
				break;
			}
			case 6: {
				Animal* tmp = c.getObject();
				if (tmp != nullptr)
					tmp->say();
				break;
			}
			case 7: {
				c.next();
				break;
			}
			case 8: {
				c.previous();
				break;
			}
			case 9: {
				c.begin();
				break;
			}
			case 10: {
				c.end();
				break;
			}
			case 11: {
				c.popFront();
				break;
			}
			case 12: {
				c.popBack();
				break;
			}
			default:
				continue;
		}
	}

	// Фиксация времени к концу тестов
	clock_t end = clock();

	// Вывод общего времени работы с контейнером
	double runTime = (double)(end - start) / CLOCKS_PER_SEC;
	std::cout << "runtime = " << runTime;

	return 0;
}
