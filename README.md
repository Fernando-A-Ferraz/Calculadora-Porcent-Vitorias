# PercentJogos: Calculadora Simples de Taxa de Ganhos

## Visão Geral

PercentJogos é um programa desenvolvido em C# que calcula a taxa de vitórias de um jogador com base no número total de jogos disputados e o número de vitórias. A taxa de vitórias é apresentada como uma porcentagem.

## Como Usar

1. **Execute o Programa**: Inicie o aplicativo.
2. **Digite o Número de Jogos Disputados**: Quando solicitado, insira o total de jogos jogados.
3. **Digite o Número de Vitórias**: Insira o total de vitórias.
4. **Veja o Resultado**: O programa calculará e exibirá a taxa de vitórias como uma porcentagem.

## Estrutura do Código

O programa é estruturado em duas classes principais: `Programa` e `Player`.

### Classe `Programa`

A classe `Programa` contém o método `Main`, que é o ponto de entrada do aplicativo. O método `Main` realiza as seguintes tarefas:
- Solicita ao usuário o número de jogos disputados e o número de vitórias.
- Cria uma instância da classe `Player`.
- Chama o método `GetWinRate` da classe `Player` para calcular e exibir a taxa de vitórias.

### Classe `Player`

A classe `Player` representa um jogador e possui as seguintes características:
- **Propriedades Públicas**:
  - `Jogos`: O número total de jogos disputados.
  - `Vitorias`: O número total de vitórias.
- **Propriedade Privada**:
  - `WinRate`: Calculada pelo método `GetWinRate`.
- **Método `GetWinRate`**: Calcula a taxa de vitórias como uma porcentagem e a exibe no console.