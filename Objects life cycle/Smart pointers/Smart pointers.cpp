#include <iostream>

class Point {
private:
    int x, y;
public:
    Point() : x(0), y(0) {};
    Point(int _x, int _y) : x(_x), y(_y) {};
    Point(const Point& p) : x(p.x), y(p.y) {};
    
    void draw() {
        std::cout << x << ' ' << y << '\n';
    }
    void move(int dx, int dy) {
        x += dx; y += dy;
    }
};

std::unique_ptr<Point> print(std::unique_ptr<Point> p) {
    p->draw();
    return p;
}

void print(std::shared_ptr<Point> p) {
    p->draw();
}

void print(Point* p) {
    p->draw();
}

int main() {
    std::unique_ptr<Point> up = std::make_unique<Point>(1, 2);
    up = print(move(up));
    print(up.get());

    std::shared_ptr<Point> sp1 = std::make_shared<Point>(3, 4);
    std::shared_ptr<Point> sp2 = sp1;
    print(sp2);
    sp2->move(1, 1);
    print(sp1);
}