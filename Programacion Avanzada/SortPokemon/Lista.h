#pragma once

#include <iostream>
#include <algorithm>
#include <string>
#include <msclr\marshal_cppstd.h>
#include "Pokemon.h"

struct nodo
{
	nodo* siguiente;
	Pokemon valor;

	nodo();
	~nodo();
};

struct lista
{
public:
	nodo* cabeza;

	void Insertar(Pokemon valor);
	void Eliminar(int posicion);
	void Intercambiar(int posicion1, int posicion2);

	void MostrarElementos();
	std::string Elementos();
	int Cantidad();
	Pokemon BuscarValor(int indice);

	lista();
	~lista();
};