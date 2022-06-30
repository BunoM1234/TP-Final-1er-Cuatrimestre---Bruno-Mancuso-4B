<<<<<<< HEAD
﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollision : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Camara;
    float CamaraY = 5.07f;
    float CamaraX = -3.43f;
    // Start is called before the first frame update
    void Start()
    {
        
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text contMuertes;
    int muertes;
    Vector3 posInicial;

    public AudioClip risadeardilla;

    AudioSource fuenteAudio;

    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        posInicial = new Vector3(transform.position.x, transform.position.y, transform.position.z);
>>>>>>> 221b5405b3fd3317c831f745a7b49280e1bb4eb0
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathFloor1")
        {
            if(Camara.transform.eulerAngles != new Vector3(CamaraX, CamaraY, 0)
            {
                Camara.transform.eulerAngles = new Vector3(CamaraX, CamaraY, 0);
            }
        }
            
    }
    
=======

    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Obstacle" || col.gameObject.name == "Helice")
        {
            transform.position = posInicial;
            muertes++;
            contMuertes.text = "Muertes: " + muertes;
            fuenteAudio.clip = risadeardilla;
            fuenteAudio.Play();
        }
    }
>>>>>>> 221b5405b3fd3317c831f745a7b49280e1bb4eb0
}
