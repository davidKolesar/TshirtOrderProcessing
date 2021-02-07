using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingApplication.Model
{
    //Have your Entity class be a abstract class that will be extended 
    //It is abstract because it has characteristics that all your domain classes will contain.
    public abstract class Entity
    {
        //Set your Id as a primary key.
        [Key]
        //All your domain classes contain a id of type integar.
        public Guid Id { get; set; }
    }
}
