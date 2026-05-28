using UnityEngine;

public class Itens : MonoBehaviour
{
     public GameObject Canudo;
     public GameObject Bebida;
     public GameObject Escudo;
     public ColissaoCaixa ItemAtual;
     private ColissaoCaixa.ItemType ItemAtualDoJogador;

    public void ReceberItem(ColissaoCaixa.ItemType novoItem)
    {
        ItemAtualDoJogador = novoItem;
        Canudo.SetActive(false);
        Bebida.SetActive(false);
        Escudo.SetActive(false);
    
        if (ItemAtualDoJogador == ColissaoCaixa.ItemType.Canudo)
        {
            Canudo.SetActive(true);
        }
        else if (ItemAtualDoJogador == ColissaoCaixa.ItemType.Escudo)
        {
            Escudo.SetActive(true);
        }
        else if (ItemAtualDoJogador == ColissaoCaixa.ItemType.Bebida)
        {
            Bebida.SetActive(true);
        }

    }
}
