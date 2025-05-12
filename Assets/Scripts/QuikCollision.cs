using UnityEngine;

public class QuikCollision : MonoBehaviour
{
    //public variables
    [SerializeField]
    TowerScript parent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // parent = GetComponent<TowerScript>();
        parent = GetComponentInParent<TowerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
      
        if(collision.gameObject.GetComponent<BallController>()) 
        { 
           
        }

    }
}
