using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BounceTest : MonoBehaviour
{

    //Vector2 direction = new Vector2 (1, 1);
    private Vector2 direction;
    float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "HorizontalWall")
        {
            direction.y *= -1;
        }
        else if (collision.collider.tag == "VerticalWall")
        {
            direction.x *= -1;
        }
    }
}
