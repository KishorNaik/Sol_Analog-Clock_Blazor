using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnalogClock
{
    public enum AnalogClockType
    {
        Default = 0,
        Gray_Fantastic = 1,
        Black_Bolded = 2,
        Nice_Bolded = 3,
        Ocean_Blue = 4,
        White_Nice = 5,
        Modern_Dark = 6
    };

    public partial class AnalogClockComponent
    {
        #region Public Prameter Property

        [Parameter]
        public int Height { get; set; }

        [Parameter]
        public AnalogClockType ClockType { get; set; }

        #endregion Public Prameter Property

        #region Public Inject Property

        [Inject]
        public IJSRuntime JSRuntimeObj { get; set; }

        #endregion Public Inject Property

        #region Private Property

        private ElementReference ElementReferenceId { get; set; }

        #endregion Private Property

        #region Protected Method

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await ElementReferenceId.SetAnalogClock(JSRuntimeObj, ClockType.GetHashCode());

                base.StateHasChanged();
            }
        }

        #endregion Protected Method
    }
}