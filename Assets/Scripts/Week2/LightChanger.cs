using System.Runtime.CompilerServices;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public Light lightWeWantToChange;

    public Vector3 lightMoveDirection;

    public bool isItorIsntIt = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeLightColor(Color.green);
        lightWeWantToChange.color = Color.green;
        this.gameObject.SetActive(isItorIsntIt);
        //lightWeWantToChange.gameObject.SetActive(false);

        //Destroy(lightWeWantToChange.gameobject); // This is how you diestroy a game object
    }

    // Update is called once per frame
    void Update()
    {
       // AdjustLight(); //The code in this function will be called at the start
        //of each update before moving on to the rest of the code in Update().
        Debug.Log("LightObject has been Adjusted");
        
        if(Input.GetKeyDown(KeyCode.R))
        {
            ChangeLightColor(Color.red);
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            ChangeLightColor(Color.green);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            ChangeLightColor(Color.blue);
        }
        if (Input.GetKeyDown (KeyCode.Space))
        {
            lightWeWantToChange.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown (KeyCode.V))
        {
            lightWeWantToChange.gameObject.SetActive(true);
        }
    }
    private void AdjustLight() //A private function can only be called from within the script.
    {
        lightWeWantToChange.transform.position += lightMoveDirection * Time.deltaTime;
        lightWeWantToChange.transform.localScale = Vector3.one * Time.deltaTime;
        lightWeWantToChange.intensity += 40f * Time.deltaTime;
        lightWeWantToChange.innerSpotAngle += 10F * Time.deltaTime;
    }
    public void ChangeLightColor(Color color)
    {
        
    }


    private void Awake()
    {
        //Is called before start
    }
    private void OnEnable()
    {
       //When this object is set active again from inactive, it will call the code in this function
    }
    private void OnDisable()
    {
        //When this object is disabled, run the code in here before it is disabled.
    }
    private void OnDestroy()
    {
        //
    }
    
}   




