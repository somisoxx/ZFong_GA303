
using UnityEngine;



public class HWDamgomer : MonoBehaviour
{
    public GameObject Damgom;
    public int scaleIncrease = 1;
    public int scaleDecrease = -1;

    public GameObject baboom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Damgom.transform.localScale += Vector3.one*scaleIncrease;
            
        }
        if(Damgom.transform.localScale.x>6)
        {
            baboom.SetActive(true);
            Damgom.SetActive(false);
        }
    }
    public void Poke()
    {
        Damgom.transform.localScale += Vector3.one * scaleDecrease;
    }

}

