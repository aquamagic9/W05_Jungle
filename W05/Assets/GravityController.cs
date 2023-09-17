using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    [SerializeField] Transform CharacterTransform;
    public Transform MainCameraTransform;
    public Vector3 GravityDirection;
    bool _checkVKey = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (_checkVKey)
            {
                Physics.gravity = GravityDirection;
                _checkVKey = false;
            }
            else
            {
                Physics.gravity = -GravityDirection;
                _checkVKey = true;
            }
            SetRotation();
            Debug.Log(Physics.gravity);
        }
        if (Input.GetKey(KeyCode.R))
        {
            CharacterTransform.position = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            Physics.gravity = new Vector3(0, 9.8f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            Physics.gravity = new Vector3(0, -9.8f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            Physics.gravity = new Vector3(-9.8f, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            Physics.gravity = new Vector3(9.8f, 0, 0);
        }
    }

    private void SetRotation()
    {
        CharacterTransform.up = -Physics.gravity;
        MainCameraTransform.up = -Physics.gravity;
    }
}
