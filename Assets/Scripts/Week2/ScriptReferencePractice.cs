using UnityEngine;

public class ScriptReferencePractice : MonoBehaviour
{
    public omnom nomParasite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nomParasite.scaleIncrease = 5f;
        nomParasite.RotateNomNom();
        nomParasite.RotateNomNom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
