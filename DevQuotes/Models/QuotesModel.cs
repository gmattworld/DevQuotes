namespace DevQuotes.Models
{
    public class QuotesModel
    {
        public string _id { get; set; }
        public string id { get; set; }
        public string sr { get; set; }
        public string en { get; set; }
        public string author { get; set; }
        public string addedBy { get; set; }
        public string source { get; set; }
        public double rating { get; set; }
        public int numberOfVotes { get; set; }
    }
}
