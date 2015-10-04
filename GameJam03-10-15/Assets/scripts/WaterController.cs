using UnityEngine;
using System.Collections;

public class WaterController : MonoBehaviour {

	public Material agua1Material;
	public Material agua2Material;
	float agua1Offset;
	float agua2Offset;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		agua1Offset += 0.005f;
		agua1Material.SetTextureOffset ("_MainTex", new Vector2 (-1.0f * agua1Offset, 0));
		
		agua2Offset += 0.01f;
		agua2Material.SetTextureOffset ("_MainTex", new Vector2 (1.0f * agua2Offset, 0));
	}
}
