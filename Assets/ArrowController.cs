using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
		this.player = GameObject.Find ("player");
	}
	
	// Update is called once per frame
	void Update () {
		// 落下
		transform.Translate (0, -0.1f, 0);

		// 地面下で消す
		if (transform.position.y < -5.0f) {
			// gameObject は自分自身
			// Destroyは引数にうけたものを消す
			Destroy (gameObject);
		}

		// 当たり判定
		Vector2 p1 = transform.position; // 矢自身
		Vector2 p2 = this.player.transform.position; // プレイヤ-
		Vector2 dir = p1 - p2;
		float d = dir.magnitude; // 2点間の距離を求める
		float r1 = 0.5f; // 矢の半径
		float r2 = 1.0f; // プレイヤーの半径

		// 両方の半径を足した数よりも小さいということは、当たったということ。
		if (d < r1 + r2) {
			Destroy (gameObject);
		}
	}
}
