namespace SimpleQueue
{
    public class SimpleQueue<T>
    {
        private readonly Queue<T> clientes = new();

        public bool EstaVazia => clientes.Count == 0;

        public void Enqueue(T cliente)
        {
            clientes.Enqueue(cliente);
        }

        public T Dequeue()
        {
            if (clientes.Count == 0)
            {
                throw new InvalidOperationException("A FILA ESTÁ VAZIA");
            }

            return clientes.Dequeue();
        }

        public T Peek()
        {
            if (clientes.Count == 0)
            {
                throw new InvalidOperationException("A FILA ESTÁ VAZIA");
            }

            return clientes.Peek();
        }

        public IEnumerable<T> Listar()
        {
            return clientes;
        }
    }
}