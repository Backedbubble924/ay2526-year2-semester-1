using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPlayerCollideEndGame : MonoBehaviour
{

    public string Scene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //endgame - TODO: implement game over logic
            Debug.Log("Game Over.");
            SceneManager.LoadScene(Scene);

        }
    }
}
