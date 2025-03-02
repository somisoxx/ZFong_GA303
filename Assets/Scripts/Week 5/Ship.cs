using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<Cannon> cannons = new List<Cannon>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannons = FindObjectsByType<Cannon>(FindObjectsSortMode.None).ToList();

        cannons[0].FireCannon(); // Fires First cannon in the list
        cannons[1].FireCannon(); // Fires Second cannon in the list
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {  
            foreach(Cannon c in cannons)
            {
                c.FireCannon();
            }
        }

        //This fires all cannons using a for loop
        /*for (int i - 0; i < cannons.Count; i++)
        {
        cannons[i].FireCannon();
        }*/

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < cannons.Count; i++)
            {
                //If it's odd, don't fire.
                //If it's even, fire!
                //The mod operator (%) does division between the two numbers and returns
                //the remainder. If the remainder of something % 2 is 0, it is even!
                if (i % 2 == 0)
                {
                    cannons[i].FireCannon();
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            for(int i = 0; i < cannons.Count; i++)
            {
                if(i % 2 == 1)
                {
                    cannons[i].FireCannon();
                }
                    
            }
        }
    }
}
