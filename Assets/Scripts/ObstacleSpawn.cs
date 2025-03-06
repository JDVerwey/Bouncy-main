using UnityEngine;

public class NewMonoBehaviourScript2 : MonoBehaviour
{
    //variables
    [SerializeField]
    public Transform Row1;
    [SerializeField]
    public Transform Row2;
    [SerializeField]
    public GameObject obstacle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawnobjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Spawn oobjects
    void Spawnobjects()
    {
       var gameObject = Instantiate(obstacle);
        gameObject.transform.position = Row1.position;
        gameObject.transform.rotation = Row1.rotation;

        var gameObject2 = Instantiate(obstacle);
        gameObject2.transform.position = Row2.position;
        gameObject2.transform.rotation = Row2.rotation;

        for (int i = 0; i < 10; i++)
        {

        }

        
    }
}
