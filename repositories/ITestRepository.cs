
using System.Collections.Generic;
using SinglePageTestWebsite.Entities;

public interface ITestApiRepository
    {
        IEnumerable<TestApi> GetTestApis();
        IEnumerable<TestApi> GetResult(String q);
    }
