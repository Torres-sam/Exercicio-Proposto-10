# 🕒 Calculadora de Duração de Jogo

Pequeno programa em C# que calcula a duração de um jogo, considerando a hora inicial e final. A lógica cobre casos em que o jogo atravessa a meia-noite.

## 💡 Descrição

- O usuário insere dois valores inteiros representando a hora de início e a hora de fim (no formato 24h).
- O programa calcula a duração total em horas.
- Exemplo:  
  - Entrada: `22 6`  
  - Saída: `O JOGO DUROU 8 HORA(S)`

## 📌 Regras de negócio

- Se a hora final for maior que a hora inicial → subtração direta.
- Se a hora final for menor ou igual → soma da diferença com 24.

## 🛠️ Tecnologias

- C#
- .NET CLI
