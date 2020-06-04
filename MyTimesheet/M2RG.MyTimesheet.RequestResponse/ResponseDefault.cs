namespace M2RG.MyTimesheet.RequestResponse
{
    public class ResponseDefault<T> where T : class
    {
        public ResponseDefault()
        {
        }

        public T Entity { get; set; }
        public int UsuarioId { get; set; }
    }
}
