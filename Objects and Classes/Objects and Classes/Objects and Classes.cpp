#include <iostream>

class Point {
protected:
	int x, y;

public:
	Point() : x(0), y(0) {
		printf("Point()\n");
	}
	
	Point(int _x, int _y = 0) : x(_x), y(_y) {
		printf("Point(int x, int y)\n");
	}
	
	Point(const Point& pnt) : x(pnt.x), y(pnt.y) {
		printf("Point(const Point& pnt)\n");
	}

	~Point() {
		printf("~Point()\n");
		printf("%d %d\n", x, y);
	}

	int getX() const {
		return x;
	}

	int getY() const {
		return y;
	}

	void set(int _x = 0, int _y = 0) {
		x = _x;
		y = _y;
	}
};

class SizedPoint : public Point {
protected:
	int radius;

public:
	SizedPoint() : radius(1), Point() {
		printf("SizedPoint()\n");
	}

	SizedPoint(int _radius) : radius(_radius), Point() {
		printf("SizedPoint(int radius)\n");
	}

	SizedPoint(int x, int y, int _radius = 1) : radius(_radius), Point(x, y) {
		printf("SizedPoint(const Point& pnt, int radius)\n");
	}

	SizedPoint(const Point& pnt, int _radius = 1) : radius(_radius), Point(pnt) {
		printf("SizedPoint(const Point& pnt, int radius)\n");
	}

	SizedPoint(const SizedPoint& sPnt) : radius(sPnt.radius), Point(sPnt) {
		printf("SizedPoint(const SizedPoint& sPnt)\n");
	}

	~SizedPoint() {
		printf("~SizedPoint()\n");
		printf("%d %d rad = %d\n", x, y, radius);
	}

	int getRadius() const {
		return radius;
	}

	void set(int _x = 0, int _y = 0, int _radius = 1) {
		Point::set(_x, _y);
		radius = _radius;
	}

	void set(const Point& pnt) {
		x = pnt.getX();
		y = pnt.getY();
	}

	void setRadius(int _radius) {
		radius = _radius;
	}
};

class Section {
protected:
	Point* pntBeg;
	Point* pntEnd;

public:
	Section() : pntBeg(new Point()), pntEnd(new Point(1)) {
		printf("Section()\n");
	}
	
	Section(int x1, int y1, int x2 = 0, int y2 = 0) : pntBeg(new Point(x1, y1)), pntEnd(new Point(x2, y2)) {
		printf("Section(int x1, int y1, int x2, int y2)\n");
	}
	
	Section(const Point& _pntBeg, const Point& _pntEnd) : pntBeg(new Point(_pntBeg)), pntEnd(new Point(_pntEnd)) {
		printf("Section(const Point& pntBeg, const Point& pntEnd)\n");
	}

	Section(const Section& sctn) : pntBeg(new Point(*sctn.pntBeg)), pntEnd(new Point(*sctn.pntEnd)) { //Deep copy
		printf("Section(const Section& sctn)\n");
	}

	~Section() {
		printf("~Section()\n");
		delete pntBeg;
		delete pntEnd;
	}

	Point getBeginPoint() const {
		return *(new Point(*pntBeg));
	}

	Point getEndPoint() const {
		return *(new Point(*pntEnd));
	}

	void setBeginPoint(int x = 0, int y = 0) {
		pntBeg->set(x, y);
	}

	void setEndPoint(int x = 0, int y = 0) {
		pntEnd->set(x, y);
	}
};

class Triangle {
protected:
	Point pnt1, pnt2, pnt3;

public:
	Triangle() : pnt1(), pnt2(1), pnt3(0, 1) {
		printf("Triangle()\n");
	}

	Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : pnt1(x1, y1), pnt2(x2, y2), pnt3(x3, y3) {
		printf("Triangle(int x1, int y1, int x2, int y2, int x3, int y3)\n");
	}

	Triangle(const Point& _pnt1, const Point& _pnt2, const Point& _pnt3) : pnt1(_pnt1), pnt2(_pnt2), pnt3(_pnt3) {
		printf("Triangle(const Point& pnt1, const Point& pnt2, const Point& _pnt3)\n");
	}

	Triangle(const Triangle& trngl) : pnt1(trngl.pnt1), pnt2(trngl.pnt2), pnt3(trngl.pnt3) {
		printf("Triangle(const Triangle& trngl)\n");
	}

	~Triangle() {
		printf("~Triangle()\n");
	}

	Point getPoint1() const {
		return pnt1;
	}

	Point getPoint2() const {
		return pnt2;
	}

	Point getPoint3() const {
		return pnt3;
	}
};

int main() {
	setlocale(LC_ALL, "");

	int choosedTest = 0;
	while (choosedTest != 6) {
		printf("Выберите номер теста:\n");
		printf("\t1.Конструкторы и деструкторы в базовом и дочернем классах\n");
		printf("\t2.Помещение в объект-указатель на базовый класс адрес объекта дочернего класса\n");
		printf("\t3.Композиционный класс(без указателей)\n");
		printf("\t4.Композиционный класс(с указателями, глубокое копирование)\n");
		printf("\t5.Завершение программы\n");

		scanf_s("%d", &choosedTest);
		switch (choosedTest) {
		case 1: {
			Point p1(5, 5);
			Point* p2 = new Point(p1);
			delete p2;
			SizedPoint sp1(p1, 5);
			p1.set();
			SizedPoint* sp2 = new SizedPoint(sp1);
			sp1.setRadius(10);

			delete sp2;
			break;
			//"delete" sp1 -> p1
		}
		case 2: {
			Point* p1 = new SizedPoint(9);
			printf("x: %d y: %d\n", p1->getX(), p1->getY());

			delete p1;
			break;
			//Possible memory leak (no call ~SizedPoint())
		}
		case 3: {
			Triangle* tr1 = new Triangle();
			tr1->getPoint3();
			delete tr1;
			printf("\n");

			Point p1(2, 3);
			Point p2(3, 4);
			SizedPoint sp1(5, 6, 10);
			Triangle tr2(p1, p2, sp1);

			break;
			//"delete" tr2 -> sp1 -> p2 -> p1
		}
		case 4: {
			Point p1(5, 6);
			Point p2;
			Section* s1 = new Section(p1, p2);
			Section* s2 = new Section(*s1);
			delete s1;
			delete s2;
			break;
			//"delete" p2 -> p1
		}
		default:
			continue;
		}
		printf("\n");
	}

	printf("Завершение программы\n\n");

	return 0;
}
