namespace MyFirstMauiApp;

public class GlobalFontSizeExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
		return MainPage.FontSize;
    }
}

