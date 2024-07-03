public class MainPage
{
    ITranslation _translation;

    // Dependency injection:
    // 1.- Constructor is not responsible for creating a instance, it only receives it.
    public MainPage(ITranslation translation)
    {
        _translation = translation;
    }

    public void Button_Clicked()
    {
        Console.WriteLine( _translation.Translate("Hello") );        
    }
}