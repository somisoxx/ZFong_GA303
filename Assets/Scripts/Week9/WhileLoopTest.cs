using System.Collections;
using UnityEngine;

public class WhileLoopTest : MonoBehaviour
{
    public float speed = 3f;
    Coroutine co;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        while(this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        */

        co = StartCoroutine(MoveRightAndChangeColor());
    }

    // Update is called once per frame
    void Update()
    {
        /*
        while(this.transform.position.y < 10)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        */

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(co);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();
        }
    }
     
    IEnumerator MoveRightAndChangeColor()
    {
        /*
        Debug.Log("Frame1 Runs");
        yield return null; //yield return null will pause the code until the next frame
        Debug.Log("Frame2 Runs");
        yield return new WaitForSeconds(2f); //This will wait 2 seconds before continuing code
        Debug.Log("Waited 2 seconds before positng this");
        */

        while (this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.blue;

        yield return new WaitForSeconds(2f);

        while (this.transform.position.x > -8f)
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
