using UnityEngine;

public class HWDamgomed : MonoBehaviour
{
    public HWDamgomer Damgomifier;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Damgomifier.scaleIncrease = 1;
        Damgomifier.baboom.SetActive(false);
        Damgomifier.Damgom.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
