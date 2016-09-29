//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeoQuiz.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestingResult
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestingResult()
        {
            this.TestingResultAnswer = new HashSet<TestingResultAnswer>();
        }
    
        public int Id { get; set; }
        public int TestingURLId { get; set; }
        public System.DateTime TestingStart { get; set; }
        public System.DateTime TestingEnd { get; set; }
        public int QuestionsTried { get; set; }
        public int CorrectAnswers { get; set; }
        public int Score { get; set; }
    
        public virtual TestingURL TestingURL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestingResultAnswer> TestingResultAnswer { get; set; }
    }
}