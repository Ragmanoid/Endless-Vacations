using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMToilet : MonoBehaviour
{
    private GameManager Gm { get; set; }

    void Start()
    {
        Gm = FindObjectOfType<GameManager>();
        PlayerPrefs.SetString("LastScene", "toilet");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (Gm.MainLabel.text)
            {
                case "Полотенце":
                    Gm.Dm.StartDialogue(new Dialogue
                    {
                        Sentences = new[]
                        {
                            new Sentence
                            {
                                name = "Стар",
                                text = "Кто-то оставил тут полотенце..."
                            }
                        }
                    });
                    break;
                case "Мэй":
                    Gm.Dm.StartDialogue(new Dialogue
                    {
                        Sentences = new[]
                        {
                            new Sentence
                            {
                                name = "Стар",
                                text = "Йоу... ты это как так?!"
                            },
                            new Sentence
                            {
                                name = "Мэй",
                                text = "А вот так. Я призрак. Хи-хи"
                            },
                            new Sentence
                            {
                                name = "Стар",
                                text = "Прикольно. Ну я это самое. Пошёл"
                            },
                            new Sentence
                            {
                                name = "Мэй",
                                text = "Окс, ну ты давай там, до связи"
                            }
                        }
                    });
                    break;
                case "Коридор":
                    SceneManager.LoadScene("Floor");
                    break;
            }
        }
    }
}