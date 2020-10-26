// ConsoleApplication1.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"

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
persona *anterior;
} ;


persona *inicio, *fin;

void inicializar()
{
inicio = NULL;
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

void push2(string nombre, string apellido)
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
inicio->sig = tmp;
inicio = tmp;
}
}

 

void mostrar()
{
persona *tmp = fin;
while (tmp)
{
cout << tmp->nombre << "\n";
tmp = tmp->sig;
}
}


int main()
{
push2("nombre1", "apellido1");
push2("nombre2", "apellido2");
push2("nombre3", "apellido3");
mostrar();
getchar();

}