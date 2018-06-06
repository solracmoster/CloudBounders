using UnityEngine;
using System.Collections;

public class EChase1 : MonoBehaviour
{

    Transform target;
    public float speed = 1;

    void Start()
    {

        //target = GameObject.FindGameObjectWithTag("Player").transform; //my predator
        target = GameObject.FindGameObjectWithTag("Player").transform; //my prey
    }

    void Update()
    {

        transform.LookAt(transform.position + new Vector3(0, 0, 1), transform.position - target.transform.position); //Face target
                                                                                                                     //transform.LookAt (transform.position + new Vector3 (0, 0, 1), target.transform.position - transform.position); //Face away from target
        transform.Translate(Vector3.down * speed * Time.deltaTime); //movement forwards


    }
}
