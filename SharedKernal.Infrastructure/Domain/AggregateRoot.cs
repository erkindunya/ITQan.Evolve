﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernal.Infrastructure.Domain
{
    public interface AggregateRoot
    {
        bool CanBeSaved { get; }
    }
}
