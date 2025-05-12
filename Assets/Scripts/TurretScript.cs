using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.VFX;

public class TurretScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform ball;

    public Transform spawnLocation;

    public GameObject bulletPrefab;

    public float maxTime = 1;
    private float currentTime;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ball);

        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            //spawn bulle tin position
            var go = Instantiate(bulletPrefab);

            //Place in right spot
            go.transform.position = spawnLocation.position;
            go.transform.rotation = spawnLocation.rotation;

            currentTime = maxTime;
        }
    }
}
