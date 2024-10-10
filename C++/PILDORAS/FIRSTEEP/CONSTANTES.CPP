    #include<iostream>
    using namespace std;

    int main(){

        //Declaración de variables.
        string Name;
        string Surname;
        short Age;
        //Declaración de constantes.
        const short Cash = 1200;

        cout << "Introduzca su nombre: " << endl;
        cin >> Name;
        cout << "Introduzca sus apellidos: " << endl;
        cin >> Surname;

        cout << "Datos del empleado. ";
        cout << "Nombre: " << Name << endl;
        cout << "Apellidos: " << Surname << endl;
        cout << "Salario: " << Cash;
        return 0;
    }