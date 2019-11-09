using UnityEngine;

public class PlayerMovemnt : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpate()
    {
        rb.AddForce(0, 0, 200 *Time.deltaTime);
    }
        
}
