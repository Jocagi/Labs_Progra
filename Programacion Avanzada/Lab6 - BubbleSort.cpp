
int BubbleSort()
{
    int a[50], n, i, j, temp;
    cout << "tamano de arreglo: ";
    cin >> n;
    

    for (i = 0; i < n; ++i) {
        cout << "ingrese elemento: " << i + 1 << " ";
        cin >> //TODO COMPLETAR
    }
        

    for (i = 1; i < n; ++i)
    {
        for (j = 0; j < (n - i); ++j)
            if (a[j] > a[j + 1])
            {
                temp = //TODO COMPLETAR
                a[j] = //TODO COMPLETAR
                a[j + 1] = //TODO COMPLETAR
            }
    }

    cout << "bubble sort:";
    for //TODO COMPLETAR
        cout << " " << a[i];

    return 0;
}

int Selection()
{
    int i, j, n, loc, temp, min, a[30];
    cout << "ingrese numero de elementos:";
    cin >> n;
    
    for (i = 0; i < n; i++)
    {
        cout << "elemento numero: "<<i+1<<" ";
        cin >> a[i];
    }

    for (i = 0; i < n - 1; i++)
    {
        min = a[i];
        loc = i;
        for (j = i + 1; j < n; j++)
        {
            if (min > a[j])
            {
                min = //TODO COMPLETAR
                loc =//TODO COMPLETAR
            }
        }

        temp = //TODO COMPLETAR
        a[i] = //TODO COMPLETAR
        a[loc] = temp//TODO COMPLETAR
    }

    cout << "Selection \n";
    for (i = 0; i < n; i++)
    {
        cout << a[i] << " ";
    }

    return 0;
}