
using UnityEngine;
using UnityEngine.UI;


public class DestroyObject : MonoBehaviour
{
    public Text scoreText;

    private int _score = 0;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Goblin")
        {
            _score++;
            Destroy(other.gameObject);
            scoreText.text = "Убитых: " + _score;
        }
    }
}
