using UnityEngine;

public class FrogInteractions : MonoBehaviour
{

    #region 1) Variables
    Vector3 posicionInicial;
    #endregion

    #region 2) Funciones Unity
    private void Start()
    {
        posicionInicial = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstaculos"))
        {

        }
        if (other.CompareTag("WinCondition"))
        {

        }
    }
    #endregion

    #region 3) Funciones Propias
    void RegresoInicio()
    {
        transform.position = posicionInicial;
    }
    #endregion
}
