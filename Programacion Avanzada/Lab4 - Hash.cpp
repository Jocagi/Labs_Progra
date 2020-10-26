
//ejemplo ilustrativo para laboratorio

 

#include <iostream>
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <string>

#include <ctime>

#include <fstream>

using namespace std;


class HashEntry {

private:
    int key;
    int value;
public:
    HashEntry(int key, int value)
    {
        this->key = key;
        this->value = value;
    }
    int getKey()
    {
        return key;
    }
    int getValue()
    {
        return value;
    }
       
    void setValue(int value)
    {
        this->value = value;
    }

};

const int TABLE_SIZE = 128;



class HashMap {

private:

    HashEntry **table;

public:
    HashMap()
    {
        table = new HashEntry*[TABLE_SIZE];
        for (int i = 0; i < TABLE_SIZE; i++)
            table[i] = NULL;
    }



    int get(int key)
    {
        int hash = (key % TABLE_SIZE);
        while (table[hash] != NULL && table[hash]->getKey() != key)
            hash = (hash + 1) % TABLE_SIZE;

        if (table[hash] == NULL)
            return -1;
        else
            return table[hash]->getValue();
    }

    void show()
    {
 //TODO a realizar en clase
    }

    void put(int key, int value)
    {
        int hash = (key % TABLE_SIZE);
        while (table[hash] != NULL && table[hash]->getKey() != key)
            hash = (hash + 1) % TABLE_SIZE;
        if (table[hash] != NULL)
            delete table[hash];
        table[hash] = new HashEntry(key, value);
    }


    void put2(int key, int value)
    {

//TODO resolver el problema del put implementado

//que se analizara en lab.

    }


    ~HashMap() {
        for (int i = 0; i < TABLE_SIZE; i++)
            if (table[i] != NULL)
                delete table[i];
        delete[] table;
    }
};



int main()
{
    HashMap h ;


    h.put2(1, 100);
    h.put2(5, 120);//colicion
    h.put2(8, 130);
    h.put2(2, 140);
    h.put2(1, 101);

    //cout<< h.get(5)<<"\n";
    //cout<<h.get(1) << "\n";
    h.show();
    cout << "\n";
    std::cout << "Hello World!\n";
}