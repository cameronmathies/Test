using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float moveSpeed;
	public GameObject deathParticles;
	public float Speed = 1f;
	public float Force = 1f;
	public float hitForce;

	private Vector3 input;
	private Vector3 spawn;


	void Update() {
//				if (Input.GetMouseButtonDown (0)) {
//						RaycastHit hit;
//						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
//						if (Physics.Raycast (ray, out hit))
//						if (hit.collider != null)
//								hit.collider.enabled = false;
//
//
//				}
		}

	
	// Use this for initialization
	void Start () {
		spawn = transform.position;	
		//		menu = menu.GetComponent<Menu> ();
	}
//	void Update() {
//		float translation = Time.deltaTime * 10;
//		transform.Translate (0, 0, translation);
//	}
	// Update is called once per frame
	void FixedUpdate () {
				//Physics = Vector3 (0, -1F, 0);
	
//		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
//		
//		if (rigidbody.velocity.magnitude < maxSpeed) {
//			rigidbody.AddForce (input * moveSpeed);
//		}
				if (Input.GetKey (KeyCode.LeftArrow)) {
						transform.Translate (Vector3.left * Time.deltaTime * moveSpeed, Camera.main.transform);
						//}
//		if (Input.GetKey (KeyCode.UpArrow)) {
//			transform.Translate (Vector3.up * Time.deltaTime * moveSpeed, Camera.main.transform);

				}
				if (Input.GetKey (KeyCode.DownArrow)) {
						transform.Translate (Vector3.down * Time.deltaTime * 7, Camera.main.transform);
				}
				if (Input.GetKey (KeyCode.RightArrow)) {
						transform.Translate (Vector3.right * Time.deltaTime * moveSpeed, Camera.main.transform);

//						if (transform.position.y < -34) {
//								Application.LoadLevel ("L1"); 
//								//	Die ();
//						}
//		void Die(){
//		particleEmitter.emit = true;
						//Application.LoadLevel ("Credits");
				}
		}
}


			
	