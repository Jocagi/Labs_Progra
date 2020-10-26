#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <string>

#include <ctime>

#include <fstream>

using namespace std;


class Padre//super clase
{
public:
    int padreInt;
protected:
    int padreProtegido;
private:
    int padrePrivado;

};


class Madre//super clase
{
public:
    int madreInt;
protected:
    int madreProtegido;
private:
    int madrePrivado;

};

class Hijo:Padre,Madre//sub clase
{
public: //modifier
    int hijoInt;
protected://modifier
    int hijoProtegido;
private://modifier
    int hijoPrivado;

public:
    void metodoPublico()
    {
        hijoProtegido = 100;
        hijoPrivado = 10;
        padreProtegido = 400;
        madreProtegido = 500;
    }


    //ejemplo polimorfismo: sobrecarga de opradores /polimorfismo
    void sobreCarga()
    {
        cout << "esto es una sobre carga parte 1";
    }

    void sobreCarga(int opcion)
    {
        switch (opcion)
        {
        case 1:
            cout << "esto es una sobre carga parte 1";
            break;
        case 2:
            cout << " esto lo hace mas interesante";
            break;
        default:
            cout << " para cubrir opciones no estimadas";
            break;
        }
    }

    void sobreCarga(string opcion)
    {
        cout << opcion;
    }
    //fin sobre carga de operadores /polimorfismo

    Hijo() { cout << "esto es el constructor\n"; }//constructor se ejecuta al principio
    ~Hijo() { cout << "esto es el destructor\n"; }//destructor se ejecuta al final


};

class nodo {
public:
    int x;
};

int main()
{
    Hijo h;
    Padre p;
    return 0;
}