using UnityEngine;
using System.Collections;
public class Morte : MonoBehaviour
{
 public GameObject TELADEMORTE;
    public SpriteRenderer spriteRenderer;
    public Sprite spriteNormal;
    private Movimento vida;

    private bool podeTomarDano = true;

    void Start()
    {
        vida = FindFirstObjectByType<Movimento>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Inimigo") && podeTomarDano)
        {
            StartCoroutine(TomarDano());
        }
    }

    IEnumerator TomarDano()
    {
        podeTomarDano = false;

        vida.Vida--;

        spriteRenderer.sprite = spriteNormal;

        if (vida.Vida <= 0)
        {
            TELADEMORTE.SetActive(true);

            Destroy(gameObject);
        }

        yield return new WaitForSeconds(2f);

        podeTomarDano = true;
    }


}
