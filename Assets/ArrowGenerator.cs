using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

	// Outlet接続
	// => publicが必要!
	public GameObject arrowPrefab;
	float span = 1.0f; // 1秒間隔
	float delta = 0; // 経過時間
		
	// Update is called once per frame
	void Update () {
		this.delta += Time.deltaTime;
		if(this.delta > this.span) {
			this.delta = 0; // 経過時間リセット
			// Instantiateにprefab(設計図) を渡すとインスタンスが取れる
			GameObject go = Instantiate (arrowPrefab) as GameObject;
			int px = Random.Range (-6, 7);
			go.transform.position = new Vector3 (px, 7, 0);
	}
}
