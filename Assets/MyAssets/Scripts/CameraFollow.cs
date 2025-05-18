using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraFollow : MonoBehaviour
{
    public Transform jugadorAseguir;
    public Vector3 compensacionDistancia;
    public float suavizadoMovimiento;

    void LateUpdate()
    {
        Vector3 posicionCamara = jugadorAseguir.position + compensacionDistancia;
        Vector3 posicionFinal = Vector3.Lerp(transform.position, posicionCamara, suavizadoMovimiento);
        transform.position = posicionFinal;
    }
}
