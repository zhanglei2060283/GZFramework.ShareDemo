
namespace _GZFramework.Demo.Library.Config
{
    public class Config
    {
        public Config()
        {
            GZFramework.DB.Core.Config.DBConfig = new _GZFramework.Demo.Library.Config.DBConnBuilder.DBConfig();

            GZFramework.DB.Config.DefaultConflictOption = System.Data.ConflictOption.CompareAllSearchableValues;

            new _GZFramework.Demo.Library.Config.RibbonButtons.RiibonButtonsConfig();
        }
    }

}
