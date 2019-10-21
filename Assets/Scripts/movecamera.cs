using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform mc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(mc.position.x, mc.position.y+3,-11);
    }
}
