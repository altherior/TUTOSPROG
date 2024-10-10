#include<iostream>
using namespace std;

int main(){

    //Declaración e inicialización de variables.
    string Name = "Ángel";
    short Age {48};
    float Cash = 0;

    //Solicitud al usuario de los daatos necesarios
    cout << "Introduzca el salario del empleado: ";
    cin >> Cash;
    
    cout << "Datos del empleado: " << endl;
    cout << "Nombre: " << Name << endl;
    cout << "Edad: " << Age << endl;
    cout << "Salario: " << Cash;

    return 0;

}