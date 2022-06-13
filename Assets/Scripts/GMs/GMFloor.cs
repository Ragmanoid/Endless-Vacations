using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMFloor : MonoBehaviour
{
    private GameManager Gm { get; set; }
    private string lastScene = "";

    void Start()
    {
        lastScene = PlayerPrefs.GetString("LastScene");
        Gm = FindObjectOfType<GameManager>();
        SetPlayerPosition();
    }

    private void SetPlayerPosition()
    {
        var star = FindObjectOfType<Star>();
        switch (lastScene)
        {
            case "roomBoy":
                star.Transform.position = new Vector3(-21.87F, -1.86F, 0);
                break;
        }
        PlayerPrefs.SetString("LastScene", "floor");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (Gm.MainLabel.text)
            {
                case "Куст":
                    Gm.Dm.StartDialogue(new Dialogue
                    {
                        name = "Стар",
                        sentences = new[]
                        {
                            "Странный куст!...",
                            "Надеюсь он не кусается"
                        }
                    });
                    break;
                case "Зеркало":
                    Gm.Dm.StartDialogue(new Dialogue
                    {
                        name = "Стар",
                        sentences = new[]
                        {
                            "Я сногшибателен!"
                        }
                    });
                    break;
                case "Комната девочек":
                    Gm.Dm.StartDialogue(new Dialogue
                    {
                        name = "Стар",
                        sentences = new[]
                        {
                            "Я думаю туда не стоит заходить.."
                        }
                    });
                    break;
                case "Комната мальчиков":
                    SceneManager.LoadScene("Room_Boy");
                    break;
            }
        }
    }
}