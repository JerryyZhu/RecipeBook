using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecipeBook.Helper
{
    public class RecipeUtils
    {
        public static string createIdFromUri(string s)
        {
            // "http://www.edamam.com/ontologies/edamam.owl#recipe_b79327d05b8e5b838ad6cfd9576b30b6"
            // want to return just "b79327d05b8e5b838ad6cfd9576b30b6"
            // TODO: error handling
            string pattern = @"\#recipe_([a-zA-z0-9]*)$";
            Regex r = new Regex(pattern);
            Match m = r.Match(s);
            return m.Groups[1].ToString();
        }
    }
}
