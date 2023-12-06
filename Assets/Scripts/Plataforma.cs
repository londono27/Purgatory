using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject miObjeto;

    public void Awake()
    {
        miObjeto = GetComponent<GameObject>();
    }

    public void SetUpLocation(float location){

        Transform objetoTransform = miObjeto.transform;

            // Modificar la posición en el eje Y
            objetoTransform .position = new Vector3(objetoTransform .position.x, location, objetoTransform .position.z);
    }
}
