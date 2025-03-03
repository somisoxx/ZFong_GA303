using UnityEngine;

public class ThirtyCountdown : MonoBehaviour
{
    public float timerCountingDown = 30f;
    public bool hasFinishedTimer = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hasFinishedTimer == false)
        {
            timerCountingDown -= Time.deltaTime;
            if (timerCountingDown <= 0)
            {
                hasFinishedTimer = true;
                Debug.Log("Time's Up!");
            }
        }
    }
}
