// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    /// <summary>
    ///     <para>
    ///         Indicates when a value for a property will be generated by the database.
    ///     </para>
    ///     <para>
    ///         Even when a property is set to be generated by the database, EF may still attempt to save
    ///         a specific value (rather than having one generated by the database) when an entity is added
    ///         and a value is assigned, or the property is marked as modified for an existing entity.
    ///         See <see cref="PropertyValueBehavior" /> for more details.
    ///     </para>
    /// </summary>
    [Flags]
    public enum ValueGenerated
    {
        /// <summary>
        ///     A value is never generated by the database.
        /// </summary>
        Never = 0,

        /// <summary>
        ///     A value is generated by the database when an entity is first added to the database. The most common
        ///     scenario for this is generated primary key values.
        /// </summary>
        OnAdd = 1,

        /// <summary>
        ///     No value is generated when the entity is first added to the database, but a value will be read
        ///     from the database whenever the entity is subsequently updated.
        /// </summary>
        OnUpdate = 2,

        /// <summary>
        ///     A value is read from the database when the entity is first added and whenever the entity
        ///     is subsequently updated. This is typically used for computed columns and scenarios such as
        ///     rowversions, timestamps, etc.
        /// </summary>
        OnAddOrUpdate = OnAdd | OnUpdate
    }
}
