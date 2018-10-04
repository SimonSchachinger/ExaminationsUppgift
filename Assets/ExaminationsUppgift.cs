using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaminationsUppgift : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color color;
    public float moveSpeed;
    public float rotationSpeed;
    public float timer;
    // Use this for initialization
    void Start()
    {
        rend.color = color;
        rend.color = new Color(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        print(timer);
        timer = timer + 1 * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, moveSpeed * Time.deltaTime / 2, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            rend.color = new Color(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.S) == false)
        {
            transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            rend.color = new Color(0, 0, 1);
        }
    }
}
