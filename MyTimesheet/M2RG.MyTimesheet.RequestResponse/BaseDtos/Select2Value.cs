namespace M2RG.MyTimesheet.RequestResponse.BaseDtos
{
    public class Select2Value
    {
        public Select2Value() : this(0, "")
        {
        }

        public Select2Value(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public int Id { get; set; }
        public string Text { get; set; }
    }
}
