using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	private GameObject controlJuego;
	private int puntos = 0;

	void Start(){
		controlJuego = GameObject.Find("control");
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			if(tag.Equals("alcarraza")){
				puntos = 10;
			}
			if(tag.Equals("vasija")){
				puntos = 20;
			}
			if(tag.Equals("alcarrazaantro")){
				puntos = 50;
			}
			if(tag.Equals("canastero")){
				puntos = 100;
			}
			if(tag.Equals("diadema")){
				puntos = 150;
			}
			if(tag.Equals("pectorales")){
				puntos = 150;
			}
			if(tag.Equals("collar")){
				puntos = 250;
			}
			if(tag.Equals("mascara")){
				puntos = 500;
			}
			controlJuego.GetComponent<ControlJuego>().puntaje += puntos;
			Destroy (this.gameObject);
		}
	}
}
