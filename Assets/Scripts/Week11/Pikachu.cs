using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Pikachu : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip VictorySFX;

    public GameObject pikachuPrefab;

    public float speed = 3f;
    public Vector3 direct;

    protected Congrats success;

    
    void Start()
    {
        GetComponent<Rigidbody>();
        Instantiate(pikachuPrefab); //+random transform.position

        success = GetComponent<Congrats>();

    }

    void Update()
    {

        direct = new Vector3(Random.Range(-1f,1f),Random.Range(-1f,1f), 0);
        transform.position += direct * speed;

        GetComponent<Rigidbody>().AddForce(direct * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collison2D)
    {
        if (collison2D.gameObject.tag == "HorizontalWall")
        {
            //multiply direction.x * -1
        }
        else if (collison2D.gameObject.tag == "VerticalWall")
        {
            //multiply direction.y * -1
        }
    }

    private void OnMouseDown()
    {
        AudioSource.clip = VictorySFX;
        AudioSource.Play();

        //success.YouFoundPikachu();

    }
}
