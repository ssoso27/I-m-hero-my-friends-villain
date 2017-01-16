using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongPasoManager : MonoBehaviour {

    private Vector3 firstPosition;

	// Use this for initialization
	void Start () {
        firstPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = firstPosition;
        transform.rotation = Quaternion.identity;
	}
}
