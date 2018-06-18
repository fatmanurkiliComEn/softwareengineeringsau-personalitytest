using System.Collections.Generic;
using PtEFLib;

namespace PersonalityTest.Models
{
    public class Survey : Question
    {
        public List<Option> QOptions { get; set; }
    }
}