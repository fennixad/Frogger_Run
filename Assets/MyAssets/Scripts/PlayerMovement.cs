using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region 1. Variables
    Vector3 directionForward;
    Vector3 directionSide;
    #endregion
    void Start()
    {
        directionForward = Vector3.forward;
        directionSide = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        MovementPerUnit();
    }

    void MovementPerUnit()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (transform.position.z < 5.5f)
            transform.position += directionForward;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            if (transform.position.x > -4f)
            transform.position += directionSide; 
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < 4f)
            transform.position -= directionSide;
        }
    }
}
