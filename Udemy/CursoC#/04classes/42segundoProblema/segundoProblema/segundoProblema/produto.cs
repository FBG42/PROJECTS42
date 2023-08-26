namespace segundoProblema
{
    internal class produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double valorTotalEmEstoque()
        {
            return preco * quantidade;
        }

        public void adicionarProdutos(int haAdicionar)
        {
            quantidade += haAdicionar;
        }

        public void removerProdutos(int haRemover)
        {
            quantidade -= haRemover;
        }

        public override string ToString()
        {
            return $"{nome}, $ {preco:F2}, {quantidade} unidades, Total: $ {valorTotalEmEstoque():F2}";
        }
    }
}
