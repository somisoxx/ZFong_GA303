using UnityEngine;

public class Pokemon : MonoBehaviour
{
    
    [SerializeField]public AudioClip missSFX;
    [SerializeField] public AudioClip capturedSFX;

    public float missCounter;
    public GameObject background;

    private Vector2 direction;
    float speed = 3f;

    public Congrats congrats;
    void Start()
    {
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
            Pokemon pokemon = hit.collider.GetComponent<Pokemon>();
            /*if (otherPoke != null && gameObject.name != )
            {
                Throw();
                
            }
            else if (otherPoke != null && gameObject.CompareTag("Pikachu"))
            {
                //success
            }
            */
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Pikachu"))
                {
                    SFXManager.instance.PlaySFXClip(capturedSFX, transform, 1f);
                    Debug.Log("You caught Pikachu! You missed " + missCounter + " times.");
                    PikachuFound();
                }
                else if(!hit.collider.CompareTag("Pikachu"))
                {
                    SFXManager.instance.PlaySFXClip(missSFX, transform, 1f);
                    missCounter++;
                    
                    Debug.Log("You missed! You have missed " + missCounter + " throws at Pikachu!");
                    if (hit.collider.CompareTag("OtherPoke"))
                    {
                        Debug.Log(this.gameObject.name + "encountered! You have missed " + missCounter + " throws at Pikachu!");
                    }
                }
            }
        }
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("VerticalWall"))
        {
            direction.x *= -1;
        }
        else if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            direction.y *= -1;
        }
    }

    public void PikachuFound()
    {
        congrats.Success();
        gameObject.SetActive(false);
    }

    /*public virtual void Throw()
    {
        SFXManager.instance.PlaySFXClip(missSFX, transform, 1f);

                missCounter += 1;
                Debug.Log(this.gameObject.name + "encountered! You have missed " +  missCounter + " throws at Pikachu!");
    }*/
}   
