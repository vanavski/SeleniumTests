namespace TEST1.Tests
{
    public class RepositoryDescription
    {
        public string Header { get; set; }
        public string Footer { get; set; }

        public RepositoryDescription(string header, string footer)
        {
            Header = header;
            Footer = footer;
        }
    }
}
