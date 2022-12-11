# Design Patterns

Este repositório foi criado com o propósito de estudar os principais padrões de projetos presentes na literatura. Para tal, foram utilizados problemas simples como forma de exercitar os conhecimentos adquiridos ao longo deste estudo. Cada um dos padrões conterá a descrição do problema e sua resolução utilizando a linguagem C#.


<a name="ancora"></a>
#### Ao longo do presente repositório são apresentados os seguintes Design Patterns:
- [Strategy](#strategy)
- [State](#state)
- [Template Method](#template)

## Padrão Strategy
<div id = "strategy">

### Problema das estratégias de investimento

Muitas pessoas optam por investir o dinheiro das suas contas bancárias. Existem diversos tipos de investimentos, desde investimentos conservadores até mais arrojados.

Independente do investimento escolhido, o titular da conta recebe apenas 75% do lucro do investimento, pois 25% é imposto.

Implemente um mecanismo que invista o valor do saldo dela em um dos vários tipos de investimento e, dado o retorno desse investimento, 75% do valor é adicionado no saldo da conta.

Crie a classe RealizadorDeInvestimentos que recebe uma estratégia de investimento, a executa sobre uma conta bancária, e adiciona o resultado seguindo a regra acima no saldo da conta.

Os possíveis tipos de investimento são:

"CONSERVADOR", que sempre retorna 0.8% do valor investido;
"MODERADO", que tem 50% de chances de retornar 2.5%, e 50% de chances de retornar 0.7%;
"ARROJADO", que tem 20% de chances de retornar 5%, 30% de chances de retornar 3%, e 50% de chances de retornar 0.6%.

</div>

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

### Problema dos estados de uma conta bancária.
Uma conta bancária realiza operações de saque e depósito diferente de acordo com seu estado.

Uma conta que está negativo, por exemplo, não aceita saques, e depositam apenas 95% do valor total de um depósito efetuado. Uma conta que está com saldo positivo, aceita saques, e o banco deposita 98% do valor do depósito.

Use o State para representar os possíveis estados da conta, e a sua transição de estado. Se uma conta passa a ter saldo positivo, fica com status POSITIVO. Caso contrário, possui saldo NEGATIVO.

</div>

## Template Method

<div id = "template">

### Impostos com templates definidos

Implemente o Template Method para resolver o problema dos impostos.

Implemente os Impostos ICPP e IKCV.

O imposto ICPP é calculado da seguinte forma: caso o valor do orçamento seja menor que 500,00, deve-se cobrar 5%; caso contrário, 7%.

Já o imposto IKCV, caso o valor do orçamento seja maior que 500,00 e algum item tiver valor superior a 100,00, o imposto a ser cobrado é de 10%; caso contrário 6%.

Escreva um método main que testa sua implementação.

Como resposta, forneça o código das classes do Imposto ICPP e IKCV e também da classe do Template, além do método Main.

Crie o imposto IHIT, que tem a seguinte regra: caso existam 2 ítens com o mesmo nome, o imposto deve ser de 13% mais R$100,00.

Caso contrário, o valor do imposto deverá ser (1% * o número de ítens no orçamento).

### Relatórios Bancários

Relatórios são muito parecidos: todos eles contém cabeçalho, corpo, e rodapé. Existem dois tipos de relatórios: simples e complexos.

As diferenças são sutis: relatórios simples possuem cabeçalhos e rodapés de uma linha, apenas com o nome do banco e telefone, respectivamente; relatórios complexos possuem cabeçalhos que informam o nome do banco, endereço, telefone, e rodapés que informam e-mail, e a data atual.

Além disso, dada uma lista de contas, um relatório simples apenas imprime titular e saldo da conta. O relatório complexo exibe titular, agência, número da conta, e saldo.

Use Template Method, e implemente o mecânismo de relatórios. Use dados falsos para os dados do banco.

</div>