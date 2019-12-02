namespace TEST1.Tests
{
    public class Repository
    {
        public string Header { get; set; }
        public string Footer { get; set; }

        public Repository(string header, string footer)
        {
            Header = header;
            Footer = footer;
        }
    }
}
