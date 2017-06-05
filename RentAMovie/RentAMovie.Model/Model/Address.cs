using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace RentAMovie.Model
{

    public interface IBaseModel
    {
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }

    }
    //public class DateConvention : Convention
    //{
    //    public DateConvention()
    //    {
           
    //        this.Properties().Where(x => x.Name == "CreateDate")
    //            .Configure(x =>
    //                {
    //                    x.HasColumnType("Datetime");
    //                    x.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema
    //                        .DatabaseGeneratedOption.Computed);
    //                }
    //            );
                
    //        this.Properties<DateTime>()
    //            .Configure(c => c.HasColumnType("datetime2").HasPrecision(3));

    //        this.Properties<DateTime>()
    //            .Where(x => x.GetCustomAttributes(false).OfType<DataTypeAttribute>()
    //                .Any(a => a.DataType == DataType.Date))
    //            .Configure(c => c.HasColumnType("date"));
    //    }
    //}
    public class BaseModel  : IBaseModel
    {
        private DateTime _createdDate;
        private DateTime _updatedDate;

        public DateTime CreatedDate
        {
            get => _createdDate == DateTime.MinValue ? DateTime.UtcNow :_createdDate;
            set => _createdDate = value;
        }

        public DateTime UpdatedDate
        {
            get => _updatedDate == DateTime.MinValue ? DateTime.UtcNow : _updatedDate;
            set => _updatedDate = value;
        }
    }
    public class Address : BaseModel
    {
        public long CustomerId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public short AddressTypeId { get; set; }
        public string State { get; set; }
        public bool Active { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual AddressType AddressType { get; set; }
    }
}