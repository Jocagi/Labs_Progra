#include "QuickSort.h"
#include <iostream>

/* Se toma un pivote (elemento del medio);
coloca todos los elementos menores que el pivote
a la izquierda y los mayores a la derecha*/
int Quicksort::dividirPokedex(lista* array, int low, int high, int length)
{
    //Indice del elemento medio
    int mitad = (high - low) / 2 + low;
    //Pivote
    int pivote = array->BuscarValor(high).pokedex;
    //Indice donde insertar
    int insert = (low - 1);

    //Recorrer todo el sub-array y comparar elementos con pivote
    for (int i = low; i <= high - 1; i++)
    {
        // Si el elemento actual es menor que el pivote 
        if (array->BuscarValor(i).pokedex < pivote)
        {
            insert++;
            //Hacer el intercambio
            if (i < insert)
            {
                array->Intercambiar(i, insert);
            }
            else 
            {
                array->Intercambiar(insert, i);
            }
        }
    }
    //Hacer el ultimo intercambio para colocar al pivote en el medio
    insert++;
    array->Intercambiar(insert, high);
    //Devolver el tamanio del sub-array izquierdo para la siguiente interacion
    return (insert);
}

void Quicksort::sortListPokedex(lista* array, int low, int high, int length)
{
    if (low >= 0 && high < length)
    {
        if (low < high)
        {
            int division = dividirPokedex(array, low, high, length);

            //Ordenar lado izquierdo
            sortListPokedex(array, low, division - 1, length);
            //Ordenar lado derecho
            sortListPokedex(array, division + 1, high, length);
        }
    }
}

/* Metodo QuickSort */
void Quicksort::sortPokedex(lista* array, int length)
{
    //Primera llamada a metodo recursivo
    sortListPokedex(array, 0, length - 1, length);
}



/* Se toma un pivote (elemento del medio);
coloca todos los elementos menores que el pivote
a la izquierda y los mayores a la derecha*/
int Quicksort::dividirGeneracion(lista* array, int low, int high, int length)
{
    //Indice del elemento medio
    int mitad = (high - low) / 2 + low;
    //Pivote
    std::string pivotePokedex = array->BuscarValor(high).nombre;
    int pivoteGen = array->BuscarValor(high).generacion;
    //Indice donde insertar
    int insert = (low - 1);

    //Recorrer todo el sub-array y comparar elementos con pivote
    for (int i = low; i <= high - 1; i++)
    {
        Pokemon valor = array->BuscarValor(i);

        // Si el elemento actual es menor que el pivote 
        if (valor.generacion <= pivoteGen &&
            (valor.nombre <= pivotePokedex || 
            valor.generacion != pivoteGen) )
        {
            insert++;
            //Hacer el intercambio
            if (i < insert)
            {
                array->Intercambiar(i, insert);
            }
            else
            {
                array->Intercambiar(insert, i);
            }
        }
    }
    //Hacer el ultimo intercambio para colocar al pivote en el medio
    insert++;
    array->Intercambiar(insert, high);
    //Devolver el tamanio del sub-array izquierdo para la siguiente interacion
    return (insert);
}

void Quicksort::sortListGeneracion(lista* array, int low, int high, int length)
{
    if (low >= 0 && high < length)
    {
        if (low < high)
        {
            int division = dividirGeneracion(array, low, high, length);

            //Ordenar lado izquierdo
            sortListGeneracion(array, low, division - 1, length);
            //Ordenar lado derecho
            sortListGeneracion(array, division + 1, high, length);
        }
    }
}

/* Metodo QuickSort */
void Quicksort::sortGeneracion(lista* array, int length)
{
    //Primera llamada a metodo recursivo
    sortListGeneracion(array, 0, length - 1, length);
}