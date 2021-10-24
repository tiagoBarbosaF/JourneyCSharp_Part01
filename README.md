# C# - Primeiros passos

## Objetivos ao completar os estudos

- Compile e execute código C#
- Aprenda a usar o Visual Studio
- Variáveis e controle de fluxo
- Condicionais e laços de repetição
- Conheça os principais tipos do C#

## Ementas:

### História e ecossistema da linguagem

- Introdução
- Historia e ecossistema .NET
- Benefício da CLR
- Quais aplicações?
- Sobre o .NET Framework
- O que aprendi?
  - Toda aplicação .NET é escrita em uma linguagem compilada para o código intermediário MSIL (Microsoft intermediate language);
  - O .NET Framework é uma biblioteca utilizada pelas aplicações .NET;
  - Uma aplicação .NET é compilada para o MSIL;
  - O código MSIL é executado pela máquina virtual do .NET, a CLR (common language runtime);
  - O just-in-time compiler é uma parte da CLR que transforma MSIL em código de máquina, apenas em tempo de execução.

### Nosso primeiro programa e o Visual Studio

- Nosso primeiro programa CSharp
- Sobre a compilação e execução
- Instalando o Visual Studio
- Mão na massa: instale a IDE Visual Studio
- Ola mundo no Visual Studio
- Sobre IDEs e editores
- Estrutura de diretorios do Visual Studio
- Entrada da aplicação
- Compilar e executar

### Variáveis numéricas

- Projeto da aula anterior
- Criando variáveis
- Criando uma variável numérica
- Mão na massa: utilizando o tipo int
- Criando variáveis double
- Mão na massa: utilizando o tipo double
- Operações entre números
- Conversao e outros tipos numericos
- Mão na massa: algumas conversões em C#
- Imprimindo texto e números
- Para saber mais: Type Casting
- O que aprendi?
  - Foi possível entender um pouco de type casting, e como podemos passar um valor de um tipo para uma variável de outro. 
  - Para alguns casos nós não precisamos fazer nada, pois o casting é implícito. 
  - Em outros, precisamos deixar claro para o compilador que sabemos o que estamos fazendo, mostrando entre parênteses o tipo que queremos que seja usado.

### Variáveis de texto

- Projeto da aula anterior
- Caracteres e textos
- Mão na massa: Praticando char e String
- Declarando string e char
- Concatenação de String e inteiros
- Variáveis guardam valores
- Qual será o resultado?
- O que aprendi?
    - O conceito e como declarar char e String;
    - Como concatenar Strings;
    - Variáveis guardam valores e não referências.

### Controle de fluxo com IF

- Projeto da aula anterior
- Trabalhando com IF
- Mão na massa: A condicional if
- Variável booleana
- Tipo bool
- Operador lógico
- Escopo
- Mão na massa: Um pouco mais de if
- Trabalhando com if
- Declaração da variável
- Mão na massa: Escopo de variáveis
- Opcional: Alíquota com ifs
- Para saber mais: o comando switch
- O que aprendi?
    - Como usar o `if`;
    - Como usar as operações lógicas `AND (&&)` e `OR (||)`;
    - Trabalhar com o escopo de variáveis.

### Controle de fluxo com laços de repetição

- Projeto da aula anterior
- Laço de repetição While
- Enquanto isso, o while...
- Fixando o laço while
- Laço de repetição For
- Encadeando laços FOR
- Transformando while em for
- A palavra chave Break
- Fixando o comando break
- Mão na massa: Laços
- Um erro de compilação...
- Exercitando laços aninhados e break
- Mão na massa: Aprofundando laços
- Desafio Opcional: Múltiplos de 3
- Desafio opcional: Fatorial
- Conclusão
- O que aprendi?
  - A sintaxe do `while` e `for`;
  - O operador `+=`;
  - O operador `++`;
  - Laços aninhados;
  - A funcionalidade do `break`.