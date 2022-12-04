# Design Patterns

Este repositório foi criado com o propósito de estudar os principais padrões de projetos presentes na literatura. Para tal, foram utilizados problemas simples como forma de exercitar os conhecimentos adquiridos ao longo deste estudo. Cada um dos padrões conterá a descrição do problema e sua resolução utilizando a linguagem C#.


<a name="ancora"></a>
#### Ao longo do presente repositório são apresentados os seguintes Design Patterns:
- [Strategy](#ancora1)
- [State](#state)


## Padrão State
<div id = "state">

### Problema dos estados de um orçamento.

Implemente o State para controlar os possíveis estados de um orçamento.

Um orçamento pode estar EM APROVAÇÃO, APROVADO, REPROVADO ou FINALIZADO.

Um orçamento começa com o estado de EM APROVAÇÃO.

O orçamento pode ter descontos aplicados a seu valor de acordo com o seu estado.

Se ele estiver em aprovação: 5%; se estiver aprovado, 2%; se estiver reprovado ou finalizado, nada de descontos extra.

A troca de estados de um orçamento também pode ocorrer, mas não pode haver troca de estados inválidos. Por exemplo, se a nota está em aprovação, ela só pode ir para aprovado ou reprovado; se ela está aprovada ou reprovada, ela só pode ir para finalizada.

Se ela está finalizada, ela não pode mais mudar de estado.

</div>
