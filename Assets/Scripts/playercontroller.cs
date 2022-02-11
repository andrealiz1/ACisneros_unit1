using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // rate of forward/backward movement
    private float speed = 20.0f;
    private float turnspeed = 20.0f;

    private float horizontalInput;
    private float verticalinput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");

        Debug.Log(Time.deltaTime);
        // Vector3.forward -- > (0, 0, 1)
        //(0, 0, 1) * Time.deltaTime = (0, 0, .016) * - (0, 0, .16)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalinput);
        // turning vechicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
    }
}
