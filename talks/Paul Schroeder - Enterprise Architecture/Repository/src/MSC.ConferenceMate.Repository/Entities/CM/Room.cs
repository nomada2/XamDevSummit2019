// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MSC.ConferenceMate.Repository.Entities.CM
{

    // Room
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class Room
    {
        public int RoomId { get; set; } // RoomId (Primary key)
        public string Title { get; set; } // Title (length: 1000)
        public string ShortTitle { get; set; } // ShortTitle (length: 500)
        public string Description { get; set; } // Description (length: 4000)
        public int SeatingCapacity { get; set; } // SeatingCapacity
        public double Latitude { get; set; } // Latitude
        public double Longitude { get; set; } // Longitude
        public int DataVersion { get; set; } // DataVersion
        public System.DateTime CreatedUtcDate { get; set; } // CreatedUtcDate
        public string CreatedBy { get; set; } // CreatedBy (length: 200)
        public System.DateTime ModifiedUtcDate { get; set; } // ModifiedUtcDate
        public string ModifiedBy { get; set; } // ModifiedBy (length: 200)
        public bool IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child Sessions where [Session].[RoomId] point to this entity (FK_Session_Room)
        /// </summary>
        public System.Collections.Generic.ICollection<Session> Sessions { get; set; } // Session.FK_Session_Room

        public Room()
        {
            DataVersion = 1;
            CreatedUtcDate = System.DateTime.UtcNow;
            ModifiedUtcDate = System.DateTime.UtcNow;
            IsDeleted = false;
            Sessions = new System.Collections.Generic.List<Session>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
