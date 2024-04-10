using UnityEngine;
//using LeanTweenFramework;

public class MenuController : MonoBehaviour
{
    public RectTransform MainMenu;
    public RectTransform RegisterMenu;
    public RectTransform LoginMenu;
    public RectTransform Main;
    public RectTransform AboutProjectMenu;

    private RectTransform currentMenu;

    void Start()
    {
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 1;

        RegisterMenu.anchoredPosition = new Vector2(-Screen.width, 0);
        LoginMenu.anchoredPosition = new Vector2(-Screen.width, 0);
        Main.anchoredPosition = new Vector2(-Screen.width, 0);
        AboutProjectMenu.anchoredPosition = new Vector2(-Screen.width, 0);

        currentMenu = MainMenu;
        ShowMainMenu();
    }

    private void SetActiveMenu(RectTransform newMenu)
    {
        // Сначала показываем новое меню
        if (currentMenu != null && currentMenu != newMenu)
        {
            LeanTween.moveX(newMenu, 0, 0.15f).setOnComplete(() =>
            {
                    // Затем скрываем старое меню
                    LeanTween.moveX(currentMenu, -Screen.width, 0.15f);
                    // Обновляем текущее меню
                    currentMenu = newMenu;
            });
        }
    }

    public void OpenRegisterMenu()
    {
        SetActiveMenu(RegisterMenu);
    }   

    public void ShowMainMenu()
    {
        SetActiveMenu(MainMenu);
    }

    public void ShowLoginMenu()
    {
        SetActiveMenu(LoginMenu);
    }

    public void ShowMain()
    {
        SetActiveMenu(Main);
    }

    public void ShowAboutProjectMenu()
    {
        SetActiveMenu(AboutProjectMenu);
    }
}
