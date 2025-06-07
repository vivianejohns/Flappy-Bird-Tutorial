using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManagerScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // only count up when collision is with butterfly and not a different gameobject
        if (collision.gameObject.layer == LayerMask.NameToLayer("Butterfly"))
        {
            logic.addScore(1);
        }
    }
}
