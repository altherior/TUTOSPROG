/**********************************/
/*     EJERCICIO PRÁCTICO 1.      */
/* CALCULO DEL PRECIO POR CALIDAD */
/*     DE LA TARIMA FLOTANTE      */
/******************************** */
#include<iostream>
using namespace std;

int main(){

    //Declaración de variables
    short MetrosMedia = 0;
    short MetrosAlta = 0;
    float TotalMedia = 0;
    float TotalAlta = 0;
    float Total = 0;

    //Declaración de constantes
    float PrecioMedia = 35.5;
    float PrecioAlta = 55.3;
    short IVA = 1.21;
    short Validez = 30;

    //Pregunta al usuario cuantos metros quiere de cada tipo.
    cout << "Bienvenido al sistema del presupuesto de tarima flotante.";
    cout << "Introduzca los metro de media calidad: " ;
    cin >> MetrosMedia;
    cout << "Introduzca los metros de alta calidad: ";
    cin >> MetrosAlta;
    
    //Calculo de los precios
    TotalMedia = MetrosMedia * PrecioMedia;
    TotalAlta = MetrosAlta * PrecioAlta;
    Total = TotalAlta + TotalMedia;

    //Presentación por consola de los precios y durabilidad del presupuesto.
    cout << "El precio de la tarima de calidad media es de: ";
    cout << TotalMedia << endl;
    cout << "El p recio de la tarima de calidad superior es de: ";
    cout << TotalAlta << endl;
    cout << "El presupuesto total para la instalación de la tarima es de: ";
    cout << Total << endl;

    cout << "El prepupuesto será válido durante los próximos días a partir de la emisión del mismo.";

}

