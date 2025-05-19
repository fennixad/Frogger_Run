using UnityEngine;

public class Torreta : MonoBehaviour
{
    public GameObject flecha;
    public GameObject player;
    public Vector3 posicionFlecha;
    public Vector3 posicionPlayer;
    public float tiempoDisparo;
    AudioSource audioSource;
    public AudioClip sonidoDisparo;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        posicionFlecha = flecha.transform.position;
        posicionPlayer = player.transform.position;
        tiempoDisparo = 2.0f;
    }

    void Update()
    {
        DisparoFlechaAleatorio();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            Debug.Log("golpeo suelo");
            flecha.transform.position = posicionFlecha;
            tiempoDisparo = Random.Range(1.0f, 2.0f);
            audioSource.PlayOneShot(sonidoDisparo);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = posicionPlayer;
            audioSource.PlayOneShot(sonidoDisparo);
        }
    }

    private void DisparoFlechaAleatorio()
    {   
        flecha.transform.Translate(Vector3.left * tiempoDisparo * Time.deltaTime);
    }

   
}
