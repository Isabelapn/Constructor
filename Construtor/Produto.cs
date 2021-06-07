using System.Globalization;
namespace Course
{
    class Produto
    {
        //public string Nome;
        //public double Preco;
        //public int Quantidade; //O FATO DO ATRIB. QUANT. SER PÚBLICO permite que qualquer program. faça alguma alteração

        /// <summary>
        /// USO DO THIS
        /// </summary>
        //public Produto()
        //{
        //    Quantidade = 10;
        //}
        //public Produto(string nome, double preco) : this() //ao usar o this(),reaprov. o atrib. Quant. do construt. vazio
        //{
        //    Nome = nome;
        //    Preco = preco;
        //}
        //public Produto (string nome, double preco, int quantidade): this(nome, preco)//reaprov. os atrib. Nome e Preco do construt. anterior
        //{
        //    Quantidade = quantidade;
        //}

        /// <summary>
        /// CONSTRUTOR PADRÃO - VAZIO
        /// </summary>
        //public Produto() //CONSTRUTOR PADRÃO - VAZIO
        //{
        //}

        /// <summary>
        ///  CONSTRUTOR 1
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="preco"></param>
        /// <param name="quantidade"></param>
        //public Produto(string nome, double preco, int quantidade) //
        //{
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = quantidade;
        //}

        /// <summary>
        /// CONSTRUTOR 3
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="preco"></param>
        //public Produto(string nome, double preco) // 
        //{
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = 5;
        //}

        /*
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        */

        /// <summary>
        /// ENCAPSULAMENTO
        /// </summary>
        private string _nome; //por padrão da linguagem, todo nome de atributo privado (private) deve iniciar com _minúscula
        private double _preco;
        private int _quantidade;

        public Produto() 
        {
        }
        public Produto(string nome, double preco, int quantidade) // CONSTRUTOR 1
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        /// <summary>
        /// MÉTODO GET: acessa os dados de uma informação privada
        /// </summary>
        /// <returns></returns>
        public string GetNome() 
        {
            return _nome;
        }
        /// <summary>
        /// MÉTODO SET: altera os dados de uma informação privada
        /// </summary>
        /// <param name="nome"></param>
        public void SetNome(string nome) //void não retorna nenhuma informação
        {
            if(nome!= null && nome.Length> 1)
            {
                _nome = nome; //atributo _nome recebe o novo nome que o usuário vai inserir como parâmetro de entrada no SetNome
            }            
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantiade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}