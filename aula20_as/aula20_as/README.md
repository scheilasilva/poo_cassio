LIVRO
adicionar livro
post -> localhost:5000/api/livros
{
  "titulo": "Marley e eu"
}

adicionar o autor no livro
post -> localhost:5000/api/livros/ID DO LIVRO/autores/ID DO AUTOR

listar livros
get -> localhost:5000/api/livros

listar o livro pelo id
get -> localhost:5000/api/livros/ID DO LIVRO

atualiar um livro pelo id
update -> localhost:5000/api/livros/ID DO LIVRO
{
  "titulo": "Marley e eu 2"
}

deletar um livro   
delete -> localhost:5000/api/livros/ID DO LIVRO
..............................................................................
AUTOR
adicionar autor
post -> localhost:5000/api/autor
{
  "nome": "desconhecido"
}

listar os autores
get -> localhost:5000/api/auto

listar o autor por id
get -> localhost:5000/api/autor/ID DO AUTOR

atualizar um autor pelo id
update -> localhost:5000/api/autor/ID DO AUTOR
{
  "nome": "desconhecido 2"
}

deletar um autor 
delete -> localhost:5000/api/autores/ID DO AUTOR
..............................................................................
USUARIO
adicionar um usuario
post -> localhost:5000/api/usuario
{
  "nome": "diogo"
}

emprestar um livro ao usuario
post -> localhost:5000/api/usuario/ID DO USUARIO/emprestimos/ID DO LIVRO
{
  "nome": "diogo"
}

devolver livro ao usuario
post -> localhost:5000/api/usuario/ID DO USUARIO/devolucoes/ID DO LIVRO
{
  "nome": "diogo"
}

listrar os usuarios
get -> localhost:5000/api/usuario

listar o usuario pelo id
get -> localhost:5000/api/usuario/ID DO USUARIO

atualizar um usuario
update -> localhost:5000/api/usuario/ID DO USUARIO
{
  "nome": "diogo monteiro"
}

deletar um usuario   
delete - localhost:5000/api/usuario/ID DO USUARIO