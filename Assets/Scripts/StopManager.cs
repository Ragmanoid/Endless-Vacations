using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum Pages
{
    Main,
    Menu
}

public class StopManager : MonoBehaviour
{
    public Button Continue;
    public Button Exit;
    public Button Menu;
    public GameObject main;
    public GameObject menu;
    public Pages Page { get; set; }

    private void SetPage(Pages page)
    {
        Debug.Log($"Set page: {page}");

        main.SetActive(false);
        menu.SetActive(false);

        switch (page)
        {
            case Pages.Main:
                main.SetActive(true);
                break;
            case Pages.Menu:
                menu.SetActive(true);
                break;
            default:
                throw new ArgumentException(nameof(page));
        }

        Time.timeScale = page != Pages.Main ? 0 : 1;

        Page = page;
    }

    private void Start()
    {
        SetPage(Pages.Main);
        Menu.onClick.AddListener(() => { SetPage(Pages.Menu); });
        Continue.onClick.AddListener(() => { SetPage(Pages.Main); });
        Exit.onClick.AddListener(() => { SceneManager.LoadScene("Menu"); });
    }
}