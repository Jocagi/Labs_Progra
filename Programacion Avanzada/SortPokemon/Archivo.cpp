#include "Archivo.h"
#include "Lista.h"
#include "Pokemon.h"

#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <sstream>

//"C:\\Users\\user\\Desktop\\pokemondata.txt"

lista Archivo::read_csv(std::string path)
{
    //Declaracion lista
    lista pokemonList;

    // File pointer 
    std::fstream fin;

    // Abrir un archivo
    fin.open(path, std::ios::in);

    int num1 = 0, num2 = 0 , rowCount = 0;

    std::vector<std::string> row;
    std::string line, word, temp;

    while (fin >> temp)
    {
        // Limpiar vector
        row.clear();

        // Usado para dividir palabras
        std::stringstream s(temp);

        // Leer cada columna y guardar la data en 'word' 
        while (getline(s, word, ','))
        {
            // Guardar la info en un vector 
            row.push_back(word);
        }

        if (rowCount >= 0)
        {
            // Convertir string a int
            num1 = stoi(row[0]);
            num2 = stoi(row[2]);

            // Guardar la informacion
            Pokemon nuevo;
            nuevo.pokedex = num1;
            nuevo.nombre = row[1];
            nuevo.generacion = num2;

            pokemonList.Insertar(nuevo);
            std::cout << "Pokedex: " << row[0] << " Name: " << row[1] << " Generation: " << row[2] << "\n";
        }

        rowCount++;
    }
    if (rowCount == 0)
    {
        std::cout << "Error al leer\n";
    }

    return pokemonList;
}
