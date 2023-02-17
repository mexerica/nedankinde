using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    private float timer;

    private int indice;

    [SerializeField] private List<Wave> waves;

    private float espera;

    private Wave waveAtual;

    void Start() {
        indice = 0;
        espera = 2;
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
        float espacamento = waveAtual.intervalo;
        if (waveAtual.inimigo != null) {
            for (int i=0; i<waveAtual.quantidade; i++) {
                Invoke("Spawn", waveAtual.intervalo);
                waveAtual.intervalo += espacamento;
            }
        }
    }

    private GameObject Spawn() {
        Vector3 posRelativa = new Vector3(waveAtual.posicao.x-1.3f, waveAtual.posicao.y, waveAtual.posicao.z);
        return Instantiate(waveAtual.inimigo, posRelativa, Quaternion.identity);
    }
}
