// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int años = 3;
double AuSueldoJefe = 0;
double AuSueldoGerente = 0;
double AuSueldoEmpleado = 0;
double SueldoGerente;
double SueldoJefe;
double SueldoEmpleado;

SueldoGerente = 100;
SueldoJefe = 100;
SueldoEmpleado = 100;

for (int i = 1; i <= años; i++)
{

    if (i % 3 == 0)
    {   
        AuSueldoGerente = 1.18;
        SueldoGerente *= AuSueldoGerente;
        AuSueldoJefe = 1.10;
        SueldoJefe *= AuSueldoJefe;
        AuSueldoEmpleado = 1.6;
        SueldoEmpleado *= AuSueldoEmpleado;
    }
    else
    {
        AuSueldoGerente = 1.14;
        SueldoGerente *= AuSueldoGerente;
        AuSueldoJefe = 1.8;
        SueldoJefe *= AuSueldoJefe;
        AuSueldoEmpleado = 1.3;
        SueldoEmpleado *= AuSueldoEmpleado;
    }
}
Console.WriteLine(SueldoGerente);
Console.WriteLine(SueldoJefe);
Console.WriteLine(SueldoEmpleado);
