using UnityEngine;

public class ButterflyScript : MonoBehaviour
{
    public Rigidbody2D butterflyRigidBody;
    public float flapStrength;
    public LogicManagerScript logic;
    public bool butterflyAlive = true;

    void Start()
    {
        GameObject logicObject = GameObject.FindGameObjectWithTag("Logic");
        if (logicObject != null)
        {
            logic = logicObject.GetComponent<LogicManagerScript>();
        }
        if (logic == null)
        {
            Debug.LogError(
                "LogicManagerScript not found! Make sure there's a GameObject tagged 'Logic' with LogicManagerScript component."
            );
        }
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
        if (logic != null)
        {
            logic.GameOver();
            butterflyAlive = false;
        }
    }
}
