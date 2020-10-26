#include "SelectionSort.h"

/* Intercambiar dos elementos  */
void SelectionSort::intercambio(int* a, int* b)
{
    int tmp = *a;
    *a = *b;
    *b = tmp;
}

/* Metodo SelectionSort */
void SelectionSort::sort(int array[], int arrayLength)
{
    int actualIndex = 0;

    while (actualIndex < arrayLength)
    {
        int minValueIndex = actualIndex;

        //Buscar el menor valor
        for (int i = actualIndex; i < arrayLength; i++)
        {
            //Comparar si el valor es menor
            if (array[i] < array[minValueIndex])
            {
                //Conservar el indice del nuevo valor menor
                minValueIndex = i;
            }
        }
        //Mover valor al inicio
        intercambio(&array[minValueIndex], &array[actualIndex]);

        actualIndex++;
    }
}