using UnityEngine;

public class Feel : MonoBehaviour
{
    private GameManager Gm { get; set; }

    private void Start()
    {
        Gm = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("GameObject"))
        {
            Gm.SetLabel(hitInfo.name);
        }
    }

    private void OnTriggerExit2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("GameObject"))
        {
            Gm.SetLabel("");
        }
    }
}
