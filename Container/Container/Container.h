#pragma once

template <class T>
class Container { //Контейнер на основе двусвязного списка
private:
	class ListNode { //Класс, отвечающий за узлы списка
	public:
		T object;
		ListNode* prev;
		ListNode* next;

		ListNode(T& newElem) {
			object = newElem;
			prev = next = nullptr;
		}

		~ListNode() {
			prev = next = nullptr;
			delete object;
		}
	};

	int curSize, curPos;
	ListNode* head;
	ListNode* tail;
	 
	ListNode* getNodeAt(int pos) { // Метод, возвращающий узел по индексу
		if (pos >= curSize - 1)
			return tail;
		else if (pos <= 0)
			return head;
		else {
			curPos = 0;
			ListNode* curNode = head;
			while (curPos != pos) {
				curNode = curNode->next;
				curPos++;
			}
			return curNode;
		}
	}

public:
	Container() {
		head = nullptr;
		tail = nullptr;
		curSize = curPos = 0;
	}

	~Container() {
		if (isEmpty()) {
			head = tail = nullptr;
			return;
		}

		ListNode* curNode = head;
		while (curSize > 1) {
			curNode = curNode->next;
			curSize--;
			delete curNode->prev;
		}
		head = tail = nullptr;
		delete curNode;
	}

	void pushBack(T& elem) { //Добавление элемента в конец контейнера
		if (curSize > 0) {
			ListNode* newNode = new ListNode(elem);
			tail->next = newNode;
			newNode->prev = tail;
			tail = newNode;
		}
		else {
			head = tail = new ListNode(elem);
			head->next = tail;
			tail->prev = head;
		}
		curPos = curSize++;
	}

	void pushFront(T& elem) { //Добавление элемента в начало контейнера
		if (curSize > 0) {
			ListNode* newNode = new ListNode(elem);
			head->prev = newNode;
			newNode->next = head;
			head = newNode;
		}
		else {
			head = tail = new ListNode(elem);
			head->next = tail;
			tail->prev = head;
		}
		curPos = 0;
		curSize++;
	}

	void insert(T& elem) { //Добавление элемента в текущюю позицию "итератора"
		ListNode* curNode = getNodeAt(curPos);
		if (curNode == tail)
			pushBack(elem);
		else if (curNode == head)
			pushFront(elem);
		else {
			ListNode* nextNode = curNode->next;
			ListNode* insertedNode = new ListNode(elem);
			curNode->next = insertedNode;
			insertedNode->prev = curNode;
			insertedNode->next = nextNode;
			nextNode->prev = insertedNode;
			curPos++;
			curSize++;
		}
	}

	void insert(T& elem, int pos) { //Добавление элемента по индексу
		curPos = pos;
		insert(elem);
	}

	void popFront() { //Удаление элемента из начала контейнера
		if (!isEmpty()) {
			if (curSize != 1) {
				head = head->next;
				delete head->prev;
				head->prev = nullptr;
			}
			else
				delete head;

			curPos = 0;
			curSize--;
		}
	};

	void popBack() { //Удаление элемента из конца контейнера
		if (!isEmpty()) {
			if (curSize != 1) {
				tail = tail->prev;
				delete tail->next;
				tail->next = nullptr;
			}
			else
				delete tail;

			curSize--;
			curPos = curSize - 1;
		}
	}

	void remove() { //Удаление элемента по текущей позиции "итератора"
		if (!isEmpty()) {
			if (size() == 1) {
				delete head;
				head = tail = nullptr;
				curSize--;
				return;
			}

			ListNode* curNode = getNodeAt(curPos);
			if (curNode == tail) {
				tail = tail->prev;
				tail->next = nullptr; 
			}
			else if (curNode == head) {
				head = head->next;
				head->prev = nullptr;
			}
			else {
				ListNode* nextNode = curNode->next;
				ListNode* prevNode = curNode->prev;
				prevNode->next = nextNode;
				nextNode->prev = prevNode;
			}
			curSize--;
			if (curPos == curSize)
				curPos--;
			delete curNode;
		}
	}

	void remove(int pos) { //Удаление элемента по индексу
		curPos = pos;
		remove();
	}

	T& getObject() { //Получение указателя на элемент контейнера
		ListNode* curNode = getNodeAt(curPos);
		return curNode->object;
	}

	void next() { //Переход к следующему узлу
		curPos += curPos == curSize ? 0 : 1;
	}

	void previous() { //Переход к предыдущему узлу
		curPos -= curPos == -1 ? 0 : 1;
	}

	int currentPosition() const { //Возврат текущей позиции "итератора" в списке
		return curPos;
	}

	void begin() { //Перемещение "итератора" к началу списка
		curPos = 0;
	}

	bool beginOfContainer() const { //Находится ли "итератор" в начале списка
		return curPos == -1;
	}

	void end() { //Перемещение "итератора" к концу списка
		curPos = curSize - 1;
	}

	bool endOfContainer() const { //Находится ли "итератор" в конце списка
		return curPos == curSize;
	}

	int size() const { //Размер контейнера
		return curSize;
	}

	bool isEmpty() const { //Пуст ли контейнер
		return curSize == 0;
	}
};
