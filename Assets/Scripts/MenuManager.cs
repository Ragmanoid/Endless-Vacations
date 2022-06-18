using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button Continue;
    public Button NewGame;
    public Button Exit;

    void Start()
    {
        Continue.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Floor");
        });
        NewGame.onClick.AddListener(() =>
        {
            PlayerPrefs.SetString("LastScene", "newGame");
            SceneManager.LoadScene("Floor");
        });
        Exit.onClick.AddListener(Application.Quit);
    }
    

    // Update is called once per frame
    void Update()
    {
    }
}
