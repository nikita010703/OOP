using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Save_and_Load;
using Factory;
using System.IO;

namespace Container {
    public interface Iterator<T> {
        void first();
        void last();
        void next();
        void previous();
        int getPosition();
        T getCurrentObject();
        void setCurrentObject(T value);
        bool isEOL();
    }

    internal class ContainerIterator<T> : Iterator<T> where T : ISaveable{
        internal int pos;
        internal Container<T> container;
        internal Container<T>.ListNode curNode;

        public ContainerIterator(Container<T> _container) {
            container = _container;
            first();
        }

        public void first() {
            if (container != null && container.head != null)
                curNode = container.head;
            else
                curNode = null;

            pos = 0;
        }

        public void last() {
            if (container != null && container.tail != null)
                curNode = container.tail;
            else
                curNode = null;

            pos = container.Count - 1;
        }

        public void next() {
            if (curNode != null) {
                curNode = curNode.next;
                ++pos;
            }
        }

        public void previous() {
            if (curNode != null && curNode.prev != null)
                curNode = curNode.prev;
            --pos;
        }

        public int getPosition() {
            return pos;
        }

        public bool isEOL() {
            return curNode == null;
        }

        public T getCurrentObject() {
            if (curNode != null)
                return curNode.data;
            return default(T);
        }

        public void setCurrentObject(T value) {
            if (curNode != null)
                curNode.data = value;
        }
    }

    internal class ReverseContainerIterator<T> : Iterator<T> where T : ISaveable {
        internal int pos;
        internal Container<T> container;
        internal Container<T>.ListNode curNode;

        public ReverseContainerIterator(Container<T> _container) {
            container = _container;
            first();
        }

        public void first() {
            if (container != null && container.tail != null)
                curNode = container.tail;
            else
                curNode = null;

            pos = container.Count - 1;
        }

        public void last() {
            if (container != null && container.head != null)
                curNode = container.head;
            else
                curNode = null;

            pos = 0;
        }

        public void next() {
            if (curNode != null) {
                curNode = curNode.prev;
                --pos;
            }
        }

        public void previous() {
            if (curNode != null && curNode.next != null)
                curNode = curNode.next;
            ++pos;
        }

        public int getPosition() {
            return pos;
        }

        public bool isEOL() {
            return curNode == null;
        }

        public T getCurrentObject() {
            if (curNode != null)
                return curNode.data;
            return default(T);
        }

        public void setCurrentObject(T value) {
            if (curNode != null)
                curNode.data = value;
        }
    }

    public class Container<T> where T : ISaveable {
        internal class ListNode {
            public T data { get; internal set; }
            public ListNode prev { get; internal set; }
            public ListNode next { get; internal set; }
            public ListNode(T _data) {
                data = _data;
                prev = null;
                next = null;
            }
        }

        internal ListNode head { get; private set; }
        internal ListNode tail { get; private set; }
        internal int Count { get; private set; }

        public Container() {
            head = null;
            tail = null;
            Count = 0;
        }

        internal ListNode getNodeAt(int index) {
            if (index >= Count - 1)
                return tail;
            else if (index < 1)
                return head;
            else {
                int curPos = 0;
                ListNode curNode = head;
                while (curPos != index) {
                    curNode = curNode.next;
                    ++curPos;
                }
                return curNode;
            }
        }

        public void pushBack(T data) {
            ListNode node = new ListNode(data);

            if (tail == null)
                head = node;
            else {
                tail.next = node;
                node.prev = tail;
            }
            tail = node;
            Count++;
        }

        public void pushFront(T data) {
            ListNode node = new ListNode(data);

            if (head == null)
                tail = node;
            else {
                head.prev = node;
                node.next = head;
            }
            head = node;
            Count++;
        }

        public void insertAfter(T value, int index) {
            if (head == null) {
                head = tail = new ListNode(value);

                ++Count;
            }
            else {
                ListNode curNode = getNodeAt(index);

                if (curNode == tail) pushBack(value);
                else {
                    ListNode elem = new ListNode(value);
                    elem.next = curNode.next;
                    elem.prev = curNode;

                    if (curNode.next != null)
                        curNode.next.prev = elem;
                    curNode.next = elem;

                    ++Count;
                }
            }
        }

        public T popBack() {
            if (tail != null) {
                T tmp = tail.data;
                if (tail.prev != null) {
                    tail = tail.prev;
                    tail.next = null;
                }
                else
                    head = tail = null;

                --Count;
                return tmp;
            }
            return default(T);
        }

        public T popFront() {
            if (head != null) {
                T tmp = head.data;
                if (head.next != null) {
                    head = head.next;
                    head.prev = null;
                }
                else
                    head = tail = null;

                --Count;
                return tmp;
            }
            return default(T);
        }

        public void removeAt(int index) {
            if (Count == 0)
                return;

            if (index < 0 || index >= Count)
                return;

            if (Count == 1)
                head = tail = null;
            else {
                ListNode curNode = getNodeAt(index);
                if (curNode == head) {
                    head = head.next;
                    if (head != null)
                        head.prev = null;
                }
                else if (curNode == tail) {
                    tail = tail.prev;
                    if (tail != null)
                        tail.next = null;
                }
                else {
                    if (curNode.prev != null)
                        curNode.prev.next = curNode.next;
                    if (curNode.next != null)
                        curNode.next.prev = curNode.prev;
                }
            }
            --Count;
        }

        public void Clear() {
            head = null; tail = null;
            Count = 0;
        }

        private int Size { get { return Count; } }
        private bool isEmpty { get { return Count == 0; } }

        public Iterator<T> createIterator() {
            return new ContainerIterator<T>(this);
        }

        public Iterator<T> createReverseIterator() {
            return new ReverseContainerIterator<T>(this);
        }

        public void SaveElements(string filename) {
            StreamWriter file = new StreamWriter(filename);
            //file.WriteLine("Figures");
            file.WriteLine(head.data.GetType().ToString().Split('.')[0]);
            file.WriteLine(Count.ToString());

            Iterator<T> iter = createIterator();
            for (iter.first(); !iter.isEOL(); iter.next())
                iter.getCurrentObject().Save(file);

            file.Close();
        }

        public bool LoadElements(string filename, Factory<T> factory) {
            StreamReader file = new StreamReader(filename);

            string type = file.ReadLine();
            if (type != factory.CreatedObjectsType()) {
                file.Close();
                return false;
            }

            Clear();

            int numOfElems = Int32.Parse(file.ReadLine());
            for (int i = 0; i < numOfElems; ++i) {
                T elem = factory.CreateObject(file.ReadLine());
                elem.Load(file);
                pushBack(elem);
            }
            file.Close();
            return true;
        }
    }
}
