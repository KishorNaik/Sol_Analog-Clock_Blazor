/// <reference path="jquery-3.5.1.min.js" />
/// <reference path="jquery.ht-analog-clock.min.js" />

function setAnalogClock(elementRef, enumHashCode) {
    //$(elementRef).htAnalogClock(htAnalogClock.preset_modern_dark);

    //console.log(enumHashCode);

    let clockType = null;

    if (enumHashCode === 0) {
        clockType = htAnalogClock.preset_default;
    }
    else if (enumHashCode === 1) {
        clockType = htAnalogClock.preset_gray_fantastic;
    }
    else if (enumHashCode === 2) {
        clockType = htAnalogClock.preset_black_bolded;
    }
    else if (enumHashCode === 3) {
        clockType = htAnalogClock.preset_nice_bolded;
    }
    else if (enumHashCode === 4) {
        clockType = htAnalogClock.preset_ocean_blue;
    }
    else if (enumHashCode === 5) {
        clockType = htAnalogClock.preset_white_nice;
    }
    else if (enumHashCode === 6) {
        clockType = htAnalogClock.preset_modern_dark;
    }

    $(elementRef).htAnalogClock(clockType);
}