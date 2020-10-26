// SortingAlgorithms.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "Quicksort.h"
#include "SelectionSort.h"
#include "ShellSort.h"
#include "Lista.h"

#include <chrono>  
#include <fstream>
#include <vector>
#include <string>
#include <sstream>

void read_csv();

int main()
{
    Quicksort sort;
    std::cout << "Hello World!\n";

    int arrayLength = 8;
    int array[] = {2,3,1,4,9,7,8,0};
    
    //Read csv
    read_csv();

        // start time
        auto start = std::chrono::high_resolution_clock::now();
    // Sort
    sort.sort(array, arrayLength);
        // Record end time
        auto finish = std::chrono::high_resolution_clock::now();

    // Print result
    for (int i = 0; i < arrayLength; i++)
    {
        std::cout << array[i] << " ";
    }

    // Print time
    std::chrono::duration<double> elapsed = finish - start;
    std::cout <<" \nTiempo: " << elapsed.count()*1000 << " milisegundos";


    //Lista
    lista p;

    for (int i = 0; i < 18; i++)
    {
        p.Insertar(i);
    }

    p.MostrarCantidad();  p.MostrarElementos();

    p.Intercambiar(2, 3); p.MostrarCantidad();  p.MostrarElementos();
    p.Intercambiar(2, 4); p.MostrarCantidad();  p.MostrarElementos();
    p.Intercambiar(0, 17); p.MostrarCantidad();  p.MostrarElementos();
    p.Intercambiar(15, 16); p.MostrarCantidad();  p.MostrarElementos();


    //Lista
    lista f;
   
    f.Insertar(509);
    f.Insertar(665);
    f.Insertar(292);
    f.MostrarElementos();

    f.Intercambiar(0, 2); f.MostrarElementos();
    f.Intercambiar(1, 2); f.MostrarElementos();

}

void read_csv()
{
    // File pointer 
    std::fstream fin;

    // Open an existing file 
    fin.open("C:\\Users\\user\\Desktop\\pokemondata.txt", std::ios::in);

    // Get the roll number of which the data is required 
    int rollnum = 4, roll2 = -1, roll3 = -1, count = 0, rowCount = 0;

    // Read the Data from the file as String Vector 
    std::vector<std::string> row;
    std::string line, word, temp;

    while (fin >> temp) 
    {
        row.clear();

        // used for breaking words 
        std::stringstream s(temp);

        // read every column data of a row and store it in a string variable, 'word' 
        while (getline(s, word, ','))
        {
            // add all the column data of a row to a vector 
            row.push_back(word);
        }

        if (rowCount > 0)
        {
            // convert string to integer for comparision 
            roll2 = stoi(row[0]);
            roll3 = stoi(row[2]);

            // Print the found data 
            count = 1;
            std::cout << "Pokedex: " << row[0] << " Name: " << row[1] << " Generation: " << row[2] << "\n";
        }

        rowCount++;
    }
    if (count == 0) 
    {
        std::cout << "Record not found\n";
    }
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
