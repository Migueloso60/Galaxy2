using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    private MeshRenderer mesh;
    public float velocidad = 0.5f;
    private AudioSource audioSource;
    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
       mesh.material.mainTextureOffset += new Vector2(0, velocidad * Time.deltaTime); 
    }
}
