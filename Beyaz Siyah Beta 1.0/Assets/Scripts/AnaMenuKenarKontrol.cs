using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaMenuKenarKontrol : MonoBehaviour {

    AnaMenuCharacter ac;

	void Start () {
        ac = GetComponentInParent<AnaMenuCharacter>();
	}
	
	
	void Update () {
        RaycastHit2D raycast = Physics2D.Raycast(transform.position, Vector2.down, 2f);
        if (!raycast.collider)
        {
            ac.hiz = -ac.hiz;
        }
	}
}
