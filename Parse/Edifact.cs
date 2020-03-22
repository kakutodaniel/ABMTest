using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Parse
{
    [DebuggerDisplay("2nd: {Second} # 3rd: {Third}")]
    public class Edifact
    {
        public string Second { get; private set; }

        public string Third { get; private set; }

        private string Message { get; set; }

        /// <summary>
        /// public constructor
        /// </summary>
        /// <param name="message"></param>
        public Edifact(string message)
        {
            this.Message = message;
        }

        private Edifact(string sec, string th)
        {
            this.Second = sec;
            this.Third = th;
        }

        /// <summary>
        /// get second and third elements from message
        /// </summary>
        /// <param name="delimiter">split delimiter</param>
        /// <param name="segment">segment name</param>
        /// <returns></returns>
        public List<Edifact> GetSecondAndThirdElements(char delimiter, string segment)
        {
            var result = new List<Edifact>();

            this.Message
                 .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => x.Trim())
                 .Where(x => x.StartsWith(segment.ToUpper()))
                 .ToList()
                 .ForEach(x =>
                 {
                     var items = x.Split(delimiter);
                     var el_2 = items.ElementAtOrDefault(1);
                     var el_3 = items.ElementAtOrDefault(2);

                     result.Add(new Edifact(el_2, el_3));
                 });

            return result;
        }
    }
}
