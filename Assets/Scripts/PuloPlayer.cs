using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuloPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    bool noChao = false;
    float chaoCheckRaio = 0.2f;
    public Transform ChaoCheck;
    public LayerMask OQueEChao;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        noChao = Physics2D.OverlapCircle (ChaoCheck.position, chaoCheckRaio, OQueEChao);
    }

    // Update is called once per frame
    void Update()
    {
        if (noChao && Input.GetButton("Jump"))
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 30));
    }

    
}
