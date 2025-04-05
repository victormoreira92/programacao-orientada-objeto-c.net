# 📚 BookStore - Sistema de Cadastro de Livros em C#

Um projeto simples em C# para cadastro e gerenciamento de livros em uma livraria, utilizando estruturas (struct) e conceitos básicos de programação orientada a objetos.

## 🚀 Funcionalidades

- **Cadastro de Livros**: Adicione novos livros ao sistema informando título, autor, ano de lançamento, preço e quantidade em estoque.
- **Listagem de Livros**: Visualize todos os livros cadastrados no sistema.
- **Cálculo de Valor Total**: Obtenha o valor total do estoque somando o valor de todos os livros cadastrados.

## ⚙️ Estrutura do Projeto

O projeto utiliza:
- `struct Book` para representar os dados dos livros
- Listas para armazenamento dos registros
- Menu interativo via console
- Operações LINQ para cálculos

## 📦 Como Usar

1. Clone o repositório
2. Abra o projeto no Visual Studio ou outra IDE compatível com C#
3. Execute o programa
4. Siga as instruções no menu interativo

## 📝 Exemplo de Uso

```csharp
// Exemplo de cadastro de livro
books.Add(new Book("Crime e Castigo", 1895, "Dostoevski", 54.12, 15));

// Listagem de livros
books.ForEach(book => Console.WriteLine(book));

// Cálculo do valor total
double total = books.Sum(book => book.ValueTotalInStock());
```

## 🛠️ Tecnologias Utilizadas

- C# .NET
- LINQ (Language Integrated Query)
- Estruturas (struct)

## 📌 Melhorias Futuras

- [ ] Persistência de dados (banco de dados ou arquivos)
- [ ] Validação de entradas do usuário
- [ ] Interface gráfica
- [ ] Sistema de busca/filtro de livros

## 🤝 Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

---

Desenvolvido com ❤️ usando C#