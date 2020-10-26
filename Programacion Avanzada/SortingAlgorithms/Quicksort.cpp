#include "Quicksort.h"
#include <iostream>

/* Intercambiar dos elementos  */
void Quicksort::intercambio(int* a, int* b)
{
    int tmp = *a;
    *a = *b;
    *b = tmp;
}

/* Se toma un pivote (elemento del medio); 
coloca todos los elementos menores que el pivote 
a la izquierda y los mayores a la derecha*/
int Quicksort::dividir(int array[], int low, int high, int arrayLength)
{
    //Indice del elemento medio
    int mitad = (high - low) / 2 + low;
    //Pivote
    int pivote = array[high];
    //Indice donde insertar
    int insert = (low - 1);

    //Recorrer todo el sub-array y comparar elementos con pivote
    for (int i = low; i <= high - 1; i++)
    {
        // Si el elemento actual es menor que el pivote 
        if (array[i] < pivote)
        {
            insert++;
            //Hacer el intercambio
            intercambio(&array[insert], &array[i]);
        }
    }
    //Hacer el ultimo intercambio
    insert++;
    intercambio(&array[insert], &array[high]);
    //Devolver el tamanio del sub-array izquierdo para la siguiente interacion
    return (insert);
}

void Quicksort::sortArray(int array[], int low, int high, int arrayLength)
{
    if (low >= 0 && high < arrayLength)
    {
        if (low < high)
        {
            int division = dividir(array, low, high, arrayLength);
  
            //Ordenar lado izquierdo
            sortArray(array, low, division - 1, arrayLength);
            //Ordenar lado derecho
            sortArray(array, division + 1, high, arrayLength);
        }
    }
}

/* Metodo QuickSort */
void Quicksort::sort(int array[], int arrayLength)
{
    //Primera llamada a metodo recursivo
    sortArray(array, 0, arrayLength - 1, arrayLength);
}