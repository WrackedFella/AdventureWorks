﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Production
{
    public class ProductModelIllustration : EntityBase
    {
	    [Key]
        public int ProductModelId { get; set; }
        [Key]
        public int IllustrationId { get; set; }

        public virtual Illustration Illustration { get; set; }
        public virtual ProductModel ProductModel { get; set; }
    }
}
