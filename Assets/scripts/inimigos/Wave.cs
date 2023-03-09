using UnityEngine;

public class Wave : MonoBehaviour {

    /// <summary>
    /// Duração da wave
    /// </summary>
    [SerializeField] public float duracao;

    /// <summary>
    /// Qual preset deve ser usado pra spawnar
    /// </summary>
    [SerializeField] public GameObject inimigo;

    /// <summary>
    /// A posição inicial da wave
    /// </summary>
    [SerializeField] public Vector3 posicao;

    /// <summary>
    /// Quantidade de inimigos da wave
    /// </summary>
    [SerializeField] public int quantidade;

    /// <summary>
    /// Intervalo entre inimigos
    /// </summary>
    [SerializeField] public float intervalo;

}
