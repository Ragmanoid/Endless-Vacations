using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMRoomBoy : MonoBehaviour
{
    private GameManager Gm { get; set; }
    
    void Start()
    {
        Gm = FindObjectOfType<GameManager>();
        PlayerPrefs.SetString("LastScene", "roomBoy");
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
                case "Тумба":
                    Gm.Dm.StartDialogue(new Dialogue
                    {
                        name = "Стар",
                        sentences = new[]
                        {
                            "О, а это похоже моя тумба"
                        }
                    });
                    break;
            }
        }
    }
}