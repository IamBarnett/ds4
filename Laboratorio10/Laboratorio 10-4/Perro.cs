using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_10_4
{
    internal class Perro
    {
    }
}
public class Perro
    Public nombre As String
    Public raza As String
    Public altura As String

    Public Function comer(carne As String) As String
        return nombre + "mide " + altura + " y comerá " + carne
    End Function
    Public Sub dormir()

    End Sub
    Public Sub ladrar()

    End Sub
    Public Function calcularCosto(costo As Double, impuesto As Double) As Double
        Dim preciototal As Double
        preciototal = costo + (costo * impuesto)
        return preciototal
    End Function

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub
End Class