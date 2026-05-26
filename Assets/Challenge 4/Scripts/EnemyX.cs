using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject playerGoal;

    // Start is called before the first frame update
    /// <summary>
    /// initializes enemy Rigidbody and playerGoal finding the object "Player Goal"
    /// </summary>
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal"); // initialize player Goal
    }

    /// <summary>
    /// FixedUpdate is used instead of Update because Unity
    /// executes this callback on fixed physics ticks.
    /// Physics-related operations like Rigidbody movement
    /// should be handled here.
    /// </summary>
    void FixedUpdate()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }

}
