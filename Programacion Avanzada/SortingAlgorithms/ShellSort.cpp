#include "ShellSort.h"

void ShellSort::sort(int array[], int arrayLength) 
{
    int tmp = 0;
 
    //Se inicia con una gran desplazamiento, pero se va reduciendo en cada iteracion
    int desplazamiento = (arrayLength / 2);

    while (desplazamiento > 0)
    {
        bool intercambiado = true;

        //Recorrer array hasta lograr hacer un intercambio
        while (intercambiado)
        {
            intercambiado = false;

            int i = 1;
            while (i <= (arrayLength - desplazamiento))
            {
                if (array[i - 1] > array[(i - 1) + desplazamiento])
                {
                    //Efectuar intercambiado de valores
                    tmp = array[(i - 1) + desplazamiento];
                    array[(i - 1) + desplazamiento] = array[i - 1];
                    array[(i - 1)] = tmp;

                    intercambiado = true;
                }
                i++;
            }
        }
        //Dividir en dos el espacio para comparar
        desplazamiento /=  2;
    }
};