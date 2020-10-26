#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <string>

#include <ctime>

#include <fstream>


using namespace std;

 

void escribeArchivo()
{
    ofstream miArchivo;
    miArchivo.open("example.txt", std::ios::app);//esto debe de declararse al inicio de la aplicacion


    string cadena = "ejemplo de cadena";
    int num = 1000;
    bool e = true;

    //ejemplo de lineas a colocar.
    miArchivo << "escribe mensaje directo al archivo.\n";

    //escribe un string to archivo
    miArchivo << cadena << "\n";
    

    //escribe un entero a archivo
    miArchivo << to_string(num)<<"\n";
    
    miArchivo << to_string(e)<<"\n";
    
    miArchivo.close();//esto debe de ponerse al finalizar la aplicacion.

}