using UnityEngine;

public class ColissaoCaixa : MonoBehaviour
{
    public ItemType ItemAtual;

     public enum ItemType
    {   
        Bebida,
        Escudo,
        Canudo
    }

    public ItemType GetWeightedItem(int position)
    {

    int NumeroAleatorio = Random.Range(0, 50);

        if(NumeroAleatorio < 20)
            return ItemType.Bebida;

        //if(NumeroAleatorio < 50)
            return ItemType.Escudo;

       // return ItemType.Canudo;
    }
    
         private void OnTriggerEnter2D(Collider2D collision)
        {
        if (collision.CompareTag("Jogador"))
        {        
         Itens itensJogador = collision.GetComponent<Itens>();
        
         ItemType ITemRecebido = GetWeightedItem(1);

         itensJogador.ReceberItem(ITemRecebido);

        Destroy(gameObject);

        }
       
        }
}
