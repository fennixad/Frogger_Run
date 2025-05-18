using UnityEngine;

public class CambioBallista : MonoBehaviour
{
    public GameObject ballistaOk;
    public GameObject ballistaKo;
    public Vector3 ballistaPosicion;
    void Start()
    {
        ballistaPosicion = ballistaOk.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ballista"))
        {
            Debug.Log("Contacto: " + other.gameObject.name);
            ballistaOk.SetActive(false);
            Instantiate(ballistaKo, ballistaPosicion, Quaternion.identity);
        }
    }
}
