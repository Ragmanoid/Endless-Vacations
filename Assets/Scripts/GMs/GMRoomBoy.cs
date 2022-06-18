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
                        Sentences = new[]
                        {
                            new Sentence
                            {
                                name = "Стар",
                                text = "О, а это похоже моя тумба"
                            }
                        }
                    });
                    break;
                case "Бейн":
                    Gm.Dm.StartDialogue(new Dialogue
                    {
                        Sentences = new[]
                        {
                            new Sentence
                            {
                                name = "Стар",
                                text = "Привет! Меня зовут Стар."
                            },
                            new Sentence
                            {
                                name = "Бейн",
                                text = "Хелоу! Я Бейн."
                            },
                            new Sentence
                            {
                                name = "Бейн",
                                text = "И ты меня бесишь. ВОН ОТ СЮДОГОГА!"
                            },
                            new Sentence
                            {
                                name = "Стар",
                                text = "Ну ладно..."
                            }
                        }
                    });
                    break;
            }
        }
    }
}