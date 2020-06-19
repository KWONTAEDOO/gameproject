using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flydestruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		//3초뒤에 파리 없어진다.
		Destroy(gameObject,3);
    }
	
}
