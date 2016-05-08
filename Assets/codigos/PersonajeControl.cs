using UnityEngine;

[RequireComponent(typeof(Personaje))]
public class PersonajeControl : MonoBehaviour 
{
	private Personaje personaje;
    private bool salto;
	AudioSource as_personaje;
	public AudioClip ac_jump;
	private bool crouch;
	private int posicion = 0;
	private GameObject generador_piso_alto, generador_piso_medio, generador_piso_bajo;


	void Awake()
	{
		personaje = GetComponent<Personaje>();
		as_personaje = gameObject.GetComponent<AudioSource>();
		generador_piso_alto = GameObject.Find("generador_piso_alto");
		generador_piso_medio = GameObject.Find("generador_piso_medio");
		generador_piso_bajo = GameObject.Find("generador_piso_bajo");
	}

    void Update ()
    {
//		if (Input.GetButtonDown("Jump")){
//			salto = true;
//			as_personaje.PlayOneShot(ac_jump);
//		}

		if(Input.GetButtonDown("Jump")){
			crouch = true;
		}else{
			crouch = false;
		}

		if(Input.GetButtonDown("Up") && posicion < 2){
			posicion ++;
		}
		if(Input.GetButtonDown("Down") && posicion > 0){
			posicion --;
		}

		if(posicion == 0){
			transform.position = new Vector3(transform.position.x, generador_piso_bajo.transform.position.y + 1.2f);
		}
		if(posicion == 1){
			transform.position = new Vector3(transform.position.x, generador_piso_medio.transform.position.y + 1.2f);
		}
			
		if(posicion == 2){
			transform.position = new Vector3(transform.position.x, generador_piso_alto.transform.position.y + 1.2f);
		}

		Debug.Log(posicion);
    }

	void FixedUpdate()
	{
	    float h = Input.GetAxis("Horizontal");
		personaje.Move( 1, false , salto );
		personaje.Move (1, crouch, false);
		salto = false;
	}
}
