using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float montoAConvertir;
    public string codigoMoneda;
    float montoConvertido;
    float montoMinimo = 1000;
    float cotizacionMonedaElegida;
    float cotizacionDolar = 1075.57f;
    float cotizacionEuro = 1179.44f;
    float cotizacionReal = 183; 


    // Start is called before the first frame upda te
    void Start()
    {

       if (montoAConvertir < montoMinimo)
        {
            Debug.Log("El monto minimo es $1000");
            return;
        }

        if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = 1179.44f;
        }
        else if (codigoMoneda == "R")
        {
            cotizacionMonedaElegida = 183f;
        }
        else if (codigoMoneda == "D")
        {
            cotizacionMonedaElegida = 1075.57f; 
        }
        else
        {
            Debug.Log("Opcion de moneda extrajera no valida");
            return;
        }

        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        Debug.Log(montoConvertido = montoAConvertir / cotizacionMonedaElegida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
