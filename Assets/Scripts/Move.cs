using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateSize(float newSize)
    {
        
        transform.localScale = new Vector3(Mathf.RoundToInt(newSize), 0, 0) + transform.localScale;
    }
}
