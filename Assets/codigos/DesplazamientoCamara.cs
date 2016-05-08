using UnityEngine;
using System.Collections;

public class DesplazamientoCamara : MonoBehaviour {

	public Transform jugador;

	void Update()
	{
		transform.position = new Vector3 (0, jugador.position.y + 4f, -10);
		}
}
