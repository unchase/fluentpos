﻿using System;
using FluentPOS.Shared.Core.Domain;

namespace FluentPOS.Modules.People.Core.Entities
{
    public class CustomerExtendedAttribute : ExtendedAttribute<Guid, Customer>
    {
        protected override Guid GenerateNewId()
        {
            return Guid.NewGuid();
        }
    }
}