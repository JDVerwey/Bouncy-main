using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    public bool isReal = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        int temp = Random.Range(0, 2);
        if (temp == 0)
        {
            Debug.Log("Cube exists");
        }
        else
        {
            isReal = false;    
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           int temp =  Random.Range(0,2);
            if (temp == 0)
            {
                Debug.Log("We tried");
                isReal = true;

            }
            else 
            {
                isReal = false;
                Destroy(this.gameObject);
                Debug.Log("Cube died");
            }
        }
    }
}
