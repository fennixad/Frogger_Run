using UnityEngine;
using UnityEngine.SceneManagement; 
public class MenuInicio : MonoBehaviour
{
    public GameObject menuHall;
    public GameObject menuConfirmarSalida;

    private void Start()
    {
        menuHall = transform.GetChild(0).gameObject;
        menuConfirmarSalida = transform.GetChild(1).gameObject;

        menuHall.SetActive(true);
        menuConfirmarSalida.SetActive(false);
    }
    public void Jugar()
    {
        SceneManager.LoadScene(1);
        Debug.Log("A Darle al mambo");
    }

    public void Salir()
    {
        menuHall.SetActive(false);
        menuConfirmarSalida.SetActive(true);
        
    }

    public void ConfirmarSalida()
    {
        Application.Quit();
    }

    public void CancelarSalida()
    {
        menuHall.SetActive(true);
        menuConfirmarSalida.SetActive(false);
    }
}
