using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 inputVector = Vector2.zero; // Initialize our input vector
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up; 
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down; 
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right; 
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left; 
        }

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane);
        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputXZPlane);
    }
}
