class persona {
public:
    string nombre;
    persona *sig;
    persona *ant;
};


persona  *inicio, *fin;


void inicializar()
{
    inicio = NULL;
    fin = NULL;
}


void push(string nombre )
{
    persona *tmp = //TODO  crear una nueva persona
    tmp->nombre = nombre;
    tmp->sig = NULL;
    tmp->ant = NULL;

    if (inicio == NULL)
    {
        inicio = fin = tmp;
    }
    else
    {
        tmp->sig = //TODO completar codigo de apuntadores;
        inicio->ant = //TODO completar codigo de apuntadores
        inicio = tmp;
    }
}


void mostrarAB()
{
    persona *tmp = //TODO apuntar a inicio o fin

    while (tmp)
    {
        cout << tmp->nombre << "\n";
        tmp = tmp->//TODO completar codigo de apuntadores;
    }
}


void mostrarBA()
{
    persona *tmp = //TODO apuntar a inicio o fin;
    while (tmp)
    {
        cout << tmp->nombre << "\n";
        tmp = tmp->//TODO completar codigo de apuntadores;
    }
}

int main()
{
    inicializar();
    push("1");
    push("2" );
    push("3");
    push("4");
    mostrarAB();//orden ascendente salida 1,2,3,4
    getchar();
    mostrarBA();//orden descendente salida 4,3,2,1
    getchar();
    return 0;
}