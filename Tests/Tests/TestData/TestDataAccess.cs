using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Tests.Models;

namespace Tests.TestData
{
    public static class TestDataAccess
    {
        private static string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string testDataPath = Path.Combine(assemblyPath, "TestData/TestData.json");

        public static List<UserDataModel> GetUserData()
        {
            string json = File.ReadAllText(testDataPath);
            var userData = JsonConvert.DeserializeObject<List<UserDataModel>>(json);
            return userData;
        }
    }
}