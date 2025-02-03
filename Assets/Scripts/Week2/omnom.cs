using UnityEngine;

public class omnom : MonoBehaviour
{
    public GameObject nomNom;
    public float scaleIncrease = .5f;
    public GameObject youDiedScreen;

    public Vector3 rotationAmount;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nomNom.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;
       
        if(nomNom.transform.localScale.x > 60)
        {
            youDiedScreen.SetActive(true);
        }
    }
    public void ResetNomNom()
    {
        nomNom.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
    }
    public void RotateNomNom()
    {
        //The following line will rotate NomNom by -90 degrees in the z direction by
        //creating a new Vector3 variable to be used once at runtime
        nomNom.transform.Rotate(new Vector3(0f, 0f, -90f));

        //Alternatively, you can create a variable of type Vector3 to pass into the
        //rotate function, like the following line. This makes it so you can change the 
        //

        nomNom.transform.Rotate(rotationAmount);
    }   
    public void TeleportNom()
    {
        
    }
}


