using UnityEngine;

public class SiegeRam : MonoBehaviour
{
    Vector3[] ramPosition = new Vector3[6];
    void Start()
    {
        RellenaArray();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RellenaArray()
    {
        ramPosition[0] = new Vector3(-5,0,-5);
        ramPosition[1] = new Vector3(-5, 0, -3);
        ramPosition[2] = new Vector3(5, 0, -1);
        ramPosition[3] = new Vector3(5, 0, 0);
        ramPosition[4] = new Vector3(5, 0, 2);
        ramPosition[5] = new Vector3(-5, 0, 5);
    }
}
