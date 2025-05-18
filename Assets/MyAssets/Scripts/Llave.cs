using UnityEngine;

public class Llave : MonoBehaviour
{
    private bool tengoLlave = false;
    [SerializeField] private GameObject keyImage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            other.gameObject.SetActive(false);
            keyImage.SetActive(true);
            tengoLlave=true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Gate") && tengoLlave)
        {
            tengoLlave=false;
            collision.gameObject.SetActive(false);
        }
    }
}
