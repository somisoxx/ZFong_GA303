
using TMPro;
using UnityEngine;

public class TextSortingLayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            meshRenderer.sortingLayerName = "TextMesh Pro";
            meshRenderer.sortingOrder = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
