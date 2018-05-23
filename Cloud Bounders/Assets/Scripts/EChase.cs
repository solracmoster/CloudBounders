using UnityEngine;
using System.Collections;

public class EChase : MonoBehaviour {

	public GameObject target;
	public float chaseSpeed = 2.0f;
	public float chaseTriggerDistance = 50.0f;
	private bool home = true;
	private Vector3 homePosition;

	// Use this for initialization
	void Start () {
		homePosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		Vector3 P1Position = target.transform.position;
		Vector2 chaseDirection = new Vector2 (P1Position.x - transform.position.x, P1Position.y - transform.position.y);


		//chase the player, leaving homebehind
		if (chaseDirection.magnitude < chaseTriggerDistance) {
          
            home = false; 
			chaseDirection.Normalize ();
			GetComponent<Rigidbody2D> ().velocity = chaseDirection * chaseSpeed;
		} else if (home == false) {
			
			//if we are not home we need to go home
			Vector3 goHome = homePosition - transform.position;
			if (goHome.magnitude < 0.1f) {
				//we have arrived
				home = true;
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);

			} else {
				
				goHome.Normalize ();
				GetComponent<Rigidbody2D> ().velocity = goHome * chaseSpeed;
			}
		}  
			
			}
		}
	

