﻿using FluentMigrator;
using Nop.Core.Domain.Catalog;
using Nop.Data.Extensions;

namespace Nop.Data.Migrations.Indexes
{
    [NopMigration("2019/12/19 09:36:08:9037703")]
    public class AddProductPublishedIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            this.AddIndex("IX_Product_Published", nameof(Product), i => i.Ascending(), nameof(Product.Published));
        }

        #endregion
    }
}