#include "SelectionSort.h"
#include "Lista.h"
#include <string>

/* Metodo SelectionSort */
lista SelectionSort::SortPokedex(lista array, int length)
{
    int actualIndex = 0;
    while (actualIndex < length)
    {
        int minValueIndex = actualIndex;
        //Buscar el menor valor
        for (int i = actualIndex; i < length; i++)
        {
            //Comparar si el valor es menor
            if (array.BuscarValor(i).pokedex < array.BuscarValor(minValueIndex).pokedex)
            {
                //Conservar el indice del nuevo valor menor
                minValueIndex = i;
            }
        }
        //Mover valor al inicio
        array.Intercambiar(actualIndex, minValueIndex);
        actualIndex++;
    }

    return array;
}

/* Metodo SelectionSort */
lista SelectionSort::SortGeneration(lista array, int length)
{
    int actualIndex = 0;
    while (actualIndex < length)
    {
        int minValueIndex = actualIndex;

        //Buscar el menor valor de nombre
        for (int i = actualIndex; i < length; i++)
        {
            Pokemon p1 = array.BuscarValor(i);
            Pokemon p2 = array.BuscarValor(minValueIndex);

            if ((p1.generacion <= p2.generacion) &&
                (p1.nombre <= p2.nombre || p1.generacion != p2.generacion))
            {
                //Conservar el indice del nuevo valor menor
                minValueIndex = i;
            }
        }
        //Mover valor al inicio
        array.Intercambiar(actualIndex, minValueIndex);
        actualIndex++;
    }

    return array;
}