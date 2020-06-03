using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float xSize = 10;
    public float zSize = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateSizeHorz(float newSize)
    {
        float z = transform.localScale.z;
        transform.localScale = new Vector3(Mathf.RoundToInt(newSize)+xSize, 1, z) ;
        
    }

    public void updateSizeVert(float newSize)
    {
        float x = transform.localScale.x;
        transform.localScale = new Vector3(x, 1, Mathf.RoundToInt(newSize)+zSize);
        Debug.Log(transform.localScale);
    }
}
