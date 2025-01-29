
using UnityEngine;

public class FloatMath : MonoBehaviour
{
    public float bulbasaur;
    public float squirtle;
    public float charmander;
    float total;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = bulbasaur / (squirtle - charmander);
        Debug.Log("total is " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
