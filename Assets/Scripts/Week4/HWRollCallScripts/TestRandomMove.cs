using System.Diagnostics.Contracts;
using UnityEngine;

public class TestRandomMove : MonoBehaviour
{
    
    public float timeMoveMax = Random.Range(3f, 6f);
    public float timeMovePass = 0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        timeMovePass += Time.deltaTime;
        if (timeMovePass >= timeMoveMax)
        {
            Vector3 randomDirection = Vector3.zero;

            randomDirection.x = Random.Range(-1f, 1f);
            randomDirection.y = Random.Range(0f, 1f);
            randomDirection.z = Random.Range(-1f, 1f);

            float forceMultiplier = Random.Range(1, 3);

            this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * forceMultiplier);
            timeMovePass = 0f;
        }

    }
}
