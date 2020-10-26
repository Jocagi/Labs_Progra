#pragma once
#include "Lista.h"

class Quicksort
{
	private:
		int dividirPokedex(lista* array, int low, int high, int length);
		int dividirGeneracion(lista* array, int low, int high, int length);
		void sortListPokedex(lista* array, int low, int high, int length);
		void sortListGeneracion(lista* array, int low, int high, int length);

	public:
		void sortPokedex(lista* array, int length);
		void sortGeneracion(lista* array, int length);
};

