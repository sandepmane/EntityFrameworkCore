﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query.Pipeline;

namespace Microsoft.EntityFrameworkCore.InMemory.Query.Pipeline
{
    public class InMemoryEntityQueryableExpressionVisitorsFactory : EntityQueryableExpressionVisitorsFactory
    {
        private readonly IModel _model;

        public InMemoryEntityQueryableExpressionVisitorsFactory(IModel model)
        {
            _model = model;
        }

        public override EntityQueryableExpressionVisitors Create(QueryCompilationContext2 queryCompilationContext)
        {
            return new InMemoryEntityQueryableExpressionVisitors(_model);
        }
    }
}
