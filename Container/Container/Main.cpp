#include <iostream>
#include "Container.h"

int main() {
	Container<int> c;
	for (int i = 0; i < 5; i++)
		c.pushBack(new int(i));

	c.remove(4);
	c.print();
	c.previous();
	c.previous();
	c.remove();
	c.next();
	c.remove();
	//c.remove(2);
	//c.remove(2);
	c.print();
}