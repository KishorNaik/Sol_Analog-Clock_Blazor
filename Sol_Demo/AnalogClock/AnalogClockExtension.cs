using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnalogClock
{
    public static class AnalogClockExtension
    {
        public static async Task SetAnalogClock(this ElementReference elementReference, IJSRuntime jSRuntime, int enumHasCode)
        {
            await jSRuntime.InvokeVoidAsync(identifier: "setAnalogClock", elementReference, enumHasCode);
        }
    }
}