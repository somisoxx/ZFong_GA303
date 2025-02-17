using UnityEngine;

public class ConditionalPractice : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    public Color go2ElseColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ColorGameObjectByName();
        ColorGameObjectByTag();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ColorGameObjectByName()
    {
        Debug.Log("go is named" + go.name);
        Debug.Log("go2 is named" + go2.name);

        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.name == "Cube")
        {
            //GetComponent will look for the component on the gameObject it is being called on
            //if there is no component of the tupe you are trying to get, when you use the dot
            //operator after it, it will throw a null reference exception.

            //If we create a local variable in the function that does the GetComponent call
            //once, we can use this variable multiple times that refers to this object's specific 
            //meshrenderer
            go.GetComponent<MeshRenderer>().material.color = Color.magenta;
            //change the color to magenta
        }
        else if (go.name == "Sphere")
        {
            goMeshRenderer.material.color = Color.cyan;
            //change the color to cyan
        }
        else if (go.name == "Cylinder")
        {
            goMeshRenderer.material.color = Color.black;
            //change the color to black
        }
        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
            //change the color orange
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();
        if (go2.name == "Cube")
        {
            go2MeshRenderer.material.color = Color.gray;
        }
        else if (go2.name == "Sphere")
        {
            go2MeshRenderer.material.color = Color.white;
        }
        else
        {
            go2MeshRenderer.material.color = go2ElseColor;
        }
    }
    void ColorGameObjectByTag()
    {
        MeshRenderer go2MeshRenderer = go.GetComponent<MeshRenderer>();
        if (go2.name == "CoolGuy")
        {
            go2MeshRenderer.material.color = Color.gray;
        }
        else if (go2.name == "NotCoolGuy")
        {
            go2MeshRenderer.material.color = Color.white;
        }
        else
        {
            go2MeshRenderer.material.color = go2ElseColor;

        }
    }
}  


