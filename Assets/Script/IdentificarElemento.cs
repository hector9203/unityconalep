using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using System;



public class IdentificarElemento : MonoBehaviour
{
	//se declara variable privada y de manera global para que pueda usarse en toda la clase
	private string tagLeido="";
    public string tb = "";

    //PARAMETROS QUE SE RECIBEN DE OBJETOS EN LA INTERFAZ: SON DOS TEXTMESHPRO UNO PARA TITULO Y OTRO PARA DESCRIPCION
    public GameObject texto;
	public GameObject textoDescripcion;

    void Start ()
    {

    }
	
    void Update()
    {
		
        // Get the Vuforia StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager ();

        // Query the StateManager to retrieve the list of
        // currently 'active' trackables 
        //(i.e. the ones currently being tracked by Vuforia)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();

       // Iterate through the list of active trackables
        Debug.Log ("List of trackables currently active (tracked): ");
        foreach (TrackableBehaviour tb in activeTrackables) {
            
			//MOSTRAR EN CONSOLA UN TAG LEIDO
			Debug.Log("Trackable: " + tb.TrackableName);
			//ASIGNAR EL TAG A LA VARIABLE GOBAL
			tagLeido=tb.TrackableName;
        }
		
		//SI EL TAG LEIDO ES ASTRONAUTA
		if(tagLeido=="CuerpoHumano")
		{
            //ESCRIBIR EN CAJAS DE TEXTO
            texto.GetComponent<TMPro.TextMeshProUGUI>().text = "Cuerpo Humano";
            textoDescripcion.GetComponent<TMPro.TextMeshProUGUI>().text = "El puerqui de los humanos tiene muchas cositas como carnita y huesitos";
		}

        if (tagLeido == "Corazon")
        {
            //ESCRIBIR EN CAJAS DE TEXTO
            texto.GetComponent<TMPro.TextMeshProUGUI>().text = "Corazón";
            textoDescripcion.GetComponent<TMPro.TextMeshProUGUI>().text = "El corazón es un órgano del tamaño aproximado de un puño. Está compuesto de tejido muscular y bombea sangre a todo el cuerpo. ";
        }
        //SI EL TAG LEIDO ES CORAZON
        if (tagLeido=="")
		{
			//ESCRIBIR EN CAJAS DE TEXTO
			textoDescripcion.GetComponent<TMPro.TextMeshProUGUI>().text = "";
            texto.GetComponent<TMPro.TextMeshProUGUI>().text = "Busca un Target";
        }

    }
    
}
