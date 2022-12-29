namespace WapiDemo.Models
{
    public class ResponseV
    {
        public string Text { get; set; }
        public Dictionary<char,int> HistogramData { get; set; } = new Dictionary<char,int>();

    }
}
