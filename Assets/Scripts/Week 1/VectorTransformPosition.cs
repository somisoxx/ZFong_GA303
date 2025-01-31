using UnityEngine;

public class VectorTransformPosition : MonoBehaviour
{
    public Vector3 start;
    public Vector3 move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = start;

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += move * Time.deltaTime;
    }
}
