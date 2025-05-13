using UnityEngine;

public class SiegeRam : MonoBehaviour
{
    Vector3[] ramPosition = new Vector3[11];
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
        ramPosition[1] = new Vector3(-5, 0, -4);
        ramPosition[2] = new Vector3(-5, 0, -3);
        ramPosition[3] = new Vector3(-5, 0, -2);
        ramPosition[4] = new Vector3(-5, 0, -1);
        ramPosition[5] = new Vector3(-5, 0, 0);
        ramPosition[6] = new Vector3(-5, 0, 1);
        ramPosition[7] = new Vector3(-5, 0, 2);
        ramPosition[8] = new Vector3(-5, 0, 3);
        ramPosition[9] = new Vector3(-5, 0, 4);
        ramPosition[10] = new Vector3(-5, 0, 5);
    }


}
