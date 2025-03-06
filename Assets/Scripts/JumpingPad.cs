using UnityEngine;

public class JumpingPad : MonoBehaviour
{
    //Global variables
    [SerializeField]
    private float upRoar = 45;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + "collided");
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, upRoar, 0), ForceMode.Impulse);
    }
}
