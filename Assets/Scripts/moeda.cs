using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moeda : MonoBehaviour
{

    // Start is called before the first frame update
    public int qtdmoeda = 0;
    public Text txtmoedas; 
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        txtmoedas.text = qtdmoeda.ToString();
    }

    void OnTriggerEnter2D(Collider2D moeda)
    {
        if (moeda.gameObject.CompareTag("mueda"))
        {
            Destroy(moeda.gameObject);
            qtdmoeda++;
        }
    }

}
