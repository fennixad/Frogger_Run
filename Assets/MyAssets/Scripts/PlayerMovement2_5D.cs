using TMPro;
using UnityEngine;

public class PlayerMovement2_5D : MonoBehaviour
{
    private float velocidadMovimiento; 
    private Rigidbody rb;
    private float movimientoHorizontal;
    private Quaternion rotacionObjetivo;
    public float suavizadoRotacion;
    public float velocidadBase;
    public float fuerzaSalto;
    private bool tocoSuelo = true;
    public float velocidadSprint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rotacionObjetivo = transform.rotation;
    }

    private void Update()
    {
        InputMovement();
        Salto();
        Aceleracion();
    }


    private void FixedUpdate()
    {
        Movement();
        GiroPersonaje();
    }

    void InputMovement()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal");
    }
    void Movement()
    {
            Vector3 velocidadDeseada = new Vector3(movimientoHorizontal * velocidadMovimiento, rb.linearVelocity.y, 0f);
            rb.linearVelocity = velocidadDeseada;
    }
    void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tocoSuelo)
        {
            // Restablecemos la velocidad vertical antes de saltar
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);

            // Aplicamos la fuerza del salto
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);

            tocoSuelo = false;
        }
    }
    void Aceleracion()
    {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidadMovimiento = velocidadSprint;
        } else
        {
            velocidadMovimiento = velocidadBase;
        }
    }

    void GiroPersonaje()
    {
        if (movimientoHorizontal != 0)
        {
            rotacionObjetivo = Quaternion.LookRotation(new Vector3(movimientoHorizontal, 0f, 0f));

            transform.rotation = Quaternion.Slerp(transform.rotation, rotacionObjetivo, Time.deltaTime * suavizadoRotacion);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("suelo"))
         {
             tocoSuelo = true;
         }
    }

}
