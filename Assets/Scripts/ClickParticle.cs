using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickParticle : MonoBehaviour
{

	[SerializeField]
	GameObject particle;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetMouseButtonDown (0)) {

			Vector3 v = Input.mousePosition;
			// Z軸修正
			v.z = 10f;
			v = Camera.main.ScreenToWorldPoint (v);
			GameObject o = Instantiate (particle, v, transform.rotation) as GameObject;
			Destroy (o, 0.5f);
		}
		
	}
}
