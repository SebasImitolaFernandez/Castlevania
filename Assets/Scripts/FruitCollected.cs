using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    bool collected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")  && !collected)
        {
            collected = true;
            FruitCounter.instance.AddFruit();

            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject,0.5f);
        }
    }
}
