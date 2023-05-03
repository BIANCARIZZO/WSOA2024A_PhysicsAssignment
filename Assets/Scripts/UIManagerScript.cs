using UnityEngine;
using UnityEngine.SceneManagement;

namespace scoring
{
public class UIManagerScript : ScoreScript
{
    [Header("Canvas")]
    public GameObject Game;

    [Header("Other")]
    public ScoreScript scoreScript;
    public PuckScript puckScript;
    public PlayerMovement playerMovement;
    public AIScript aiScript;

    

    
}
}

