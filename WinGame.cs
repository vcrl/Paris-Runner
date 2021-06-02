using UnityEngine;

public class WinGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().name == "Player")
        {
            FindObjectOfType<GameManager>().GameOverWin();
        }
    }
}
