using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ControladorTime : MonoBehaviour
{
    [SerializeField] private float tiempoMaximo;
    [SerializeField] private float tiempoIra;
    [SerializeField]private Slider slider;
    private float tiempoActual;
    private bool tiempoActivado = false;

    private void Start()
    {
        ActivarTemporizador();
    }
    private void Update()
    {
        if (tiempoActivado)
        {
            CambiarContador();
        }
    }

    private void CambiarContador()
    {
        tiempoActual -= Time.deltaTime;

        if (tiempoActual >= 0) { 
            slider.value = tiempoActual;
        }

        if (tiempoActual <= 0) {
            CambiarTemporizador(false);
            Ira();
            Invoke(nameof(ActivarTemporizador), tiempoIra);
        }
    }
    public void Ira()
    {
        Debug.Log("IRA ON, ESCONDETE!");
        CinemachineMovimientoCamara.Instance.MoverCamara(5, 5, tiempoIra);

        if (ArbustosSafe.Instance == null)
        {
            PlayerRespawn.Instance.PlayerDamaged();
        }
        else
        {
            if (ArbustosSafe.Instance.estadoPlayer) //player dead
            {
                PlayerRespawn.Instance.PlayerDamaged();
            }
        }
    }

    private void CambiarTemporizador(bool estado)
    {
        tiempoActivado = estado;
    }

    public void ActivarTemporizador()
    {
        tiempoActual = tiempoMaximo;
        slider.maxValue = tiempoMaximo;
        CambiarTemporizador(true);
    }
    public void DesactivarTemporizador()
    {
        CambiarTemporizador(false);
    }
}
