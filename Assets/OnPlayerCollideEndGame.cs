using UnityEngine;

public class OnPlayerCollideEndGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //endgame - TODO: implement game over logic
            Debug.Log("Game Over.");
            
        }
    }
}
