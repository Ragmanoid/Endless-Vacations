using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMHoll : MonoBehaviour
{
    private GameManager Gm { get; set; }
    
    void Start()
    {
        Gm = FindObjectOfType<GameManager>();
        PlayerPrefs.SetString("LastScene", "holl");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (Gm.MainLabel.text)
            {
                case "Коридор":
                    SceneManager.LoadScene("Floor");
                    break;
            }
        }
    }
}