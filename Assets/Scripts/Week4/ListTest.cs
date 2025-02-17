using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public List<Cannonball> cannonballs = new List<Cannonball>();

    public GameObject cannonballPrefab;
    void Start()
    {
        //Finds all object in the scene that has the Cannonball script on it and turns it into 
        //a list to be used by the cannonballs variable, which is a list of Cannonball scripts.
        cannonballs = FindObjectsByType<Cannonball>(FindObjectsSortMode.None).ToList();

        //FInds all GameObjects in the scene with the specified tag. Returns it as an
        //Array of GameObjects that you can convert to a List.
        //GameObject.FindGameObjectWithTag("Cannonball").ToList();

        GameObject go = Instantiate(cannonballPrefab);
        //YOu can add an object directly to a list by calling the list variables's name.Add();
        //It must be the same type as the list. If you have a list of GameObjects, make sure 
        //you give it a GameObject. In this case, we have a cannonball script that we want to 
        //add to the list of cannonball scripts.
        cannonballs.Add(go.GetComponent<Cannonball>());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //A foreach loop will go through each object in a list and allow you to do the 
            //same action for every single instance in that list.
            foreach(Cannonball ball in cannonballs)
            {
                ball.AddRandomForce();
            }
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            int randomBall = Random.Range(0, cannonballs.Count);

            cannonballs[randomBall].AddRandomForce();
        }
    }
}
