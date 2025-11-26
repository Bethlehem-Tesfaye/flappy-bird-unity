using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public float JumpForce = 10f;
    public logicScript logic;
    public bool isAlive = true;
    public float topBound = 14.6f;
    public float bottomBound = -14.6f;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
            MyRigidBody.linearVelocity = Vector2.up * JumpForce;

        if (transform.position.y > topBound || transform.position.y < bottomBound)
        {
            logic.gameOver();
            isAlive = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;

    }
}
