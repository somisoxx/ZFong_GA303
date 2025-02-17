using UnityEngine;

public class HWInstantiate : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject ballSpawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(ballPrefab, ballSpawnPosition.transform.position, ballPrefab.transform.rotation);
        }
    }
}
