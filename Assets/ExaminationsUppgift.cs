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
    public float number = 1;
    
    // Use this for initialization
    void Start()
    {
        moveSpeed = Random.Range(3, 13);
        // gör så att skeppets hastighet randomiseras när spelet startas
        rend.color = color;
        rend.color = new Color(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        // timern ökar med 1 varje sekund
        if(timer >= number)
        {
            print(string.Format("Timer:{0}",(int)timer));   
            // om timern är större än eller lika med number så skrivs timern ut i konsolen
            number = number + 1;
            // om timern är större än eller lika med number ökas number med 1
        }if (Input.GetKeyDown(KeyCode.Space))
        {
            rend.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            // när man trycker på space randomiseras skeppets färg
            trailRend.endColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            trailRend.startColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }



        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, moveSpeed * Time.deltaTime / 2, 0);
            // när man håller inne S åker skeppet hälften så snabbt
            rend.color = new Color(1, 0, 0);
            trailRend.endColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            trailRend.startColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotationSpeed /1.3f * Time.deltaTime);
            // när man håller inne A svänger skeppet åt vänster
            rend.color = new Color(0, 1, 0);
            // när man håller inne A blir skeppet grönt
            trailRend.endColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            trailRend.startColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        if (Input.GetKey(KeyCode.S) == false)
        {
            transform.Translate(0, moveSpeed * Time.deltaTime, 0);
            // när man inte håller inne S åker skeppet i normal hastighet
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            // när man håller inne D svänger skeppet åt höger
            rend.color = new Color(0, 0, 1);
            // när man håller inne D blir skeppet blått
            trailRend.endColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            trailRend.startColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, moveSpeed * Time.deltaTime * 1.5f, 0);
            rend.color = new Color(1.7f, 0, 0);
            trailRend.endColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            trailRend.startColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }if(transform.position.x > 27.5)
        {
            print(string.Format("Snek is out of bounds"));
            // om skeppet hamnar till höger utanför skärmen printas "Snek is out of bounds"
            transform.position = new Vector3(0, transform.position.y);
        }if (transform.position.x < -27.5)
        {
            print(string.Format("Snek is out of bounds"));
            transform.position = new Vector3(0, transform.position.y);
        }
        if (transform.position.y > 15.5)
        {
            print(string.Format("Snek is out of bounds"));
            transform.position = new Vector3(transform.position.x, 0);
        }
        if (transform.position.y < -15.5)
        {
            print(string.Format("Snek is out of bounds"));
            transform.position = new Vector3(transform.position.x, 0);
        }
    }
}
