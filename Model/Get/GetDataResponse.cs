namespace ETIQA.Model.Get
{
    public class GetDataResponse
    {
        public List<GetDataModel> Items { get; set; }
        public string? Status { get; set; }
        public long? Tick { get; set; }
    }
}
