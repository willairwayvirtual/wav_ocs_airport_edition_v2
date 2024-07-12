using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public Transform player;
	public Text scoreText;

	// Update is called once per frame
	void Update()
	{
        string v = player.position.z.ToString("0");
        scoreText.text = v;
	}
}
