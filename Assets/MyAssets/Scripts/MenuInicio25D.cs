using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio25D : MonoBehaviour
{
    public GameObject menuHall;
    public GameObject menuConfirmarSalida;
    public GameObject menuVolver;

    private void Start()
    {
        menuHall = transform.GetChild(0).gameObject;
        menuConfirmarSalida = transform.GetChild(1).gameObject;
        menuVolver = transform.GetChild(0).gameObject;

        if (WinCon.winCon == true)
        {
            menuVolver.SetActive(true);
            menuHall.SetActive(false);
            menuConfirmarSalida.SetActive(false);
        } else
        {
            menuVolver.SetActive(false);
            menuHall.SetActive(true);
            menuConfirmarSalida.SetActive(false);
        }



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
        menuVolver.SetActive(false);

    }

    public void ConfirmarSalida()
    {
        Application.Quit();
    }

    public void CancelarSalida()
    {
        menuHall.SetActive(true);
        menuConfirmarSalida.SetActive(false);
        menuVolver.SetActive(false);
    }

    public void WinCondition()
    {
        menuHall.SetActive(false);
        menuConfirmarSalida.SetActive(false);
        menuVolver.SetActive(true);
    }
}
