
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
    
}
