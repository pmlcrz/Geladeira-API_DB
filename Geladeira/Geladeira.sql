USE Geladeira;

CREATE TABLE Itens (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Categoria NVARCHAR(50) NOT NULL,
    Prateleira INT NOT NULL,
    Container INT NOT NULL,
    Posicao INT NOT NULL
);

INSERT INTO Itens (Nome, Categoria, Prateleira, Container, Posicao) VALUES
('Alface', 'Frustas e verduras', 0, 0, 0),
('Chicoria', 'Frustas e verduras', 0, 0, 1),
('Batata', 'Frustas e verduras', 0, 0, 2),
('Beterraba', 'Frustas e verduras', 0, 0, 3),
('Cenoura', 'Frustas e verduras', 0, 1, 0),
('Couve', 'Frustas e verduras', 0, 1, 1),
('Pepino', 'Frustas e verduras', 0, 1, 2),
('Tomate', 'Frustas e verduras', 0, 1, 3),
('Melão', 'Frustas e verduras', 1, 0, 0),
('Leite', 'Laticínios', 1, 0, 1),
('Queijo prato', 'Laticínios', 1, 0, 2),
('Manteiga', 'Laticínios', 1, 0, 3),
('Requeijão', 'Laticínios', 1, 1, 0),
('Creme de leite', 'Laticínios', 1, 1, 1),
('Torta Floresta negra', 'Padaria', 1, 1, 2),
('Trota de chocolate', 'Padaria', 1, 1, 3),
('Coxa', 'Aviário', 2, 0, 0),
('Peito de frango', 'Aviário', 2, 0, 1),
('Picanha', 'Açougue', 2, 0, 2),
('Fígado bovino', 'Açougue', 2, 0, 3),
('Linguiça', 'Açougue', 2, 1, 0),
('Bacon', 'Açougue', 2, 1, 1),
('Salsicha', 'Açougue', 2, 1, 2),
('Patinho', 'Açougue', 2, 1, 3);
