namespace ProjetoMoradia.Models
{
    public class Morador
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private DateTime DataNascimento { get; set; }

        public Morador(string nome, string cpf, string dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            SetDataNascimento(dataNascimento);
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }

        public string GetCpf()
        {
            return Cpf;
        }

        public void SetDataNascimento(string dataNascimento)
        {
            var dataNascimentoDatetime = DateTime.Parse(dataNascimento);
            //precisa comparar a "dataNasc" usando o "CompareTo" com "dataAtual" onde o resuntado será "1" ou "-1"
            //se "dataNasc" for menor que "dataAtual", entao "dataNasc" deve ser salva
            DateTime dataHoje = DateTime.Now;
            if(dataNascimentoDatetime.CompareTo(dataHoje) < 1)
            {
                DataNascimento=dataNascimentoDatetime;
            }
          
            else 
                {
                    DataNascimento= DateTime.MinValue;
                }
        }

        public DateTime GetDataDeNascimento()
        {
            return DataNascimento;
        }
    }
}