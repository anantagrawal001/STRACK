
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forw = 800f;
    public float side = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("welcome");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forw * Time.deltaTime, ForceMode.VelocityChange);
        if (Input.GetKey("d"))
        {
            rb.AddForce(side * Time.deltaTime, 0, 0 , ForceMode.VelocityChange );
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        /*if (Input.GetKey("w"))
         {

         }
         if (Input.GetKey("s"))
         {
             rb.AddForce(0, 0, -forw * Time.deltaTime, ForceMode.VelocityChange);
         }*/
      
        if (Input.GetKey("q"))
        {
            rb.AddForce(-(side/2) * Time.deltaTime, 0, (forw/2) * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("e"))
        {
            rb.AddForce((side / 2) * Time.deltaTime, 0, (forw/2) * Time.deltaTime, ForceMode.VelocityChange);
        }


        if (rb.position.y < -1 )
        {
            FindObjectOfType<gamemanager>().EndGame();
          
        }
    }
}
