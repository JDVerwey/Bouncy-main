using UnityEngine;

public class TowerBullet : MonoBehaviour
{
    //Fields
    [SerializeField]
    float speed = 0;
    int damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get forward
        Vector3 forwards = transform.forward;
        //Never use float first
        Vector3 direction = forwards * speed;
        //Take our direction speed and actually move it forwards
        transform.position += direction * Time.deltaTime;
    }
}
