using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  public Transform player;
  public Text scoreText;
  public Text highScoreText;
  public PlayerMovement movement;

  private float highScore;
  private bool finalScoreSet = false;


  /// Start is called on the frame when a script is enabled just before
  /// any of the Update methods is called the first time.

  void Start()
  {
    SetText();
  }

  // Update is called once per frame
  void Update()
  {

    if (movement.enabled == true)
    {
      scoreText.text = player.position.z.ToString("0");
    }

    else if (movement.enabled == false && finalScoreSet != true)
    {
      SetScores(player.position.z);
      finalScoreSet = true;
    }
  }

  public void SetScores(float score)
  {
    scoreText.text = score.ToString("0");

    if (score > highScore)
    {
      PlayerPrefs.SetFloat("High Score", score);
    }
  }

  public void SetText(){
    highScore = PlayerPrefs.GetFloat("High Score");
    highScoreText.text = highScore.ToString("0");
  }
}
