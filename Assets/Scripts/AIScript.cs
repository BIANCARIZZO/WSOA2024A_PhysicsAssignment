using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    public float MaxMovementSpeed;
    private Rigidbody2D rigidBody;
    private Vector2 startPosition;

    public Rigidbody2D Puck;

    public Transform PlayerBoundries;
    private Boundry playerBoundry;

    public Transform PuckBoundries;
    private Boundry puckBoundry;

    private Vector2 targetPosition;

    private bool FirstInOpponentsHalf = true;
    private float offsetX;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        startPosition = rigidBody.position;

        playerBoundry = new Boundry(PlayerBoundries.GetChild(0).position.y,
                                    PlayerBoundries.GetChild(1).position.y,
                                    PlayerBoundries.GetChild(2).position.x,
                                    PlayerBoundries.GetChild(3).position.x);

        puckBoundry = new Boundry(PuckBoundries.GetChild(0).position.y,
                                    PuckBoundries.GetChild(1).position.y,
                                    PuckBoundries.GetChild(2).position.x,
                                    PuckBoundries.GetChild(3).position.x);
    }

    private void FixedUpdate()
    {
            float movementSpeed;

            if (Puck.position.y < puckBoundry.Down)
            {
                if (FirstInOpponentsHalf)
                {
                    FirstInOpponentsHalf = false;
                    offsetX = Random.Range(-1f, 1f);
                }

                movementSpeed = MaxMovementSpeed * Random.Range(0.1f, 0.3f);
                targetPosition = new Vector2(Mathf.Clamp(Puck.position.x + offsetX, playerBoundry.Left,
                                                          playerBoundry.Right),
                                             startPosition.y);
            }
            else
            {
                FirstInOpponentsHalf = true;

                movementSpeed = Random.Range(MaxMovementSpeed * 0.4f, MaxMovementSpeed);
                targetPosition = new Vector2(Mathf.Clamp(Puck.position.x, playerBoundry.Left,
                                                          playerBoundry.Right),
                                             Mathf.Clamp(Puck.position.y, playerBoundry.Down,
                                                          playerBoundry.Up));

                rigidBody.MovePosition(Vector2.MoveTowards(rigidBody.position, targetPosition, movementSpeed * Time.fixedDeltaTime));
            }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
