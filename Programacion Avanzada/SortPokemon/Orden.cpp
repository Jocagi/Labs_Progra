#include "Orden.h"

lista Orden::SS_SortPokedex(lista array) 
{
	SelectionSort ss;
	lista pokemonList = ss.SortPokedex(array, array.Cantidad());
	return pokemonList;
}

lista Orden::SS_SortGeneration(lista array)
{
	SelectionSort ss;
	lista pokemonList = ss.SortGeneration(array, array.Cantidad());
	return pokemonList;
}

lista Orden::Sh_SortPokedex(lista array)
{
	ShellSort sh;
	lista pokemonList = sh.SortPokedex(array, array.Cantidad());
	return pokemonList;
}

lista Orden::Sh_SortGeneration(lista array)
{
	ShellSort sh;
	lista pokemonList = sh.SortGeneration(array, array.Cantidad());
	return pokemonList;
}

void Orden::Qs_SortPokedex(lista* array)
{
	Quicksort q;
	q.sortPokedex(array, array->Cantidad());
}

void Orden::Qs_SortGeneration(lista* array)
{
	Quicksort q;
	q.sortGeneracion(array, array->Cantidad());
}

