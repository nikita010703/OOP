#include <iostream>

class Point {
protected:
	int x, y;

public:
	Point() : x(0), y(0) {
		printf("Вызван конструктор по умолчанию класса Point\n");
	}
	
	Point(int _x, int _y = 0) : x(_x), y(_y) {
		printf("Вызван конструктор с параметрами класса Point\n");
	}
	
	Point(const Point& pnt) : x(pnt.x), y(pnt.y) {
		printf("Вызван конструктор копирования класса Point\n");
	}

	~Point() {
		printf("Вызван деструктор класса Point\n");
	}

	virtual int getX() const {
		return x;
	};

	virtual int getY() const {
		return y;
	};

	void set(int _x = 0, int _y = 0) {
		x = _x;
		y = _y;
	};
};

class Circle : public Point {
protected:
	int radius;

public:
	Circle() : radius(1), Point() {
		printf("Вызван конструктор по умолчанию класса Circle\n");
	}

	Circle(int _radius) : radius(_radius), Point() {
		printf("Вызван конструктор с параметрами класса Circle\n");
	}

	Circle(const Point& pnt, int _radius = 1) : radius(_radius), Point(pnt) {
		printf("Вызван конструктор с параметрами класса Circle\n");
	}

	Circle(const Circle& crcl) : radius(crcl.radius), Point(crcl.x, crcl.y) {
		printf("Вызван конструктор копирования класса Circle\n");
	}

	~Circle() {
		printf("Вызван деструктор класса Circle\n");
	}

	int getRadius() const {
		return radius;
	};

	void setPoint(int _x, int _y) {
		x = _x;
		y = _y;
	};

	void setPoint(const Point& pnt) {
		x = pnt.getX();
		y = pnt.getY();
	};

	void setRadius(int _radius) {
		radius = _radius;
	};
};

int main() {
	setlocale(LC_ALL, "");

	printf("Тесты класса Point\n");
	Point p1(3, 4);
	Point* p2 = new Point(3);
	Point* p3 = p2;
	p2->set(4);

	printf("p1: %d %d\n", p1.getX(), p1.getY());
	printf("p2: %d %d\n", p2->getX(), p2->getY());
	printf("p3: %d %d\n", p3->getX(), p3->getY());

	printf("\nТесты класса Circle\n");
	Circle c1;
	Circle c2(1);
	Circle c3(*p3, 2);
	Circle c4(*p2);
	Circle c5(c2);
	c3.setRadius(3);
	Point* p4 = &c3;
	printf("p4: %d %d\n", p4->getX(), p4->getY());
	delete p2;

	printf("c1: %d %d %d\n", c1.getX(), c1.getY(), c1.getRadius());
	printf("c2: %d %d %d\n", c2.getX(), c2.getY(), c2.getRadius());
	printf("c3: %d %d %d\n", c3.getX(), c3.getY(), c3.getRadius());
	printf("c4: %d %d %d\n", c4.getX(), c4.getY(), c4.getRadius());
	printf("c5: %d %d %d\n", c5.getX(), c5.getY(), c5.getRadius());

	printf("Завершение программы\n\n");

	return 0;
}
