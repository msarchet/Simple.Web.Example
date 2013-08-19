namespace Simple.Web.Example.Startup
{
    public class Statics : IStartupTask
    {
        #region IStartupTask Members

        public void Run(IConfiguration configuration, IWebEnvironment environment)
        {
            configuration.PublicFolders.Add("/Scripts");
        }

        #endregion
    }
}