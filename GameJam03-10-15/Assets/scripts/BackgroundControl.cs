using UnityEngine;
using System.Collections;

public class BackgroundControl : MonoBehaviour {

	public Material nuvemMaterial;
	public Material nevoaMaterial;
	float NuvemOffset;
	float NevoaOffset;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		NuvemOffset += 0.0001f;
		nuvemMaterial.SetTextureOffset ("_MainTex", new Vector2 (-1.0f * NuvemOffset, 0));

		NevoaOffset += 0.0005f;
		nevoaMaterial.SetTextureOffset ("_MainTex", new Vector2 (1.0f * NevoaOffset, 0));
	}
	
}
