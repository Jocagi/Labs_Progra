#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <string>



using namespace std;



class persona {
public:
    string nombre;
    string apellido;
    int atendido;
    persona *sig;
} *nodo;


persona  *inicio, *fin;

void inicializar()
{
    inicio =  NULL;
    fin = NULL;
}


void push(string nombre, string apellido)
{
    persona *tmp = new persona();
    tmp->nombre = nombre;
    tmp->apellido = apellido;
    tmp->atendido = 0;
    tmp->sig = NULL;

    if (inicio == NULL)
    {
        inicio = fin = tmp;
    }
    else
    {
        tmp->sig = inicio;
        inicio = tmp;
    }
}


void mostrar()
{
    persona *tmp = inicio;
    while (tmp)
    {
        cout << tmp->nombre << "\n";
        tmp = tmp->sig;
    }
}

/*

TODO 

función pop  y convertir este ejemplo de pila en cola.

 

*/