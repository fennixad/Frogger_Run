using UnityEngine;

public class PlayerMovement2_5D : MonoBehaviour
{
    [SerializeField]
    private float velocidadMovimiento;
    private Rigidbody rb;
    private float movimientoHorizontal;
    private Quaternion rotacionObjetivo;
    public float suavizadoRotacion;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        velocidadMovimiento = 3f;
        rotacionObjetivo = transform.rotation;
        suavizadoRotacion = 5f;
    }

    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal");

        if (rb != null )
        {
            Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, 0f) * velocidadMovimiento * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + movimiento);

            if (movimientoHorizontal != 0)
            {
                Quaternion rotacionObjetivo = Quaternion.LookRotation(new Vector3(movimientoHorizontal, 0f, 0f));

                transform.rotation = Quaternion.Slerp(transform.rotation, rotacionObjetivo, Time.fixedDeltaTime * suavizadoRotacion);
            }
        }
    }
}
