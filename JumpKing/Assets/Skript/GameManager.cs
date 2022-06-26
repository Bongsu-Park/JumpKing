using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	[SerializeField] GameObject player;
	[SerializeField] Camera MainCamera;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		MainCamera.transform.position = new Vector3(0, ((int)player.transform.position.y / 10) * 10 + 5, -10);
	}
}
