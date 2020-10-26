#pragma once

#include <string>
#include "SelectionSort.h"
#include "ShellSort.h"
#include "QuickSort.h"
#include "Lista.h"

class Orden
{
	public:
		//Selection Sort
		lista SS_SortPokedex(lista array);
		lista SS_SortGeneration(lista array);
		//Shell Sort
		lista Sh_SortPokedex(lista array);
		lista Sh_SortGeneration(lista array);
		//Quick Sort
		void Qs_SortPokedex(lista* array);
		void Qs_SortGeneration(lista* array);
};