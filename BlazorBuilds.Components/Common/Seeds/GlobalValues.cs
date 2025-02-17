namespace BlazorBuilds.Components.Common.Seeds;

internal class GlobalValues
{
    public const string JavaScript_Register_Func            = "registerTextDebounce";
    public const string JavaScript_UnRegister_Func          = "unRegisterTextDebounce";
    public const string JavaScript_File_Path                = "./_content/BlazorBuilds.Components/assets/js/text-debounce.js";
                                                            
    public const string LabelText_Exception_Message         = "The label text parameter is required. It cannot be null, empty or whitespace";
    public const string HintText_Exception_Message          = "The hint text parameter is required. It cannot be null, empty or whitespace";

    public const string TextDebounce_Class                  = "text-debounce";
    public const string TextDebounce_Text_Input_Class       = $"{TextDebounce_Class}__text-input";
    public const string TextDebounce_Hint_Content_Class     = $"{TextDebounce_Class}__hint-content";
    public const string TextDebounce_Hint_Text_Class        = $"{TextDebounce_Class}__hint-text";
    public const string TextDebounce_Hint_Text_Hidden_Class = $"{TextDebounce_Hint_Text_Class}--hidden";
    public const string TextDebounce_Label_Class            = $"{TextDebounce_Class}__label";
    public const string TextDebounce_Icon_Class             = $"{TextDebounce_Class}__icon";
    public const string TextDebounce_State_Icon_Class       = $"{TextDebounce_Class}__state-icon";
    public const string TextDebounce_SR_Only_Class          = $"{TextDebounce_Class}__screen-reader-only";


    public const string TextDebounce_Aria_Invalid_Text      = "Invalid entry";

    public const string TextDebounce_Regex_Pattern          = @"^(?=.{0,25}$)([A-Za-z0-9]+(['\- ][A-Za-z0-9]+)*)?$";//a to z, 0 to 9, single apostrophe's, spaces and dashes max 25 characters or empty to clear filter.
    public const int    TextBounce_DelayMs                  = 300;

    
    public const string Style_As_Dark  = "dark";
    public const string Style_As_Light = "light";

    public static string? GetStyleAsValue(StyleAs styleAs)

    => styleAs switch
    {
        StyleAs.OnLight => Style_As_Light,
        StyleAs.OnDark => Style_As_Dark,
        _ => null
    };
}
