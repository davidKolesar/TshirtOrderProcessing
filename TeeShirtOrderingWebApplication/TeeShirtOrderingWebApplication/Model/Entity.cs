using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingApplication.Model
{
    //Class is abstract because it has characteristics that all your domain classes will contain.
    public abstract class Entity
    {
        //Convention to set id as a primary key.
        [Key]
        
        public Guid Id { get; set; }
    }
}
