using UnityEngine;

public class TimeCountDown : MonoBehaviour
{
    public float timerCountDown = 3f;
    public float timerMaxDown = 3f;
    public bool allDone = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    /*
    void Update()
    {
        timerCountDown = -Time.deltaTime;
        if (allDone <= timerMaxDown)
        {
            Debug.Log("Timer Finished!");
            timerCountDown =
        }
    }
    */
    void Update()
    {
        timerCountDown -= Time.deltaTime;

        if(timerCountDown <= 0)
        {
            Debug.Log("Timer at 0");

        }
    }
}
