using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanController : MonoBehaviour {
	private Animator anim;
	private MeshRenderer fanRenderer;
	public GameObject hideEffect;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		fanRenderer = GetComponent<MeshRenderer>();
	}

	public void DoSpin() {
		anim.CrossFade("Spin", 1);
	}

	public void Hide() {
		fanRenderer.enabled = false;
		Instantiate(hideEffect, transform.position, transform.rotation);
	}

	public void Show() {
		fanRenderer.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
