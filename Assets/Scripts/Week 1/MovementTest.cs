


using UnityEngine;

public class Movementest : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 moveDirection;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");

        //in reference to the object THIS script is on, get reference to its TRANSFORM component and get reference to the transform's POSITION, and SET it (=) to Vector3.zero which means (0,0,0)
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //moveDirection is currently (1,0,1)
        this.transform.position += moveDirection * speed * Time.deltaTime; //Multiplying by Time.deltatime means "Per Second" instead of "Per Frame"
        
    }
}
