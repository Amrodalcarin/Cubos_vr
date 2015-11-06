using UnityEngine;
using System;

public class cambiar_pos : MonoBehaviour {

	public GameObject cubo1;
	public GameObject cubo2;
	public GameObject cubo3;
	private Vector3 pos_nueva_1;
	private Vector3 pos_nueva_2;
	private Vector3 pos_nueva_3;

    void posCirculo()
    {
        double Grados = 2 * Math.PI / 3;

        GameObject[] cubos = new GameObject[6];
        cubos[0] = cubo1;
        cubos[1] = cubo2;
        cubos[2] = cubo3;
        for (int i = 0; i < 3; i++)
        {
            // X:
            float x = (float)Math.Sin(Grados * i);
            x *= 2;
            // Z
            float z = (float)Math.Cos(Grados * i);
            z *= 2;
            cubos[i].transform.position = new Vector3(x, 1, z);
        }
    }

    // Use this for initialization
    void Start () {
        posCirculo();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			pos_nueva_1 = cubo2.transform.position;
			pos_nueva_2 = cubo3.transform.position;
			pos_nueva_3 = cubo1.transform.position;
			cubo1.transform.position = pos_nueva_1;
			cubo2.transform.position = pos_nueva_2;
			cubo3.transform.position = pos_nueva_3;
		}
	}

}
