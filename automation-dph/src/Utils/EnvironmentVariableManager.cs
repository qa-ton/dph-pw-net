
namespace automation_dph.src.Utils
{
	public class EnvironmentVariableManager
    {
		public EnvironmentVariableManager()
		{

		}

        public static void SetValue(ILocator elementValue, string value)
        {
            Environment.SetEnvironmentVariable(elementValue.ToString(), value);
        }

        public static string GetValue(ILocator elementValue)
        {
            return Environment.GetEnvironmentVariable(elementValue.ToString())!;
        }
    }
}

