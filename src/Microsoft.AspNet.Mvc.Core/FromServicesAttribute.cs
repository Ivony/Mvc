// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNet.Mvc.ModelBinding;

namespace Microsoft.AspNet.Mvc
{
    /// <summary>
    /// Specifies that an action parameter should be bound using the request services.
    /// </summary>
    /// <example>
    /// In this example an implementation of IProductModelRequestService is registered as a service.
    /// Then in the GetProduct action, the parameter is bound to an instance of IProductModelRequestService
    /// which is resolved from the the request services.
    ///
    /// <code>
    /// [HttpGet]
    /// public ProductModel GetProduct([FromServices] IProductModelRequestService productModelReqest)
    /// {
    ///     return productModelReqest.Value;
    /// }
    /// </code>
    /// </example> 
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
    public class FromServicesAttribute : Attribute, IBindingSourceMetadata
    {
        /// <inheritdoc />
        public BindingSource BindingSource => BindingSource.Services;
    }
}
