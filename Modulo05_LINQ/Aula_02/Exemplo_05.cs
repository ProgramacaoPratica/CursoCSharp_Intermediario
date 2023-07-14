namespace ProjetoExemplo
{
    public class Program
    {
        public class Aluno
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public int CursoId { get; set; }
        }

        public class Curso
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno { Nome = "João", Idade = 20, CursoId = 1 },
                new Aluno { Nome = "Maria", Idade = 18, CursoId = 2 },
                new Aluno { Nome = "Pedro", Idade = 22, CursoId = 1 },
                new Aluno { Nome = "Ana", Idade = 19, CursoId = 3 }
            };

            List<Curso> cursos = new List<Curso>()
            {
                new Curso { Id = 1, Nome = "Matemática" },
                new Curso { Id = 2, Nome = "História" },
                new Curso { Id = 3, Nome = "Ciências" }
            };

            var alunosDoCurso = alunos.Join(cursos,
                                            aluno => aluno.CursoId,
                                            curso => curso.Id,
                                            (aluno, curso) => new { NomeAluno = aluno.Nome, NomeCurso = curso.Nome });

            foreach (var alunoCurso in alunosDoCurso)
            {
                Console.WriteLine($"Aluno: {alunoCurso.NomeAluno}, Curso: {alunoCurso.NomeCurso}");
            }
        }
    }
}
