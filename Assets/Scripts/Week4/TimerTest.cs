using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountUp = 0f;
    public float timerMaxDuration = 3f;
    public bool hasFinishedTimer = false;

    public GameObject cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //When using Random.Range, if you put f after the numbers in the function, it will 
        //return a decimal number between those two numbers. If you do NOT put an f after the
        //number, it will return a whole number, from the first number to the last, not including
        //the last number. Example: Random.Range(1, 4) will return 1, 2, or 3, but not 4. 
        //If you do Random.Range (1f, 4f), it will return anywhere between 1 and 4, including
        //decimal places, like 1.759
        timerMaxDuration = Random.Range(1, 4);

        Invoke("MoveCubeRight", timerMaxDuration);
    }
    // In this Update, once the timer finishes, it changes a bool called hasFinishedTimer
    // to true, which prevents additional logic from being run for the timer.
    // This is how you can make sure something ONLY happens ONCE based on a timer.

    /*
    void Update()
    {


        if (hasFinishedTimer == false)
        {
            timerCountUp = Time.deltaTime;
            //Debug.Log(timerCountUp);


            if (timerCountUp >= timerMaxDuration)
            {
                hasFinishedTimer = true;
                Debug.Log("Reached End of Timer!");
            }
        }
    }
    */

    //In this Update, the timer counts up, but once it finally reaches the timerMaxDuration
    //it will move the cube to the right WITHOUT Time.deltaTime beacause we want it to move
    //in  one motion, not over time. Additionally, we reset the timerCountUp to 0 so that 
    //it will count back up to 3 again and move the cube once more.
    /*
     void Update()
     {
         timerCountUp = Time.deltaTime;
         //Debug.Log(timerCountUp);


         if (timerCountUp >= timerMaxDuration)
         {
             Debug.Log("Reached End of Timer!");
             cube.transform.position += Vector3.right;
             timerCountUp = 0f;
         }

     }
    */
    void MoveCubeRight()
    {
        cube.transform.position += Vector3.right;
       
        if(cube.transform.position.x < 10)
        {
            Invoke("MoveCubeRight", timerMaxDuration);
        }
    }
}
