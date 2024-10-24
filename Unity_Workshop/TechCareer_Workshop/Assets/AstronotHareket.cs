using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronotHareket : MonoBehaviour
{
    public float hizKatsayisi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        transform.position += new Vector3(yatay*hizKatsayisi*Time.deltaTime, 0, 0);
        //Debug.Log(yatay);

        float dikey = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, dikey*hizKatsayisi*Time.deltaTime, 0);
    }

    private void LateUpdate()
    {
        
    }
}
