#pragma once

template <class T>
class Container { //��������� �� ������ ����������� ������
private:
	class ListNode { //�����, ���������� �� ���� ������
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
	 
	ListNode* getNodeAt(int pos) { // �����, ������������ ���� �� �������
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

	void pushBack(T& elem) { //���������� �������� � ����� ����������
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

	void pushFront(T& elem) { //���������� �������� � ������ ����������
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

	void insert(T& elem) { //���������� �������� � ������� ������� "���������"
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

	void insert(T& elem, int pos) { //���������� �������� �� �������
		curPos = pos;
		insert(elem);
	}

	void popFront() { //�������� �������� �� ������ ����������
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

	void popBack() { //�������� �������� �� ����� ����������
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

	void remove() { //�������� �������� �� ������� ������� "���������"
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

	void remove(int pos) { //�������� �������� �� �������
		curPos = pos;
		remove();
	}

	T& getObject() { //��������� ��������� �� ������� ����������
		ListNode* curNode = getNodeAt(curPos);
		return curNode->object;
	}

	void next() { //������� � ���������� ����
		curPos += curPos == curSize ? 0 : 1;
	}

	void previous() { //������� � ����������� ����
		curPos -= curPos == -1 ? 0 : 1;
	}

	int currentPosition() const { //������� ������� ������� "���������" � ������
		return curPos;
	}

	void begin() { //����������� "���������" � ������ ������
		curPos = 0;
	}

	bool beginOfContainer() const { //��������� �� "��������" � ������ ������
		return curPos == -1;
	}

	void end() { //����������� "���������" � ����� ������
		curPos = curSize - 1;
	}

	bool endOfContainer() const { //��������� �� "��������" � ����� ������
		return curPos == curSize;
	}

	int size() const { //������ ����������
		return curSize;
	}

	bool isEmpty() const { //���� �� ���������
		return curSize == 0;
	}
};
