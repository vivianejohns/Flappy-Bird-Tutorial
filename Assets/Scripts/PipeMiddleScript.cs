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
        // nur hochzählen, wenn die pipe middle auch tatsächlihc mit dem schmetterling collidet ist und nicht mit einem anderen gameObject
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
