using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //Global variables
    float maxSize = 10;
    float minSize = 0.1f;
    bool sizing = true; 


    /// <summary>
    /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }
        // Update is called once per frame
        void Update()
        {
        //gameObject.transform.Rotate(new Vector3(-1, 0, 0));
        
        if (sizing == true)
        {
            gameObject.transform.localScale = (new Vector3(2, 2, 2));
        }
        
    }
    
}
