namespace ABPosSolutions.TechnicalTest.Domain.Common
{
    public class BaseDomainModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
