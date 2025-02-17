using UnityEngine;

public class MoveObjectsWithDirections : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;

    public float speed = 4f;

    public bool hasReachedDestination = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    /*
    void Update()
    {
        //This gets the direction every frame, updating when point 1 moves.
        //This causes the point1 object to steadily creep towards point 2,
        //slowing down as it approaches because the direction is slowly getting smaller.
        Vector3 direction;
        direction = point2.transform.position - point1.transform.position;
        Debug.Log(direction);

        point1.transform.position += direction * Time.deltaTime;
    }*/
    /*
    private void Update()
    {
    //This version normalizes the driection of the movement vector, so it travels
    //steadily toward point 2, multiplied by a speed variable so it can speed up.
    //Unfortunately, it jitters as it reaches the end because it always moved past
    //the exact location of point2, so it goes back and forth until it tries to reach 
    //exact point.

        Vector3 direction;
        direction = point2.transform.position - point1.transform.position;

        direction = direction.normalized;

        Debug.Log(direction);

        point1.transform.position += direction * Time.deltaTime * speed;
    }
    */
    /*
    private void Update()
    {
    //In this version of opdate, we check the distance between point1 and point2. If it is
    //close enough (within .1 unit), it teleports point1 onto point 2, which is visually not
    //noticeable. And it will stop trying to move point 1 towards poind2 because it is already
    //on top of it and therefore within distance.  However, it still is teleporting it every
    //single frame

        Vector3 direction;
        direction = point2.transform.position - point1.transform.position;

        direction = direction.normalized;

        Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));
        
        if(Vector3.Distance(point1.transform.position, point2.transform.position) <.1f)
        {
            point1.transform.position = point2.transform.position;

        }
        point1.transform.position += direction * Time.deltaTime * speed;
    }
    */
    private void Update()
    {
        //This version of Update will only run if point1 hasnt reached its destination.
        //Now, it will stop running all code in Update once it has reached its destination
        //because we have this hasReachedDestination bool variable that checks if it hasn't.
        //but once it does reach it, we set that bool to true, preventing it from running
        //any code in update anymore
        if (hasReachedDestination == false)
        {
            Vector3 direction;
            direction = point2.transform.position - point1.transform.position;

            direction = direction.normalized;

            Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));

            if (Vector3.Distance(point1.transform.position, point2.transform.position) < .1f)
            {
                point1.transform.position = point2.transform.position;
                hasReachedDestination = true;
            }
            else
            {
                point1.transform.position += direction * Time.deltaTime * speed;
            }
        }   
    }
}