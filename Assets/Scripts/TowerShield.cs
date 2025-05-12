using UnityEngine;

public class TurrettShield : MonoBehaviour
{
    float activationDistance = 10;
    [SerializeField]
    int stats;
    BallController ballController;

    private Collider shieldCollider;
    private Renderer shieldRenderer;

    private Transform ballPosition;

    void Start()
    {
        // Find the position of the player
        ballPosition = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.Log("Found player");

        // Get the collider and renderer components
        shieldCollider = GetComponent<Collider>();
        shieldRenderer = GetComponent<Renderer>();

        // Initial state: disabled
        shieldCollider.enabled = false;
        shieldRenderer.enabled = false;
    }

    void Update()
    {
        // Call both activation and deactivation methods
        ActivateShield();
        DisableShield();
    }

    // Method to get the player distance
    private float getPlayerDistance()
    {
        // Find the distance between the player and the shield
        float playerDistance = Vector3.Distance(transform.position, ballPosition.position);
        return playerDistance;
    }

    // Method to activate shield
    private void ActivateShield()
    {
        // If the player distance is less than or equal to the activation distance
        if (getPlayerDistance() <= activationDistance)
        {
            shieldCollider.enabled = false;
            shieldRenderer.enabled = false;
        }
    }

    // Method to disable shield
    private void DisableShield()
    {
        // If the player distance is greater than the activation distance
        if (getPlayerDistance() > activationDistance)
        {
            shieldCollider.enabled = true;
            shieldRenderer.enabled = true;
           
        }
    }
}
