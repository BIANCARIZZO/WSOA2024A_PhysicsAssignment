using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalsPointsAtt : MonoBehaviour
{
    public TextMeshProUGUI AiScoreTxt;
    public TextMeshProUGUI PlayerScoreTxt;

    private int goalPlayer;
    private int goalAI;

    // Start is called before the first frame update
    void Start()
    {
        goalPlayer = 0;
        PlayerScoreTxt.text = "Player: " + goalPlayer;

        goalAI = 0;
        AiScoreTxt.text = "AI: " + goalAI;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "AiGoal")
        {
            transform.position = new Vector3(0, 0, 0);
            goalPlayer = goalPlayer + 1;
            AiScoreTxt.text = ("Payer :" + goalPlayer);
        }
        else if (other.gameObject.tag == "PlayerGoal")
        {
            transform.position = new Vector3(0, 0, 0);
            goalAI = goalAI + 1;
            PlayerScoreTxt.text = ("Opponent :" + goalAI);
        }
    }


        // Update is called once per frame
        void Update()
    {
        
    }
}
