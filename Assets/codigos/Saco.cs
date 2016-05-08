using UnityEngine;
using System.Collections;

public class Saco : MonoBehaviour {

	private GameObject generador_coin_izquierdo, generador_coin_mitad, generador_coin_derecho;
	private int posicion = 0;
	[SerializeField] float velocidadMax = 1f;
	private int puntos = 0;
	private GameObject control;
	private float distancia = 0;
	
	void Start () {
		control = GameObject.Find("control");
		generador_coin_izquierdo = GameObject.Find("generador_powerup_izquierdo");
		generador_coin_mitad = GameObject.Find("generador_powerup_mitad");
		generador_coin_derecho = GameObject.Find("generador_powerup_derecho");
	}

	void Update () {
		distancia = control.GetComponent<ControlJuego>().distancia_recorrida;
		GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocidadMax);

		if(posicion == -1)
			transform.position = new Vector2(generador_coin_izquierdo.transform.position.x, transform.position.y);
		if(posicion == 0)
			transform.position = new Vector2(generador_coin_mitad.transform.position.x, transform.position.y);
		if(posicion == 1)
			transform.position = new Vector2(generador_coin_derecho.transform.position.x, transform.position.y);
	
		Debug.Log(velocidadMax);
	}

	public void irDerecha(){
		posicion++;
	}

	public void irIzquierda(){
		posicion--;
	}
}
