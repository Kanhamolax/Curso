using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class MoveCurve : MonoBehaviour
{
    [Header("Rigd Body")]
    public Rigidbody2D rb;

    [Header("Direção")]
    public Vector2 direcao,direcao2,v1,v2,v3,speed, relativeforce;
    public Vector3 rotarion;

    [Header("Velocidade e Aceleração")]
    [SerializeField] private float maxSpeed, aceleration, centripeta,currentSpeed;

    [Header("Direção")]
    [SerializeField]private float hori,hori2;

    [Header("Combustivel")]
    [SerializeField] float combuMax,combu;
    [Header("Tempo")]
    [SerializeField] float time,aux,target,drift;


    // Start is called before the first frame update
    void Start()
    {
        combu = combuMax;
        //v1=new Vector2(2,67);
        //v2=new Vector2(3,95);
            
        //Debug.Log(Vector2.Lerp(v1,v2, 0.8f));
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        //time += Time.deltaTime;
        //combu -= time * math.abs(rb.velocity.magnitude);
        //rb.velocity = rb.velocity*1f;
        //if(combu>=combuMax)
        //{
        //    rb.velocity = rb.velocity * 0f;
        //}
        hori = -Input.GetAxis("Horizontal");
        hori2 = Input.GetAxis("Vertical");
        speed = transform.up * aceleration*hori2;
        rb.AddForce(speed); 


        v1 = transform.up * aceleration;
        aux= Vector2.Dot(rb.velocity,rb.GetRelativeVector(Vector2.up));
        if(aux>=0)
        {
            rb.rotation+=hori * target*(rb.velocity.magnitude/maxSpeed*0.8f);

        }
        else 
        {
            rb.rotation -= hori * target * (rb.velocity.magnitude / maxSpeed * 0.8f);
        }
        drift =  Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.left)) * 2.0f;
        relativeforce = Vector2.right * drift;
        rb.AddForce(rb.GetRelativeVector(relativeforce));
        if(rb.velocity.magnitude>maxSpeed)
        {
            rb.velocity=rb.velocity.normalized*maxSpeed;
        }

        currentSpeed = rb.velocity.magnitude;
        
        //hori2= Input.GetAxis("Vertical");
        //direcao2=new Vector2(0,hori2*centripeta);
        //rb.AddForce(direcao2);
        //direcao = new Vector2(hori*centripeta,0);
        //rotarion = new Vector3(0, 0, hori);
        //rb.AddForce(direcao);
        //gameObject.transform.eulerAngles=gameObject.transform.eulerAngles+ rotarion*90;

    }
}
