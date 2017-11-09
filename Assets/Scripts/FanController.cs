using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanController : MonoBehaviour {
	private Animator anim;
	private Transform fanLoc;
	private Vector3 fanHideLoc;
	private Vector3 fanShowLoc;
	public GameObject hideEffect;
	

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		fanLoc = transform.Find("newFan");
		fanShowLoc = fanLoc.position;
		fanHideLoc = new Vector3(0, -20f, 0);
	}

	public void DoSpin() {
		anim.CrossFade("Spin", 1);
	}

	public void Hide() {
		fanLoc.position = fanHideLoc;
		Instantiate(hideEffect, transform.position, transform.rotation);
	}

	public void Show() {
		fanLoc.position = fanShowLoc;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
