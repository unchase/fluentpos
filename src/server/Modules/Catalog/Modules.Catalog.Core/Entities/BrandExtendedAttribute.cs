﻿using System;
using FluentPOS.Shared.Core.Domain;

namespace FluentPOS.Modules.Catalog.Core.Entities
{
    public class BrandExtendedAttribute : ExtendedAttribute<Guid, Brand>
    {
        protected override Guid GenerateNewId()
        {
            return Guid.NewGuid();
        }
    }
}