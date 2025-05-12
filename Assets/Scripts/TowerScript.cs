using UnityEngine;

public class TowerScript : MonoBehaviour
{
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
        Debug.Log("We have collided");
    }
    public void OnDeadlyCollision()
    {
        //Tower destroy itself on collision
        Destroy(this.gameObject);
    }
}
