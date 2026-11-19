using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }

        protected BaseModel()
        {
            IsDelete = false;
        }
    }
}
