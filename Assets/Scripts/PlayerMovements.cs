using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, 1000 * Time.deltaTime);
 
        if (Input.GetKey("a"))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        } 
        if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
    }
}
