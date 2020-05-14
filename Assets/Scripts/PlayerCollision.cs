using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public PlayerMovement movement;
  public Transform player;
  public float deathHeight;

  private void Update()
  {
    if (player.position.y < -deathHeight)
    {
      DisableMovement();
    }
  }

  private void OnCollisionEnter(Collision other)
  {
    if (other.collider.tag == "Obstacle")
    {
      DisableMovement();
    }
  }

  private void DisableMovement()
  {
    movement.enabled = false;
    FindObjectOfType<GameManager>().EndGame();
  }
}
