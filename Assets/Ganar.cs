using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ganar : MonoBehaviour
{
    public bool perder, clonar = true;
    GameObject clon;
    int cloneAmount = 4;
    public GameObject objectToClone;
    public GameObject Panel;
    public GameObject Text;
    

    public Text txtPerdiste;
    // Start is called before the first frame update
    void Start()
    {
        //perder = false;
        //Panel.SetActive(false);
        //Text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube" && clonar)
        {
            clonar = false;
            Panel.gameObject.SetActive(true);
            Text.gameObject.SetActive(true);
            for (int i = 0; i <= 4; i++)
            {
                clon = Instantiate(objectToClone);
                Destroy(clon, 4);
                perder = true;
                
            }
           

        }
    }
}

