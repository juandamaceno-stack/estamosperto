using UnityEngine;

public class Colissão : MonoBehaviour
{
   public float ValorDaMoeda=500f;
   public float Multiplicador=2f;
   public Pontuação Pontuacao;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Jogador"))
        {
            Pontuacao.Pontuacao+=ValorDaMoeda;
            
        Destroy(gameObject);

        }


    }
 
 
}
