using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
  

    Material BGmaterial;
    public float xOffset;
    // Start is called before the first frame update
    void Start()
    {
        BGmaterial=GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private  void FixedUpdate()
    {
        BGmaterial.mainTextureOffset = new Vector2(xOffset * Time.time, 0);
    }

}
