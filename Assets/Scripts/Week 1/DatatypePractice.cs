


using UnityEngine;

public class DatatypePractice : MonoBehaviour
{
    int santaClaus;

    float total;
    public float mario;
    public float yoshi = 4.8f;
    //Characters are only allowed to be 1 letter of character n a keyboard. Male sure to use an apostrophe to surround the character you want it to represent
    char bee = 'B';

    string fullSentence;
    string intro = "Hello World!";
    string outro = "Cya later!";

    public string chestName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        santaClaus = 56;
        santaClaus = (santaClaus + 5) * 2 / (3 - 7);

        Debug.Log(santaClaus);
        Debug.Log(yoshi);
        yoshi = yoshi - 2;
        //Subtracts 2 from the current value of yoshi (written differently)
        yoshi -= 2;
        Debug.Log("Yoshi's value is " + yoshi);
        Debug.Log(bee + intro);
        total = mario + yoshi;
        fullSentence = intro + " " + outro;
        Debug.Log(fullSentence);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
