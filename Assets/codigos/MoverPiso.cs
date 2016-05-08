using UnityEngine;
using System.Collections;

public class MoverPiso : MonoBehaviour {

	private GameObject control;

	void Start () {
		control = GameObject.Find("control");
	}

	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(-control.GetComponent<ControlJuego>().velocidad, GetComponent<Rigidbody2D>().velocity.y);
	}
}
