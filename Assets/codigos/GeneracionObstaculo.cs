using UnityEngine;
using System.Collections;

public class GeneracionObstaculo : MonoBehaviour
{
	public GameObject[] obstaculos;
	public float generacionMin = 1f;
	public float generacionMax = 2f;
	private GameObject control;
	
	void Start (){
		control = GameObject.Find("control");
		Generar ();
	}
	
	void Generar (){

		Instantiate (obstaculos [Random.Range(0,obstaculos.Length)], new Vector3 (transform.position.x, transform.position.y), Quaternion.identity);
		Invoke ("Generar", Random.Range (generacionMin, generacionMax));
	}

	void Update(){
		if(generacionMin > 0.7f){
			generacionMin -= control.GetComponent<ControlJuego>().distancia_recorrida;
		}
		if(generacionMax > 0.7f){
			generacionMax -= control.GetComponent<ControlJuego>().distancia_recorrida;
		}
	}
}
