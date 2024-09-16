namespace LangChain.Providers;

public static class WithDebugExtensions
{
    public static T UseConsoleForDebug<T>(this T model) where T : IChatModel
    {
        model.RequestSent += (_, request) =>
        {
            Console.Write(request.Messages.AsHistory());
        };
        model.DeltaReceived += (_, delta) =>
        {
            Console.Write(delta.Content);
        };

        return model;
    }
}