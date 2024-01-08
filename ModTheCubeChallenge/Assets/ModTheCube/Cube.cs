using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Color Farbe = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    public float rotSpeed = 360.0f;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = Farbe;
    }
    
    void Update()
    {
        transform.Rotate( rotSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
}
