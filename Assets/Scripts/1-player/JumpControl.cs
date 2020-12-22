using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpControl : MonoBehaviour
{
    [SerializeField] KeyCode jump_key;
    const float z = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jump_key))
        {
            this.transform.position = new Vector3(z, z, z);
        }
    }
}
