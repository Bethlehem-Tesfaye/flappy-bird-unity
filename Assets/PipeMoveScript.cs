using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float deadzone = -45f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;

        if(transform.position.x < deadzone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
