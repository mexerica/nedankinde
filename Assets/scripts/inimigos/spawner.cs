using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    [Range(0, 10)][SerializeField] private float espera = 2;

    [SerializeField] private List<Wave> waves;

    private Wave waveAtual;

    private float timer;

    private int indice = 0;

    private float espacamento;

    void Start() {
    }

    void Update() {
        if (indice < waves.Count) {
            if (timer > espera) {
                waveAtual = waves[indice];
                espera = waveAtual.duracao;
                
                SpawnAll();

                indice++;
                timer = 0;
            } else
                timer += Time.deltaTime;
        }
    }

    private void SpawnAll() {
        //TODO: achar um jeito de retornar os inimigos? não precisa
        espacamento = waveAtual.intervalo;
        for (int i=0; i<waveAtual.quantidade; i++) {
            Invoke("Spawn", espacamento);
            espacamento += espacamento;
        }
    }

    private GameObject Spawn() {
        Vector3 posRelativa = waveAtual.posicao;
        return Instantiate(waveAtual.inimigo, posRelativa, Quaternion.identity);
    }
}
