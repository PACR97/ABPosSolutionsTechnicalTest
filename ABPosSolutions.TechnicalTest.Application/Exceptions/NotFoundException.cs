namespace ABPosSolutions.TechnicalTest.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, string key) : base($"Entity {name} referenced by {key} was not found")
        {

        }
    }
}
