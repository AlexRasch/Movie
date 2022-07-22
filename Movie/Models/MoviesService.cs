using System.Collections.Generic;

namespace Movie.Models
{
    public class MoviesService
    {

        public  Dictionary<int?, string> movieDic = new Dictionary<int?, string>(){
            {0,"IT"},
            {1,"IT 2"},
            {2,"Nemo"}
        };


        public string GetAll()
        {
            string szOut = "";

            foreach (var item in movieDic)
            {
                szOut += item.Value + "|";
            }

            return szOut.Substring(0, szOut.Length - 1);
        }
    }
}
