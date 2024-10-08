# projetoContato2: Agenda de Contatos

Este projeto consiste em uma aplicação para gerenciar uma agenda de contatos feita à partir de diagramas de classes propostos no exercício. A aplicação permite adicionar, pesquisar, alterar, remover e listar contatos. Cada contato possui um nome, e-mail, data de nascimento e uma lista de telefones.

## Funcionalidades

- **Adicionar Contato**: Permite adicionar um novo contato à agenda. Um contato deve ter pelo menos um telefone principal.
- **Pesquisar Contato**: Permite pesquisar um contato existente na agenda pelo e-mail.
- **Alterar Contato**: Permite alterar as informações de um contato existente, como nome, data de nascimento e telefones.
- **Remover Contato**: Remove um contato da agenda, a partir do e-mail.
- **Listar Contatos**: Exibe a lista de todos os contatos da agenda.

## Estrutura do Projeto

O projeto é composto pelas seguintes classes principais:

### 1. **Program**
Contém o ponto de entrada da aplicação, onde o menu interativo é exibido e o usuário pode selecionar as opções para gerenciar os contatos.

### 2. **Contatos**
Responsável por armazenar e gerenciar a lista de contatos, com métodos para adicionar, pesquisar, alterar e remover contatos.

### 3. **Contato**
Representa um contato, com os seguintes atributos:
- **Nome**: O nome do contato.
- **Email**: O e-mail único do contato, utilizado para identificá-lo na agenda.
- **DtNasc**: A data de nascimento do contato, composta por dia, mês e ano.
- **Telefones**: Uma lista de telefones associados ao contato, podendo conter um ou mais números.

### 4. **Telefone**
Representa um telefone de um contato, com os seguintes atributos:
- **Tipo**: Tipo do telefone (por exemplo, celular, fixo, trabalho).
- **Número**: O número do telefone.
- **Principal**: Indica se o telefone é o principal.

### 5. **Data**
Representa uma data, utilizada para armazenar a data de nascimento do contato.

## Exemplo de Uso

O usuário interage com a aplicação através de um menu em loop, onde as seguintes opções estão disponíveis:

1. **Adicionar contato**: O sistema solicita o nome, e-mail, data de nascimento e telefones do novo contato. É obrigatório adicionar pelo menos um telefone principal.
2. **Pesquisar contato**: O usuário informa o e-mail do contato que deseja encontrar, e o sistema exibe as informações do contato.
3. **Alterar contato**: O sistema permite alterar os dados de um contato existente.
4. **Remover contato**: Remove um contato da agenda, com base no e-mail informado.
5. **Listar contatos**: Exibe a lista de todos os contatos cadastrados.
 
