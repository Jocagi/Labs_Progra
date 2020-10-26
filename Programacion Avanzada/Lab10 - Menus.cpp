void irSubMenu()
{
    int x = 1;
    while (x != 0)
    {
        cout << "0 salir\n 1 submenu\n";
        cin >> x;


    }
}

int main()
{

//este seria el ejemplo de menu principal
    int x = 1;
    while (x != 0)
    {
        cout << "0 salir\n 1 submenu\n 2 otra cosa\n";
        cin >> x;
        if (x == 1)
            irSubMenu();

    }
    
    return 0;
}