using UnityEngine;
using UnityEngine.InputSystem; // Precisamos disso para ler o teclado!

public class MovimentoPulse : MonoBehaviour
{
    // Criamos uma "caixinha" para controlar a velocidade do Pulse pelo Inspector
    public float velocidade = 5f; 

    void Update()
    {
        // 1. Checa se o jogador está segurando a tecla D (Direita)
        if (Keyboard.current.dKey.isPressed)
        {
            // Move o objeto para a direita, na velocidade definida, ajustada pelo tempo real
            transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        }

        // 2. Lógica para a tecla A (Esquerda).
        // Dica: Use Vector3.left no lugar de Vector3.right!
        if(Keyboard.current.aKey.isPressed)
        {
            transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        }


        
        
    }
}