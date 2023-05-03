using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace scoring
{
public class PuckScript : MonoBehaviour
{
    public TextMeshProUGUI AiScoreText;
    public TextMeshProUGUI PlayerScoreText;
   [SerializeField] private ScoreScript sScript;

    public float SpeedMax;
    private Rigidbody2D rigidBody;

    public int PlayerGoal;
    public int AiGoal;

    // Start is called before the first frame update
    void Start()
    { 

        rigidBody = GetComponent<Rigidbody2D>();

        PlayerGoal = 0;
        PlayerScoreText.text = "Opponent : " + PlayerGoal;

        AiGoal = 0;
        AiScoreText.text = "Player : " + AiGoal;
        
    }


    public void OnCollisionEnter2D(Collision2D other)
    {
       if (other.gameObject.tag == "AIGoal")
       {
            transform.position = new Vector3(0, 0, 0);
            PlayerGoal = PlayerGoal + 1;
            AiScoreText.text = ("Payer :" + PlayerGoal);
                
       }
       else if (other.gameObject.tag == "PlayerGoal")
       {
            transform.position = new Vector3(0, 0, 0);
            AiGoal = AiGoal + 1;
            PlayerScoreText.text = ("Opponent :" + AiGoal);   
       }
        sScript.checkScores(PlayerGoal, AiGoal);
    }
   

    private void FixedUpdate()
    {
        rigidBody.velocity = Vector2.ClampMagnitude(rigidBody.velocity, SpeedMax);
    }
}
}

