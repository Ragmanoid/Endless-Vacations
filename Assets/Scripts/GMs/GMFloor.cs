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
            case "holl":
                star.Transform.position = new Vector3(12.77F, -1.86F, 0);
                break;
            case "toilet":
                star.Transform.position = new Vector3(-4.42F, -1.86F, 0);
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
                        Sentences = new[]
                        {
                            new Sentence
                            {
                                name = "Стар",
                                text = "Странный куст!..."
                            },
                            new Sentence
                            {
                                name = "Стар",
                                text = "Надеюсь он не кусается"
                            }
                        }
                    });
                    break;
                case "Зеркало":
                    Gm.Dm.StartDialogue(new Dialogue
                    {
                        Sentences = new[]
                        {
                            new Sentence
                            {
                                name = "Стар",
                                text = "Я сногшибателен!"
                            }
                        }
                    });
                    break;
                case "Комната девочек":
                    Gm.Dm.StartDialogue(new Dialogue
                    {
                        Sentences = new[]
                        {
                            new Sentence
                            {
                                name = "Стар",
                                text = "Я думаю туда не стоит заходить.."
                            }
                        }
                    });
                    break;
                case "Туалет":
                    SceneManager.LoadScene("Toilet");
                    break;
                case "Холл":
                    SceneManager.LoadScene("Holl");
                    break;
                case "Выход":
                    SceneManager.LoadScene("Menu");
                    break;
                case "Комната мальчиков":
                    SceneManager.LoadScene("Room_Boy");
                    break;
            }
        }
    }
}