# Desafio: Travessia do Rio

Um **Homem** precisa atravessar um rio com um **Lobo** uma **Galinha** e um **Saco de Milho**.
O homem utiliza um barco para poder atravessar o rio, porém ele só consegue levar um de cada vez no barco.
  - Na presença do Homem nada acontece
  - Se o Lobo ficar sózinho com a galinha, o Lobo come a Galinha
  - Se a galinha ficar sózinha com o Milho, A galinha come o Milho
  - O Lobo Não come milho
  - Os animais não sabem atravessar o rio sózinhos
 
# Software
O Software **Travessia do Rio** tem como propósito simular o cenário descrito acima, foi desenvolvido com C# windows forms e .netframework 4.6

![Banana](/tela.png)
- O Botão mover move um personagem de um lado a outro do rio
- A checkbox em cima de cada personagem, serve para marcar quem vai atravessar o rio

# Desafio
O Método **ChecarMovimento()** é o método responsável por validar a jogada, ele recebe como parâmetro quatro variaveis booleanas, cada uma representando um personagem, onde o valor **false** indica que o personagem está do lado esquerdo do Rio e o valor **True** indica que o personagem está do lado direito do rio.

        private MoveResult ChecarMovimento(bool homem, bool lobo, bool galinha, bool milho)
        {
            return
                new MoveResult()
                {
                    Terminou = true,
                    Mensagem = "Implemente esse Método"
                };
        }

Classe **MoveResult** é uma classe criada para representar o resultado de uma jogada, ela possui dois atributos:
- bool Terminou: Para indicar se o jogo terminou.
- string Mensagem: Mensagem que será enviada ao usuário

Caso de Uso:
Digamos que o usuário atravessou o **Homem** e o **Lobo**, o método ChecarMovimento receberá como parametrô os valores: (true, true, false, false) e retornará o objeto MoveResult populado da seguinte forma:
MoveResult{
    Terminou: true,
    Mensagem: "Perdeu! A galinha comeu o milho!"
}

# Desafio
Implemente o método **ChecarMovimento** de modo que o software possa se comportar de acordo com as premissas descritas para o Cenário da **Travessia do rio**.

Restrições:
Para a implementação do método **Não é permitido** usar nenhuma estrutura ou forma de comparação como: if's, else's, for, switch, while, do, comparadores ternários e etc.

# Boa Sorte!

