namespace Simple.Web.Example
{
    // Show a basic example of a IGet
    [UriTemplate("/")]
    public class Index : IGet
    {
        public Status Get()
        {
            return Status.OK;
        }

    }
}