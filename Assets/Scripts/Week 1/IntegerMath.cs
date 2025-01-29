using UnityEngine;

public class IntegerMath : MonoBehaviour
{
    int blossom = 1;
    int bubbles = 2;
    int buttercup = 3;
    int total;
 
    void Start()
    {
        total = (blossom + bubbles + buttercup) * 3 / blossom;
        Debug.Log ("total is " + total);
    }

   
    void Update()
    {
        
    }
}
