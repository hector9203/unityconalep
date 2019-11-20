using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using System;

public class ClickButton : MonoBehaviour
{

    public Button elBoton;
    public GameObject miPanel;


    // Start is called before the first frame update
    [Obsolete]
    void Start()
    {
        elBoton.onClick.AddListener(TaskOnClick); //agregando el evento al boton (inicia tarea al dar click al botón)
    }

    [Obsolete]
    public void TaskOnClick() 
    {
        if (elBoton.name == "btnEntrar") //cuando se haga click en el boton con ese nombre va a hacer lo siguiente
        {
            //ABRIR UNA NUEVA ECSENA
            //Application.LoadLevel(Application.loadedLevel);						
           Application.LoadLevel("escenaOrganos");
        }
        if (elBoton.name == "btnEntrar")
        {
            //CERRAR APLICACIÓN
            Debug.Log("SALIR");
            Application.Quit();
        }
        if (elBoton.name == "btnDetalle")
        {
            miPanel.SetActive(true);
        }
        if (elBoton.name == "btnCerrar")
        {
            miPanel.SetActive(false);
        }
        if (elBoton.name == "btncierra")
        {
            Debug.Log("Si entraaaa");
        }


        //g Heart_low:Group4898
        /*
		if(yourButton.name=="btnEsqueleto")
		{
			
			if(objEsqueleto.activeSelf==false)
			{  		
				objEsqueleto.SetActive(true);
			}
			else
			{
				objEsqueleto.SetActive(false);
			}
		}
		if(yourButton.name=="btnOrganos")
		{
			if(objOrganos.activeSelf==false)
			{  		
				objOrganos.SetActive(true);
			}
			else
			{
				objOrganos.SetActive(false);
			}    		
		}*/

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
