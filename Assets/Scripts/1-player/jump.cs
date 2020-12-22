using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	private const float z = 0f;
	[SerializeField] KeyCode jump_key;
	private void Start()
	{
		
	}

	void Update()
	{
		if(Input.GetKeyDown(jump_key))
		{
			Vector3 position = transform.position;
			Debug.Log("xxxxxxxxxxxxxxxxxxx");
			position += new Vector3(z, 10.0f, z);
			transform.position = position;
		}
	}
    
}
