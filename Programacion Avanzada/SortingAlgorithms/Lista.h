#pragma once

#include <iostream>
#include <algorithm>

using namespace std;

struct nodo
{
	nodo* siguiente;
	int valor;

	nodo();
	~nodo();
};

struct lista
{
	public:
		nodo* cabeza;

		void Insertar(int valor);
		void Eliminar(int posicion);
		void Intercambiar(int posicion1, int posicion2);

		void MostrarElementos();
		void MostrarCantidad();
		void BuscarValor(int busqueda);

		lista();
		~lista();
};

nodo::nodo()
{
	this->siguiente = NULL;
}

nodo::~nodo()
{
}

lista::lista()
{
	cabeza = NULL;
}

lista::~lista()
{
}

void lista::Insertar(int valor)
{
	//Se crea nodo a ingresar a la lista
	nodo* tmp = new nodo;
	tmp->valor = valor;

	//Validar si hay nodos en la lista
	if (cabeza == NULL) 
	{
		cabeza = tmp;
	}
	else
	{
		//Nodo anterior
		nodo* tmp2 = cabeza; 

		//Recorrer lista
		while (tmp2 != NULL)
		{
			if (tmp2->siguiente == NULL)
			{
				tmp2->siguiente = tmp;
				break;
			}
			else
			{
				//Siguient posicion en la lista
				tmp2 = tmp2->siguiente; 
			}
		}
	}
}

void lista::Eliminar(int posicion)
{
	//Se crea nodo a ingresar a la lista
	nodo* tmp = new nodo;
	int i = 0;

	if (cabeza == NULL) //Validar si hay nodos en la lista
	{
		cout << "La lista está vacía" << endl;
	}
	else
	{
		//Recorrer lista

		nodo* anterior = NULL;
		nodo* actual = cabeza;

		while (actual != NULL)
		{
			if (i == posicion)
			{
				anterior->siguiente = actual->siguiente;

				break;
			}
			else
			{
				//Siguiente posicion en la lista
				anterior = actual;
				actual = actual->siguiente;

				if (actual == NULL)
				{
					cout << "La posición ingresada está fuera de rango";
				}
				i++;
			}
		}
	}
}

void lista::MostrarElementos()
{
	cout << "\nElementos:" << endl;

	if (cabeza == NULL) //Validar si hay nodos en la lista
	{
		cout << "\nLa lista está vacía" << endl;
	}
	else
	{
		//Recorrer lista

		nodo* actual = cabeza;

		while (actual != NULL)
		{
			cout << "->" << actual->valor << " ";

			//Siguiente posicion en la lista
			actual = actual->siguiente;
		}

		cout << endl;
	}
}

void lista::MostrarCantidad()
{
	cout << "\nCantidad Elementos: ";

	if (cabeza == NULL) //Validar si hay nodos en la lista
	{
		cout << "\nLa lista está vacía" << endl;
	}
	else
	{
		//Recorrer lista
		nodo* actual = cabeza;
		int i = 0;

		while (actual != NULL)
		{
			//Siguiente posicion en la lista
			actual = actual->siguiente;
			i++;
		}

		cout << i << endl;
	}
}

void lista::BuscarValor(int busqueda)
{
	nodo* tmp = cabeza;
	int posicion = 0;

	if (tmp == NULL)
	{
		cout << "\nLa lista está vacía\n" << endl;
	}
	else
	{
		//Mientras aun existan elementos en la lista a recorrer 
		while (tmp != NULL) 
		{
			if (tmp->valor == busqueda)
			{
				cout << "\nEl numero se encuentra en la posicion: ";
				cout << posicion << endl;
				break;
			}
			else
			{
				tmp = tmp->siguiente;
				posicion++;
				if (tmp == NULL)
				{
					cout << "\nEl numero no fue encontrado...\n";
					break;
				}
			}
		}
	}
}

void lista::Intercambiar(int posicion1, int posicion2)
{
	//Validar si hay nodos en la lista
	if (cabeza == NULL) 
	{
		cout << "\nLa lista esta vacia...\n";
	}
	else
	{
		//Recorrer lista para encontrar el nodo en posicion 1
		nodo* P1 = NULL;
		nodo* anteriorP1 = NULL;
		
		//Recorrer lista para encontrar el nodo en posicion 2
		nodo* P2 = NULL;
		nodo* anteriorP2 = NULL;

		//Nodo actual
		nodo* actual = cabeza;
		int i = 0;

		while (actual != NULL)
		{
			if (i == posicion1)
			{
				//Guardar
				P1 = actual;
			}
			else if (i == posicion2)
			{
				//Guardar
				P2 = actual;
			}
			else
			{
				if (actual == NULL && (P1 == NULL || P2 == NULL))
				{
					cout << "\nUna de las posiciones ingresadas está fuera de rango\n" << endl;
				}
			}

			//Siguiente posicion en la lista
			if (P1 == NULL) anteriorP1 = actual;
			if (P2 == NULL) anteriorP2 = actual;
			actual = actual->siguiente;
			i++;
		}

		//Realizar intercambio
		if (P1 != NULL && P2 != NULL)
		{
			nodo* tmp = P2->siguiente;

			if (anteriorP1 != NULL)
			{
				if (anteriorP1 != P2)
				{
					anteriorP1->siguiente = P2;
				}
			}
			else
			{
				cabeza = P2;
			}

			if (anteriorP2 != NULL)
			{
				if (anteriorP2 != P1)
				{
					P2->siguiente = P1->siguiente;
					anteriorP2->siguiente = P1;
				}
				else 
				{
					P1->siguiente = P2->siguiente;
					P2->siguiente = P1;
				}
			}
			else
			{
				cabeza = P1;
			}

			P1->siguiente = tmp;
		}
	}
}

