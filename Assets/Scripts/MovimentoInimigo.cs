using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    // Variável que controla a rapidez com que o robô anda
    public float velocidade = 4f; 

    // O Update roda dezenas de vezes por segundo
    void Update()
    {
        // Vector3.left significa "Para a esquerda"
        // Time.deltaTime garante que ele ande suavemente em qualquer computador
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}