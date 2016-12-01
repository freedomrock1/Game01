using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {     
            
            Debug.Log(Input.mousePosition+" "+this.GetType());
            transform.position = new Vector3(0, 7, 0);
        }
	}
}
