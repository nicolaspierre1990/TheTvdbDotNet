using System;
using System.Collections.Generic;
using System.Linq;

namespace TheTvdbDotNet.Http;

public class Request(string resource, object id)
{
    private readonly string resource = resource;
    private readonly object id = id;
    private readonly List<Tuple<string, string>> criteria = [];

    public Request(string resource)
        : this(resource, null)
    {
    }

    public void AddCriteria(string name, string value) => criteria.Add(new Tuple<string, string>(name, value));

    public void AddCriteriaIfNotNull(string name, string value)
    {
        if (value != null)
        {
            AddCriteria(name, value);
        }
    }

    public string BuildRequest() =>
        BuildResource() + BuildCriteria();

    private string BuildResource() =>
        id == null ? resource : BuildResourceWithId();

    private string BuildResourceWithId() =>
        resource.Replace("{id}", EncodeString(id.ToString()));

    private string BuildCriteria() =>
        criteria.Count != 0 ?
            "?" + criteria
                .Select(x => string.Concat(EncodeString(x.Item1), "=", EncodeString(x.Item2)))
                .Aggregate((x, y) => string.Concat(x, "&", y)) :
            string.Empty;

    private static string EncodeString(string value) =>
        Uri.EscapeDataString(value);
}
