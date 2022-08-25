// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using System.Threading.Tasks;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public partial class HorizontalStackLayout : StackBase
    {
        static HorizontalStackLayout()
        {
            ElementHandlerRegistry.RegisterElementHandler<HorizontalStackLayout>(
                renderer => new HorizontalStackLayoutHandler(renderer, new MC.HorizontalStackLayout()));

            RegisterAdditionalHandlers();
        }

        public new MC.HorizontalStackLayout NativeControl => ((HorizontalStackLayoutHandler)ElementHandler).HorizontalStackLayoutControl;

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);


            RenderAdditionalAttributes(builder);
        }

        partial void RenderAdditionalAttributes(AttributesBuilder builder);

        static partial void RegisterAdditionalHandlers();
    }
}
