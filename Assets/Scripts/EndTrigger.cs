using UnityEngine;

public class EndTrigger : MonoBehaviour
{
  public GameManager gameManager;
  public PlayerMovement movement;

  void OnTriggerEnter()
  {
    if (movement.enabled == true)
    {
      gameManager.CompleteLevel();
    }
    else
    {
      gameManager.EndGame();
    }
  }
}
