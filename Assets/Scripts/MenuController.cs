using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject RegisterMenu;
    public GameObject LoginMenu;
    public GameObject Main;
    void Start()
    {
        ShowMainMenu();
    }

    public void OpenRegisterMenu()
    {
        MainMenu.SetActive(false); // This will hide all the elements of MainMenu
        LoginMenu.SetActive(false);
        RegisterMenu.SetActive(true); // This will show all the elements of RegisterMenu
        Main.SetActive(false);
    }
    public void ShowMainMenu()
    {
        MainMenu.SetActive(true); // This will show all the elements of MainMenu
        LoginMenu.SetActive(false);
        RegisterMenu.SetActive(false); // This will hide all the elements of RegisterMenu
        Main.SetActive(false);
    }
    public void ShowLoginMenu()
    {
        MainMenu.SetActive(false); // This will show all the elements of MainMenu
        RegisterMenu.SetActive(false); // This will hide all the elements of RegisterMenu
        LoginMenu.SetActive(true);
        Main.SetActive(false);
    }
    public void ShowMain()
    {
        MainMenu.SetActive(false); // This will show all the elements of MainMenu
        RegisterMenu.SetActive(false); // This will hide all the elements of RegisterMenu
        LoginMenu.SetActive(false);
        Main.SetActive(true);
    }

}
