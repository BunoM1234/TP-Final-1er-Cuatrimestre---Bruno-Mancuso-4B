using System.Collections;
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
    }

    // Update is called once per frame
    void Update()
    {

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
}
