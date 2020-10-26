#include "ShellSort.h"

lista ShellSort::SortPokedex(lista array, int length)
{
    int tmp = 0;

    //Se inicia con una gran desplazamiento, pero se va reduciendo en cada iteracion
    int desplazamiento = (length / 2);

    while (desplazamiento > 0)
    {
        bool intercambiado = true;

        //Recorrer array hasta lograr hacer un intercambio
        while (intercambiado)
        {
            intercambiado = false;

            int i = 1;
            while (i <= (length - desplazamiento))
            {
                if (array.BuscarValor(i - 1).pokedex > 
                            array.BuscarValor((i - 1) + desplazamiento).pokedex)
                {
                    //Efectuar intercambiado de valores
                    array.Intercambiar((i - 1) , ((i - 1) + desplazamiento));
                    intercambiado = true;
                }
                i++;
            }
        }
        //Dividir en dos el espacio para comparar
        desplazamiento /= 2;
    }

    return array;
};

lista ShellSort::SortGeneration(lista array, int length)
{
    int tmp = 0;

    //Se inicia con una gran desplazamiento, pero se va reduciendo en cada iteracion
    int desplazamiento = (length / 2);

    while (desplazamiento > 0)
    {
        bool intercambiado = true;

        //Recorrer array hasta lograr hacer un intercambio
        while (intercambiado)
        {
            intercambiado = false;

            int i = 1;
            while (i <= (length - desplazamiento))
            {
                Pokemon p1 = array.BuscarValor(i - 1);
                Pokemon p2 = array.BuscarValor((i - 1) + desplazamiento);

                if ((p1.generacion >= p2.generacion)
                    && (p1.nombre > p2.nombre || p1.generacion != p2.generacion))
                {
                    //Efectuar intercambiado de valores
                    array.Intercambiar((i - 1), ((i - 1) + desplazamiento));
                    intercambiado = true;
                }
                i++;
            }
        }
        //Dividir en dos el espacio para comparar
        desplazamiento /= 2;
    }

    return array;
};