// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace PtEFLib
{

    // Option
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public class Option
    {
        public int OptionId { get; set; } // OptionId (Primary key)
        public string OptionText { get; set; } // OptionText (length: 150)
        public int QuestionId { get; set; } // QuestionId
        public string Letter { get; set; } // Letter (length: 1)

        public Option()
        {
            Letter = "0";
        }
    }

}
// </auto-generated>
