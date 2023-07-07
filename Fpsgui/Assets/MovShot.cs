using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovShot : MonoBehaviour
{
    public ParticleSystem particula;
    public TextMeshProUGUI text,text2;
    int balas,granadas;

        
    // Start is called before the first frame update
    void Start()
    {
        balas = 100;
        granadas = 10;
    }

    // Update is called once per frame
    void Update()
    {
        MoveShot();
        text.text = balas.ToString();
        text2.text = granadas.ToString();
    }
    void MoveShot()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.position+=new Vector3(0,0,1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(1, 0, 0);
        }
        if(Input.GetMouseButton(1))
        {
            particula.Play();
            balas--;

        }
        else
        {
            particula.Stop();
        }

        if (Input.GetMouseButton(0))
        {
            particula.Play();
            granadas--;

        }
        else
        {
            particula.Stop();
        }


    }
}
