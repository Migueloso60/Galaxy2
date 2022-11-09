using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NAVE : MonoBehaviour
{
    public float velocidad = 10f;
    public float horizontal;
    public float vertical;
    private Vector3 movimiento;
    public GameObject shot;
    public Transform shotSpawn;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(shot); 
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        movimiento.x = horizontal;
        movimiento.y = vertical;
        transform.position += movimiento * Time.deltaTime * velocidad;

    }
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void fire()
    {
        Instantiate(shot,shotSpawn.position, shotSpawn.rotation);
        audioSource.Play();
    }
    void limitarMovimiento()
    {
        // movimiento(Mathf.Clamp(transform.position.x, -8f, 8f), Mathf.Clamp(transform.position.y, -4f, 4f));
    }
}
