using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorNiveles : MonoBehaviour
{
    public int nivelesC = 2; 
    public static ContadorNiveles Instance;
    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetNivelesC(int i){
        nivelesC=i;
    }
    public int GetNivelesC(){
        return nivelesC;
    }

}