# Nedankinde ✂

Jogo criado pra [Paint Jam](https://itch.io/jam/paint-jam-2021), o jogo foi desenvolvido em javascript, com o CT.js, cuspe e MS Paint, baseado no [Touhou 10 - Mountain of Faith](https://www.youtube.com/watch?v=ygM1rqNMGBo).

Pra jogar é só entrar no [link do projeto](https://mexerica.itch.io/nedankinde) no Itch.io.

![Nedankinde](/nedankinde/img/alguem_fundo.png)

Pra editar o jogo no CT.js baixe todos os arquivos e abra o [`nedankinde.ict`](/nedankinde.ict) no [CT.js](https://docs.ctjs.rocks/).

Programação, enredo e sons: [Tiago](https://github.com/mexerica)

Programação e arte: [Ricardo](https://github.com/sleiph)

![quinaife](/nedankinde/img/quinaife.png)


### Fazer

#### Arrumar

- Tem algum erro bizarro na spawner q vai aumentando entre waves o intervalo entre inimigos

#### Game Design

* diálogos entre as waves
* modo truzão, que vc tenta controlar uma bola com seus tiros [東方靈異伝](https://www.youtube.com/watch?v=w3YmmdgcHb8)
* protagonista
    - fica invulneravel depois de levar um tiro
* inimigos
    - novos e melhores padrões de movimento dos inimigos
    - adicionar um deslocamento entre os inimigos da wave, pra não ficar uma fila perfeita de otários
    - várias cores do mesmo inimigo pra render mais, cada um atira de um jeito, sei lá.
    - aleatoriedade no padrao de movimento, velocidade de tiro, rota de movimento...
* bosses
    - tudo
* tiros
    - adicionar um pouco mais de física nos tiros (se atira indo pra esquerda, o tiro vai meio pra esquerda)
    - o tiro é destruido no impacto
    - velocidade de alguns tiros varia
    - aleatoriedade na direcao de alguns tiros dos inimigos
* poderes
    - o poder vai em uma direção "aleatoria", mas sempre em direção ao lado oposto ao que ele spawnou
    - fica girandinho devagar
    - vai em direção ao jogador quando proximo o bastante
    - um escudo

#### Aparencia
* escrever 'Score' na interface
* usar o array de numeros pra exibir valores maiores q 9
* animação/som do player sendo atingido
* um fundo um pouco mais dinâmico
* todo o resto
