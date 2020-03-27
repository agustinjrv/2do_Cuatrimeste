using Clase_25.Entidades;
using System;

public delegate void LimiteSueldoDelegado(double sueldo, Empleado emp);
public delegate void LimiteSueldoMejorado(Empleado sender, EmpleadoEventArgs e);

public enum TipoManejador {LimiteSuedo,LimiteSueldoMejorado,Todos }