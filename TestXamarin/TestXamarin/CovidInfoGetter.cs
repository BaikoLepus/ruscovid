using ServiceStack;

namespace TestXamarin
{
    public static class CovidInfoGetter
    {
        static public string GetCases()
        {
            string url = "https://coronavirus-19-api.herokuapp.com/countries/russia";
            return url.GetJsonFromUrl().FromJson<CovidInfo>().Cases.ToString();

        }
    }
}
