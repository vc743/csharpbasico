﻿// La clase EmpleadoPorComision que extiende a Empleado.
public class EmpleadoPorComision : Empleado
{
    private decimal ventasBrutas; // ventas semanales totales
    private decimal tarifaComision; // porcentaje de comisión
    
    // constructor con cinco parámetros
    public EmpleadoPorComision(string nombre, string apellido, string nss,
        decimal ventas, decimal tarifa) : base(nombre, apellido, nss)
    {
        VentasBrutas = ventas; // valida las ventas brutas a través de una propiedad
        TarifaComision = tarifa; // valida la tarifa de comisión a través de una propiedad
    }
    
    // propiedad que obtiene y establece la tarifa de comisión del empleado por comisión
    public decimal TarifaComision
    {
        get
        {
            return tarifaComision;
        } // fin de get
        set
        {
            tarifaComision = (value > 0 && value < 1) ?
            value : 0; // validación
        }
    }
    
    // propiedad que obtiene y establece las ventas brutas del empleado por comisión
    public decimal VentasBrutas
    {
        get
        {
            return ventasBrutas;
        }
        set
        {
            ventasBrutas = (value >= 0) ? value : 0; // validación
        }
    }
    
    // calcula los ingresos; redefine el método abstracto Ingresos en Empleado
    public override decimal Ingresos()
    {
        return TarifaComision * VentasBrutas;
    }
    
    // devuelve representación string del objeto EmpleadoPorComision
    public override string ToString()
    {
        return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}",
        "empleado por comisión", base.ToString(),
        "ventas brutas", VentasBrutas, "tarifa de comisión", TarifaComision);
    }
}