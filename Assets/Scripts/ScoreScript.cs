using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace scoring
{
public class ScoreScript : MonoBehaviour
{
    //[SerializeField] private PuckScript puskScript;

    public int playerScore_Scene;
    public int AIScore_Scene;
    public enum Score
    {
        AiScore, PlayerScore
    }

    public TextMeshProUGUI AiScoreText, PlayerScoreText;

    public UIManagerScript uiManager;

    public int ScoreMax;
  
    public int aiScore, playerScore;

    private int AiScore
    {
        get
        {
            return aiScore;
        }
        set
        {
            aiScore = value;
            if (value == ScoreMax)
            {

            }
                
        }
    }

    private int PlayerScore
    {
        get
        {
            return playerScore;
        }
        set
        {
            playerScore = value;
            if (value == ScoreMax)
            {

            }
               
        }
    }

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore)
            AiScoreText.text = (++AiScore).ToString();
        else
            PlayerScoreText.text = (++PlayerScore).ToString();
    }

    public void ResetScores()
    {
        AiScore = PlayerScore = 0;
        AiScoreText = PlayerScoreText; 
    }

    void Awake()
    {
    }

    public void checkScores(int pScore, int AIScoreS)
    {
            playerScore_Scene = pScore;
            AIScore_Scene = AIScoreS;
        
        if (AIScore_Scene == 5)
        {
            SceneManager.LoadScene("LooseScene");
        }

        else if (playerScore_Scene == 5)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
}
