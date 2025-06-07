using UnityEngine;

public class ButterflyScript : MonoBehaviour
{
    public Rigidbody2D butterflyRigidBody;
    public float flapStrength;
    public LogicManagerScript logic;
    public bool butterflyAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && butterflyAlive)
        {
            butterflyRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        butterflyAlive = false;
    }
}
