using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaminationsUppgift : MonoBehaviour
{
    public TrailRenderer trailRend;
    public SpriteRenderer rend;
    public Color color;
    public float moveSpeed;
    public float rotationSpeed;
    public float timer;
    public int number;

    // Use this for initialization
    void Start()
    {
        rend.color = color;
        rend.color = new Color(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        timer = timer + dt;
        if ((int)(timer) - (int)(timer - dt) == 1)
        { print((int)timer); }



        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, moveSpeed * Time.deltaTime / 2, 0);
            rend.color = new Color(1, 0, 0);
            trailRend.endColor = new Color(0.5f, 0, 0);
            trailRend.startColor = new Color(0.5f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            rend.color = new Color(0, 1, 0);
            trailRend.endColor = new Color(1, 1, 0);
            trailRend.startColor = new Color(1, 1, 0);
        }
        if (Input.GetKey(KeyCode.S) == false)
        {
            transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            rend.color = new Color(0, 0, 1);
            trailRend.endColor = new Color(1, 0, 1);
            trailRend.startColor = new Color(1, 0, 1);
        }if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, moveSpeed * Time.deltaTime * 1.5f, 0);
            rend.color = new Color(1.7f, 0, 0);
            trailRend.endColor = new Color(0, 0, 1.9f);
            trailRend.startColor = new Color(0, 0, 2);
        }
    }
}
