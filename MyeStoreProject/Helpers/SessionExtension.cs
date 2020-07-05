using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace MyeStoreProject.Helpers
{
    //public static class SessionExtension
    //{
    //    public static void SetSession<TNN>(this ISession session, string key, NN value)
    //    {
    //        var jsonObj = JsonSerializer.Serialize(value);
    //        session.SetString(key, jsonObj);
    //    }

    //    public static NotFiniteNumberException GetSession<NN>(this ISession session, string key)
    //    {
    //        var value = session.GetString(key);
    //        return value == null ? default : JsonSerializer.Deserialize<NN>(value);
    //    }
    //}

    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }
}
